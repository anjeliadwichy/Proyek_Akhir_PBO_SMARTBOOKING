using projectakhirsem2.Database;
using projectakhirsem2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using BCrypt.Net;
using projectakhirsem2.View;

namespace projectakhirsem2.Controller
{
    public class PenggunaController : IPenggunaController
    {
        public List<ModelPengguna> GetAll()
        {
            try
            {
                List<ModelPengguna> list = new List<ModelPengguna>();
                DataTable dt = DB.ExecuteQuery("SELECT * FROM pengguna");

                foreach (DataRow row in dt.Rows)
                {
                    var data = new ModelPengguna(Convert.ToInt32(row["id_pengguna"]), row["nama"].ToString(), row["email"].ToString(), row["no_telepon"].ToString(), row["password"].ToString());
                    list.Add(data);
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
                return new List<ModelPengguna>();
            }
        }

        public void Add(string nama, string email, string no_telepon, string password)
        {
            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(no_telepon) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Semua data harus diisi.");
                return;
            }

            if (!email.Contains("@") || !email.Contains(".") || email.IndexOf("@") > email.LastIndexOf("."))
            {
                MessageBox.Show("Format email tidak valid.");
                return;
            }

            if (!no_telepon.All(char.IsDigit))
            {
                MessageBox.Show("Nomor telepon hanya boleh berisi angka.");
                return;
            }
            if (no_telepon.Length != 12)
            {
                MessageBox.Show("Nomor telepon harus terdiri dari 12 angka.");
                return;
            }
            if (!no_telepon.StartsWith("08"))
            {
                MessageBox.Show("Nomor telepon harus dimulai dengan '08'.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password minimal harus 6 karakter.");
                return;
            }

            DataTable dt = DB.ExecuteQuery("SELECT * FROM pengguna WHERE email = @email", new NpgsqlParameter("@email", email));
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Email sudah digunakan. Silakan gunakan email lain.");
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            DB.ExecuteNonQuery("INSERT INTO pengguna(nama, email, no_telepon, password) VALUES (@nama, @email, @no_telepon, @password)",
                new NpgsqlParameter("@nama", nama),
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@no_telepon", no_telepon),
                new NpgsqlParameter("@password", hashedPassword)
            );

            MessageBox.Show("Berhasil Sign Up");
        }

        public PenggunaBase Login(string email, string password)
        {
            DataTable dt = DB.ExecuteQuery("SELECT * FROM pengguna WHERE email = @email", new NpgsqlParameter("@email", email));

            if (dt.Rows.Count == 1)
            {
                string hashFromDb = dt.Rows[0]["password"].ToString();

                //MessageBox.Show($"Hash from DB: {hashFromDb}\nPassword match: {BCrypt.Net.BCrypt.Verify(password, hashFromDb)}");

                if (BCrypt.Net.BCrypt.Verify(password, hashFromDb))
                {
                    return new ModelPengguna(
                        Convert.ToInt32(dt.Rows[0]["id_pengguna"]),
                        dt.Rows[0]["nama"].ToString(),
                        dt.Rows[0]["email"].ToString(),
                        dt.Rows[0]["no_telepon"].ToString(),
                        dt.Rows[0]["password"].ToString()
                    );
                }
            }

            return null;
        }

        public int GetJumlahPengguna()
        {
            try
            {
                DataTable dt = DB.ExecuteQuery("SELECT COUNT(*) AS jumlahpengguna FROM pengguna");
                return Convert.ToInt32(dt.Rows[0]["jumlahpengguna"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal hitung pengguna: {ex.Message}");
                return 0;
            }
        }

    }
}
