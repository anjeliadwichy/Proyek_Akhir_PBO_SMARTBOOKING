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

namespace projectakhirsem2.View
{
    public partial class ViewDashboard : Form
    {
        IFotograferController fotograferController = new FotograferController();
        IPenggunaController penggunaController = new PenggunaController();
        IBookingController bookingController = new BookingController();

        public ViewDashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbfotografer_Click(object sender, EventArgs e)
        {

        }

        private void ViewDashboard_Load(object sender, EventArgs e)
        {
            int jumlahfotografer = fotograferController.GetJumlahFotografer();
            lbfotografer.Text = jumlahfotografer.ToString();

            int jumlahpengguna = penggunaController.GetJumlahPengguna();
            lbpengguna.Text = jumlahpengguna.ToString();

            int jumlahbooking = bookingController.GetJumlahbooking();
            lbbooking.Text = jumlahbooking.ToString();

            int jumlahpending = bookingController.GetJumlahpending();
            lbpending.Text = jumlahpending.ToString();

            int jumlahsetujui = bookingController.GetJumlahsetujui();
            lbdisetujui.Text = jumlahsetujui.ToString();

            int jumlahbatal = bookingController.GetJumlahbatal();
            lbbatal.Text = jumlahbatal.ToString();

            int jumlahselesai = bookingController.GetJumlahselesai();
            lbselesai.Text = jumlahselesai.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
