using projectakhirsem2.Controller;
using projectakhirsem2.Database;
using projectakhirsem2.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectakhirsem2.View
{
    public partial class ViewAdmin : Form
    {
        NavigationController navigationController = new NavigationController();
        public ViewAdmin()
        {
            InitializeComponent();
            navigationController.NavigateDashboard(this);
        }

        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btdashboard_Click(object sender, EventArgs e)
        {
            labelswitch.Text = "Dashboard";
            navigationController.NavigateDashboard(this);
        }

        private void btdatabooking_Click(object sender, EventArgs e)
        {
            labelswitch.Text = "Data Booking";
            navigationController.NavigateBookingAdmin(this);
        }

        private void btpktjasa_Click(object sender, EventArgs e)
        {
            labelswitch.Text = "Paket Jasa";
            navigationController.NavigatePaketJasa(this);
        }

        private void btfotografer_Click(object sender, EventArgs e)
        {
            labelswitch.Text = "Fotografer";
            navigationController.NavigateFotografer(this);
        }

        private void btdatapengguna_Click(object sender, EventArgs e)
        {
            labelswitch.Text = "Data Pengguna";
            navigationController.NavigateDataPengguna(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewLogin formlogin = new ViewLogin();
            formlogin.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            labelswitch.Text = "Data Semua Review";
            navigationController.NavigateAllReview(this);
        }
    }
}
