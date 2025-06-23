using projectakhirsem2.Controller;
using projectakhirsem2.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace projectakhirsem2.View
{
    public partial class ViewBooking : Form
    {
        IStatusBookingController statusBookingController = new StatusBookingController();
        IPaketJasaController paketJasaController = new PaketJasaController();
        IBookingController bookingController = new BookingController();
        public ViewBooking()
        {
            InitializeComponent();
            
        }

        protected void LoadComboBoxPaket()
        {
            var listpaket = paketJasaController.GetAll();
            if (listpaket != null && listpaket.Count > 0)
            {
                cbpaket.DataSource = listpaket;
                cbpaket.DisplayMember = "DisplayInfo";
                cbpaket.ValueMember = "id_paket_jasa";
            }
        }
        protected void LoadComboBoxStatus()
        {
            var liststatus = statusBookingController.GetAll();
            if (liststatus != null && liststatus.Count > 0)
            {
                cbstatus.DataSource = liststatus;
                cbstatus.DisplayMember = "status";
                cbstatus.ValueMember = "id_status_booking";
            }
        }

        protected void ClearInputFields()
        {
            dtptglmain.Value = DateTime.Now;
            dtpwaktumulai.Text = "00:00";
            dtpwaktuselesai.Text = "00:00";
            tbtempat.Clear();
            tbcatatan.Clear();
            cbpaket.SelectedIndex = 1;
            cbstatus.SelectedValue = 1;
        }

        protected void LoadBookingData()
        {
            dgvbooking.DataSource = bookingController.ViewRiwBooking(Session.id_pengguna);
        }


        private void ViewBooking_Load(object sender, EventArgs e)
        {
            LoadComboBoxPaket();
            LoadComboBoxStatus();
            LoadBookingData();

        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime tanggalBooking = DateTime.Now;
                DateTime tanggalPelaksanaan = dtptglmain.Value;
                TimeSpan waktuMulai = TimeSpan.Parse(dtpwaktumulai.Text);
                TimeSpan waktuSelesai = TimeSpan.Parse(dtpwaktuselesai.Text);
                string tempat = tbtempat.Text;
                string catatan = tbcatatan.Text;

                int idPengguna = Session.id_pengguna;
                int? idFotografer = null;
                int idStatus = 1;
                if (cbpaket.SelectedValue == null)
                {
                    MessageBox.Show("Silakan pilih paket terlebih dahulu.");
                    return;
                }
                int idPaket = Convert.ToInt32(cbpaket.SelectedValue);

                bool isConflict = bookingController.IsBookingConflict(
                     tanggalPelaksanaan,
                     waktuMulai,
                     waktuSelesai);

                //MessageBox.Show("DEBUG: Konflik? " + isConflict);

                if (isConflict)
                {
                    MessageBox.Show("Jadwal bentrok dengan booking lain. Silakan pilih waktu lain.");
                    return;
                }


                bookingController.Add(
                    tanggalBooking,
                    tanggalPelaksanaan,
                    waktuMulai,
                    waktuSelesai,
                    tempat,
                    catatan,
                    idPengguna,
                    idFotografer,
                    idStatus,
                    idPaket
                ); 
                LoadBookingData();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan: {ex.Message}");
            }

            dgvbooking.DataSource = bookingController.ViewRiwBooking(Session.id_pengguna);
        }
    }
}
