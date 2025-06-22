using Npgsql;
using projectakhirsem2.Database;
using projectakhirsem2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace projectakhirsem2.Controller
{
    public class PaketJasaController : IPaketJasaController
    {
        public virtual List<ModelPaketJasa> GetAll()
        {
            try
            {
                List<ModelPaketJasa> list = new List<ModelPaketJasa>();
                DataTable dt = DB.ExecuteQuery("SELECT * FROM paket_jasa ORDER BY id_paket_jasa");

                foreach (DataRow row in dt.Rows)
                {
                    var paket = new ModelPaketJasa(
                        Convert.ToInt32(row["id_paket_jasa"]),
                        row["nama_paket"].ToString(),
                        Convert.ToInt32(row["harga"]),
                        row["deskripsi"].ToString(),
                        Convert.ToInt32(row["id_jenis_layanan"]),
                        "-"
                    );
                    list.Add(paket);
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return new List<ModelPaketJasa>();
            }
        }

        public virtual void Add(string nama, int idJenis, int harga, string deskripsi)
        {
            DB.ExecuteNonQuery(
                "INSERT INTO paket_jasa(nama_paket, id_jenis_layanan, harga, deskripsi) VALUES (@nama, @jenis, @harga, @deskripsi)",
                new NpgsqlParameter("@nama", nama),
                new NpgsqlParameter("@jenis", idJenis),
                new NpgsqlParameter("@harga", harga),
                new NpgsqlParameter("@deskripsi", deskripsi)
            );
            MessageBox.Show("Paket jasa berhasil ditambahkan");
        }

        public virtual void Update(int id, string nama, int idJenis, int harga, string deskripsi)
        {
            try
            {
                int rows = DB.ExecuteNonQuery(
                    "UPDATE paket_jasa SET nama_paket = @nama, id_jenis_layanan = @jenis, harga = @harga, deskripsi = @deskripsi WHERE id_paket_jasa = @id",
                    new NpgsqlParameter("@nama", nama),
                    new NpgsqlParameter("@jenis", idJenis),
                    new NpgsqlParameter("@harga", harga),
                    new NpgsqlParameter("@deskripsi", deskripsi),
                    new NpgsqlParameter("@id", id)
                );

                MessageBox.Show($"{rows} Berhasil diupdate");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        public virtual void Delete(int id)
        {
            DB.ExecuteNonQuery(
                "DELETE FROM paket_jasa WHERE id_paket_jasa = @id",
                new NpgsqlParameter("@id", id)
            );
            MessageBox.Show("Paket jasa berhasil dihapus");
        }
    }
}
