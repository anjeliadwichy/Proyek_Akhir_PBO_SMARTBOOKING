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
    public class FotograferController : IFotograferController
    {
        public List<ModelFotografer> GetAll()
        {
            try
            {
                List<ModelFotografer> list = new List<ModelFotografer>();
                DataTable dt = DB.ExecuteQuery("SELECT * FROM fotografer ORDER BY id_fotografer");

                foreach (DataRow row in dt.Rows)
                {
                    var paket = new ModelFotografer(Convert.ToInt32(row["id_fotografer"]), row["nama"].ToString(), row["email"].ToString(), row["no_telepon"].ToString());
                    list.Add(paket);
                }
                
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return new List<ModelFotografer>();
            }
        }

        public void Add(string nama, string email, string no_telepon)
        {
            DB.ExecuteNonQuery("INSERT INTO fotografer(nama, email, no_telepon) VALUES (@nama, @email, @no_telepon)",
                new NpgsqlParameter("@nama", nama),
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@no_telepon", no_telepon)
            );
            MessageBox.Show("Fotografer berhasil ditambahkan");
        }
        public void Update(int id, string nama, string email, string no_telepon)
        {
            DB.ExecuteNonQuery("UPDATE fotografer SET nama = @nama, email = @email, no_telepon = @no_telepon WHERE id_fotografer = @id",
                new NpgsqlParameter("@nama", nama),
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@no_telepon", no_telepon),
                new NpgsqlParameter("@id", id)
            );
            MessageBox.Show("Fotografer berhasil diupdate");
        }

        public int GetJumlahFotografer()
        {
            try
            {
                DataTable dt = DB.ExecuteQuery("SELECT COUNT(*) AS jumlahfotografer FROM fotografer");
                return Convert.ToInt32(dt.Rows[0]["jumlahfotografer"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal hitung fotografer: {ex.Message}");
                return 0;
            }
        }

        public void Delete(int id)
        {
            DB.ExecuteNonQuery("DELETE FROM fotografer WHERE id_fotografer = @id",
                new NpgsqlParameter("@id", id)
            );
            MessageBox.Show("Fotografer berhasil dihapus");
        }
    }
}
