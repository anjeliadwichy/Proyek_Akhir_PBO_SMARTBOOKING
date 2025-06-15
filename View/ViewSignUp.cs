using projectakhirsem2.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using BCrypt.Net;

namespace projectakhirsem2.View
{
    public partial class ViewSignUp : Form
    {
        IPenggunaController penggunaController = new PenggunaController();

        public ViewSignUp()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btbatal_Click(object sender, EventArgs e)
        {
            ViewLogin formLogin = new ViewLogin();
            formLogin.Show();
            this.Hide();
        }

        private void btsignup_Click(object sender, EventArgs e)
        {
            string nama = tbnama.Text;
            string email = tbemail.Text;
            string no_telepon = tbnotelp.Text;
            string password = tbpasswordsup.Text;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            penggunaController.Add(nama, email, no_telepon, password);

            ViewLogin formLogin = new ViewLogin();
            formLogin.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbpasswordsup.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void ViewSignUp_Load(object sender, EventArgs e)
        {
            tbpasswordsup.UseSystemPasswordChar = true;
        }
    }
}
