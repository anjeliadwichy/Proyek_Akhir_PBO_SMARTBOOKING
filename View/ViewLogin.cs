using BCrypt.Net;
using projectakhirsem2.Controller;
using projectakhirsem2.Helpers;
using projectakhirsem2.Model;
using projectakhirsem2.View;
using System;

namespace projectakhirsem2

{
    public partial class ViewLogin : Form
    {
        IPenggunaController penggunaController = new PenggunaController();
        public ViewLogin()
        {
            InitializeComponent();
        }

        private void btsignuplogin_Click(object sender, EventArgs e)
        {
            ViewSignUp formLogin = new ViewSignUp();
            formLogin.Show();
            this.Hide();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string email = tbemail.Text.Trim();
            string password = tbpassword.Text.Trim();

            try
            {
                if (email == "admin" && password == "admin123")
                {
                    Session.id_pengguna = 0;
                    Session.nama = "admin";

                    MessageBox.Show("Login sebagai admin berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ViewAdmin dashboard = new ViewAdmin();
                    dashboard.Show();
                    this.Hide();
                    return;
                }

                PenggunaBase hasilLogin = penggunaController.Login(email, password);

                if (hasilLogin != null)
                {
                    Session.id_pengguna = hasilLogin.id_pengguna;
                    Session.nama = hasilLogin.nama;

                    MessageBox.Show("Login berhasil. Selamat datang, " + hasilLogin.nama + "!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ViewPengguna viewpengguna = new ViewPengguna();
                    viewpengguna.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email atau password salah.", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbpassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void ViewLogin_Load(object sender, EventArgs e)
        {
            tbpassword.UseSystemPasswordChar = true;
        }
    }
}
