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

namespace projectakhirsem2.View
{
    public partial class ViewBatalBooking : Form
    {
        public ViewBatalBooking()
        {
            InitializeComponent();
        }

        public void LoadTableBatal()
        {
            var bookings = new BookingController().GetAll()
                    .Where(b => b.id_pengguna == Session.id_pengguna &&
                       b.id_status_booking != 4)
                   .Select(b => new
                   {
                       b.id_booking,
                       b.tanggal_booking,
                       b.tanggal_pelaksanaan,
                       b.waktu_mulai,
                       b.waktu_selesai,
                       b.tempat,
                       b.catatan,
                       Status = b.id_status_booking == 1 ? "Pending" :
                        b.id_status_booking == 2 ? "Disetujui" : "Dibatalkan"
                   }).ToList();

            dgvbatalkan.DataSource = bookings;
            dgvbatalkan.Columns["id_booking"].HeaderText = "ID Booking";
            dgvbatalkan.Columns["tanggal_booking"].HeaderText = "Tanggal Booking";
            dgvbatalkan.Columns["tanggal_pelaksanaan"].HeaderText = "Tanggal Pelaksanaan";
            dgvbatalkan.Columns["waktu_mulai"].HeaderText = "Waktu Mulai";
            dgvbatalkan.Columns["waktu_selesai"].HeaderText = "Waktu Selesai";
            dgvbatalkan.Columns["tempat"].HeaderText = "Tempat";
            dgvbatalkan.Columns["catatan"].HeaderText = "Catatan";
            dgvbatalkan.Columns["Status"].HeaderText = "Status Booking";
        }

        public virtual void ClearInputFields()
        {
            tbidbooking.Clear();
        }

        private void ViewBatalBooking_Load(object sender, EventArgs e)
        {
            LoadTableBatal();
        }

        private void dgvbatalkan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbidbooking.Text = dgvbatalkan.Rows[e.RowIndex].Cells["id_booking"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbidbooking.Text, out int idBooking))
            {
                MessageBox.Show("Pilih booking yang valid.");
                return;
            }

            var booking = new BookingController().GetAll()
                .FirstOrDefault(b => b.id_booking == idBooking && b.id_pengguna == Session.id_pengguna);

            if (booking == null)
            {
                MessageBox.Show("Data booking tidak ditemukan.");
                return;
            }

            if (booking.id_status_booking == 1)
            {
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin membatalkan booking ini?",
                    "Konfirmasi Pembatalan",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    new BookingController().BatalkanBooking(idBooking);
                    MessageBox.Show("Booking berhasil dibatalkan.");
                    LoadTableBatal(); 
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Pembatalan booking dibatalkan.");
                }
            }
            else if (booking.id_status_booking == 2)
            {
                MessageBox.Show("Booking sudah disetujui. Hubungi admin di 0877-6596-9934 untuk membatalkan.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Booking tidak dalam status yang bisa dibatalkan.");
            }
        }
    }
}
