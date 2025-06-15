using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectakhirsem2.Controller;
using projectakhirsem2.Database;
using projectakhirsem2.View;

namespace projectakhirsem2.View
{
    public partial class ViewPengguna : Form
    {
        NavigationController navigationController = new NavigationController();
        public ViewPengguna()
        {
            InitializeComponent();
            navigationController.NavigateViewOpen(this);
            label2.Text = "Selamat Datang";
        }

        private void btlogoutcust_Click(object sender, EventArgs e)
        {
            ViewLogin viewLogin = new ViewLogin();
            viewLogin.Show();
            this.Close();
        }

        private void btbokingjdwl_Click(object sender, EventArgs e)
        {
            label2.Text = "Booking Jadwal";
            navigationController.NavigateBooking(this);
        }

        private void btreviewcust_Click(object sender, EventArgs e)
        {
            label2.Text = "Beri Review";
            navigationController.NavigateReview(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Lihat Booking";
            navigationController.NavigateAllReview(this);
        }

        private void btbtlbooking_Click(object sender, EventArgs e)
        {
            label1.Text = "Batalkan Booking";
            navigationController.NavigateBatalBooking(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Metode Pembayaran";
            navigationController.NavigatePembayaran(this);
        }
    }
}
