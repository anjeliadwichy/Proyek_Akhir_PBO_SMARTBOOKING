using Npgsql;
using NpgsqlTypes;
using projectakhirsem2.Database;
using projectakhirsem2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Controller
{
    public class BookingController : IBookingController
    {
        public List<ModelBooking> GetAll()
        {
            try
            {
                List<ModelBooking> list = new List<ModelBooking>();
                DataTable dt = DB.ExecuteQuery("SELECT * FROM booking");
                foreach (DataRow row in dt.Rows)
                {
                    var booking = new ModelBooking(
                        Convert.ToInt32(row["id_booking"]),
                        Convert.ToDateTime(row["tanggal_booking"]),
                        Convert.ToDateTime(row["tanggal_pelaksanaan"]),
                        TimeSpan.Parse(row["waktu_mulai"].ToString()),
                        TimeSpan.Parse(row["waktu_selesai"].ToString()),
                        row["tempat"].ToString(),
                        row["catatan"] == DBNull.Value ? "" : row["catatan"].ToString(),
                        Convert.ToInt32(row["id_pengguna"]),
                        row["id_fotografer"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["id_fotografer"]),
                        Convert.ToInt32(row["id_status_booking"]),
                        Convert.ToInt32(row["id_paket_jasa"])
                    );
                    list.Add(booking);
                }
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return new List<ModelBooking>();
            }
        }

        public void Add(DateTime tanggal_booking, DateTime tanggal_pelaksanaan,
            TimeSpan waktu_mulai, TimeSpan waktu_selesai, string tempat, string catatan,
            int id_pengguna, int? id_fotografer, int id_status_booking, int id_paket_jasa)
        {
            if (waktu_mulai < TimeSpan.FromHours(8) || waktu_selesai > TimeSpan.FromHours(20))
            {
                MessageBox.Show("Waktu pelaksanaan hanya diperbolehkan antara jam 08:00 sampai 20:00.");
                return;
            }
            if (waktu_mulai >= waktu_selesai)
            {
                MessageBox.Show("Waktu mulai harus lebih awal dari waktu selesai.");
                return;
            }
            if (IsBookingConflict(tanggal_pelaksanaan, waktu_mulai, waktu_selesai))
            {
                MessageBox.Show("Jadwal sudah digunakan. Silakan pilih tanggal atau jam yang berbeda.");
                return;
            }

            DB.ExecuteNonQuery("INSERT INTO booking (tanggal_booking, tanggal_pelaksanaan, waktu_mulai, waktu_selesai, tempat, catatan, id_pengguna, id_fotografer, id_status_booking, id_paket_jasa) " +
                "VALUES (@tgl_bk, @tgl_pl, @mulai, @selesai, @tmp, @ctt, @pengguna, @fotogf, @status, @paket)",
                new NpgsqlParameter("@tgl_bk", tanggal_booking),
                new NpgsqlParameter("@tgl_pl", tanggal_pelaksanaan),
                new NpgsqlParameter("@mulai", waktu_mulai),
                new NpgsqlParameter("@selesai", waktu_selesai),
                new NpgsqlParameter("@tmp", tempat),
                new NpgsqlParameter("@ctt", catatan),
                new NpgsqlParameter("@pengguna", id_pengguna),
                new NpgsqlParameter("@fotogf", (object?)id_fotografer ?? DBNull.Value),
                new NpgsqlParameter("@status", id_status_booking),
                new NpgsqlParameter("@paket", id_paket_jasa)
            );
            MessageBox.Show("Booking jadwal berhasil ditambahkan\n\nNB: APABILA SUDAH DISETUJUI, SILAHKAN PILIH METODE PEMBAYARAN YANG TERDAPAT PADA MENU SIDEBAR");
        }

        public void UpdateStatusInputFotografer(int idBooking, int idStatus, int idFotografer)
        {
            DB.ExecuteNonQuery("UPDATE booking SET id_status_booking = @status, id_fotografer = @fotografer WHERE id_booking = @id",
                new NpgsqlParameter("@status", idStatus),
                new NpgsqlParameter("@fotografer", idFotografer),
                new NpgsqlParameter("@id", idBooking)
            );
            MessageBox.Show("Data Booking berhasil diperbarui.");
        }

        public void UpdateStatusOnly(int idBooking, int idStatus)
        {
            if (idStatus == 4)
            {
                DataTable dt = DB.ExecuteQuery("SELECT 1 FROM pembayaran WHERE id_booking = @id_booking",
                    new NpgsqlParameter("@id_booking", idBooking));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Status tidak dapat diubah menjadi 'Selesai' karena belum ada pembayaran.");
                    return;
                }
            }

            DB.ExecuteNonQuery("UPDATE booking SET id_status_booking = @status WHERE id_booking = @id",
                new NpgsqlParameter("@status", idStatus),
                new NpgsqlParameter("@id", idBooking)
            );

            MessageBox.Show("Status booking berhasil diperbarui.");
        }

        public List<ModelBooking> GetSelesaiBelumDireviewByPengguna(int id_pengguna)
        {
            string query = @"SELECT * FROM booking WHERE id_pengguna = @id_pengguna AND id_status_booking = 4 AND id_booking NOT IN (SELECT id_booking FROM review) ";

            var dt = DB.ExecuteQuery(query, new Npgsql.NpgsqlParameter("@id_pengguna", id_pengguna));

            List<ModelBooking> list = new List<ModelBooking>();
            foreach (DataRow row in dt.Rows)
            {
                var booking = new ModelBooking(
                    Convert.ToInt32(row["id_booking"]),
                    Convert.ToDateTime(row["tanggal_booking"]),
                    Convert.ToDateTime(row["tanggal_pelaksanaan"]),
                    TimeSpan.Parse(row["waktu_mulai"].ToString()),
                    TimeSpan.Parse(row["waktu_selesai"].ToString()),
                    row["tempat"].ToString(),
                    row["catatan"] == DBNull.Value ? "" : row["catatan"].ToString(),
                    Convert.ToInt32(row["id_pengguna"]),
                    row["id_fotografer"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["id_fotografer"]),
                    Convert.ToInt32(row["id_status_booking"]),
                    Convert.ToInt32(row["id_paket_jasa"])
                );
                list.Add(booking);
            }

            return list;
        }

        public DataTable ViewRiwBooking(int id_pengguna)
        {
            string query = @"
                SELECT p.nama as ""Nama Pengguna"",
                       b.tanggal_booking as ""Tanggal Booking"",
                       f.nama as ""Nama Fotografer"", 
                       s.status as ""Status Booking"", 
                       pj.nama_paket as ""Nama Paket"",
                       b.tanggal_pelaksanaan as ""Tanggal Pelaksanaan"",
                       b.waktu_mulai as ""Waktu Mulai"",
                       b.waktu_selesai as ""Waktu Selesai"",
                       b.tempat as ""Tempat"",
                       b.catatan as ""Catatan""
                FROM booking b
                JOIN pengguna p on b.id_pengguna = p.id_pengguna
                LEFT JOIN fotografer f on b.id_fotografer = f.id_fotografer
                JOIN status_booking s on b.id_status_booking = s.id_status_booking
                JOIN paket_jasa pj on b.id_paket_jasa = pj.id_paket_jasa
                WHERE b.id_pengguna = @id_pengguna
                GROUP BY p.nama, b.tanggal_booking, f.nama, s.status, pj.nama_paket,
                         b.tanggal_pelaksanaan, b.waktu_mulai, b.waktu_selesai, b.tempat, b.catatan";

            return DB.ExecuteQuery(query, new NpgsqlParameter("@id_pengguna", id_pengguna));
        }


        public void BatalkanBooking(int idBooking)
        {
            DB.ExecuteNonQuery("UPDATE booking SET id_status_booking = 3 WHERE id_booking = @id",
                new NpgsqlParameter("@id", idBooking));
        }

        public bool IsBookingConflict(DateTime tanggalPelaksanaan, TimeSpan waktuMulai, TimeSpan waktuSelesai)
        {
            using (var conn = DB.GetConnection())
            {
                string query = @"
                    SELECT 1
                    FROM booking
                    WHERE tanggal_pelaksanaan = @tanggal
                      AND waktu_mulai < @waktuSelesai
                      AND waktu_selesai > @waktuMulai
                    LIMIT 1";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@tanggal", NpgsqlDbType.Date) { Value = tanggalPelaksanaan });
                    cmd.Parameters.Add(new NpgsqlParameter("@waktuMulai", NpgsqlDbType.Time) { Value = waktuMulai });
                    cmd.Parameters.Add(new NpgsqlParameter("@waktuSelesai", NpgsqlDbType.Time) { Value = waktuSelesai });

                    conn.Open();
                    var result = cmd.ExecuteScalar();
                    return result != null;
                }
            }
        }

        public int GetJumlahbooking()
        {
            try
            {
                DataTable dt = DB.ExecuteQuery("SELECT COUNT(*) AS jumlahbooking FROM booking");
                return Convert.ToInt32(dt.Rows[0]["jumlahbooking"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal hitung: {ex.Message}");
                return 0;
            }
        }

        public int GetJumlahpending()
        {
            try
            {
                DataTable dt = DB.ExecuteQuery("SELECT COUNT(*) AS jumlahpending FROM booking WHERE id_status_booking = 1");
                return Convert.ToInt32(dt.Rows[0]["jumlahpending"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal hitung: {ex.Message}");
                return 0;
            }
        }

        public int GetJumlahsetujui()
        {
            try
            {
                DataTable dt = DB.ExecuteQuery("SELECT COUNT(*) AS jumlahsetujui FROM booking WHERE id_status_booking = 2");
                return Convert.ToInt32(dt.Rows[0]["jumlahsetujui"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal hitung: {ex.Message}");
                return 0;
            }
        }

        public int GetJumlahbatal()
        {
            try
            {
                DataTable dt = DB.ExecuteQuery("SELECT COUNT(*) AS jumlahbatal FROM booking WHERE id_status_booking = 3");
                return Convert.ToInt32(dt.Rows[0]["jumlahbatal"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal hitung: {ex.Message}");
                return 0;
            }

        }

        public int GetJumlahselesai()
        {
            try
            {
                DataTable dt = DB.ExecuteQuery("SELECT COUNT(*) AS jumlahselesai FROM booking WHERE id_status_booking = 4");
                return Convert.ToInt32(dt.Rows[0]["jumlahselesai"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal hitung: {ex.Message}");
                return 0;
            }

        }
    }
}
