using Npgsql;
using projectakhirsem2.Database;
using projectakhirsem2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectakhirsem2.Controller
{
    public class ReviewController : IReviewController
    {
        public List<ModelReview> GetAll()
        {
            try
            {
                List<ModelReview> list = new List<ModelReview>();
                DataTable dt = DB.ExecuteQuery("SELECT * FROM review ORDER BY id_review");

                foreach (DataRow row in dt.Rows)
                {
                    var review = new ModelReview(Convert.ToInt32(row["rating"]),
                        row["komentar"].ToString(),
                        Convert.ToDateTime(row["tanggal_review"]),
                        Convert.ToInt32(row["id_booking"])
                    );
                    list.Add(review);
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return new List<ModelReview>();
            }
        }

        public void AddReview(int rating, string komentar, DateTime tanggal_review, int id_booking)
        {
            if (rating < 1 || rating > 5)
            {
                MessageBox.Show("Rating harus bernilai antara 1 hingga 5.");
                return;
            }

            if (string.IsNullOrWhiteSpace(komentar))
            {
                MessageBox.Show("Komentar tidak boleh kosong.");
                return;
            }

            var dtCek = DB.ExecuteQuery("SELECT COUNT(*) FROM review WHERE id_booking = @id_booking",
                new NpgsqlParameter("@id_booking", id_booking));
            int count = Convert.ToInt32(dtCek.Rows[0][0]);
            if (count > 0)
            {
                MessageBox.Show("Review untuk booking ini sudah pernah diberikan.");
                return;
            }

            var dtStatus = DB.ExecuteQuery("SELECT id_status_booking FROM booking WHERE id_booking = @id_booking",
                new NpgsqlParameter("@id_booking", id_booking));
            if (dtStatus.Rows.Count == 0)
            {
                MessageBox.Show("Booking tidak ditemukan.");
                return;
            }

            int status = Convert.ToInt32(dtStatus.Rows[0]["id_status_booking"]);
            if (status != 4) // anggap 4 = selesai
            {
                MessageBox.Show("Review hanya dapat diberikan jika booking sudah selesai.");
                return;
            }

            DB.ExecuteNonQuery("INSERT INTO review (rating, komentar, tanggal_review, id_booking) " +
                "VALUES (@rating, @komentar, @tanggal_review, @id_booking)",
                new NpgsqlParameter("@rating", rating),
                new NpgsqlParameter("@komentar", komentar),
                new NpgsqlParameter("@tanggal_review", tanggal_review),
                new NpgsqlParameter("@id_booking", id_booking)
            );
            MessageBox.Show("Berhasil menambahkan rating");
        }

        public DataTable GetAllReview()
        {
            string query = @"
                SELECT DISTINCT 
                       p.nama AS ""Nama Pengguna"", 
                       pj.nama_paket AS ""Nama Paket"", 
                       r.rating, 
                       r.komentar, 
                       r.tanggal_review
                FROM review r 
                JOIN booking b ON r.id_booking = b.id_booking
                JOIN pengguna p ON b.id_pengguna = p.id_pengguna
                JOIN paket_jasa pj ON b.id_paket_jasa = pj.id_paket_jasa
                ORDER BY r.rating DESC;";

            return DB.ExecuteQuery(query);
        }
    }
}
