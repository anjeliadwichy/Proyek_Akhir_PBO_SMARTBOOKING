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
    public partial class ViewReview : Form
    {
 
        public ViewReview()
        {
            InitializeComponent();
        }

        private void LoadTableReview()
        {
            int id_pengguna = Session.id_pengguna;
            //MessageBox.Show($"ID Pengguna saat ini: {id_pengguna}");
            IBookingController controller = new BookingController();

            var data = controller.GetSelesaiBelumDireviewByPengguna(id_pengguna)
                .Select(b => new
                {
                    b.id_booking,
                    b.id_pengguna,
                    b.tanggal_pelaksanaan,
                    b.tempat
                }).ToList();

            dgvreview.DataSource = data;
            dgvreview.Columns["id_booking"].HeaderText = "ID Booking";
            dgvreview.Columns["tanggal_pelaksanaan"].HeaderText = "Tanggal Pelaksanaan";
            dgvreview.Columns["tempat"].HeaderText = "Tempat";
        }

        private void cleartb()
        {
            dtptglreview.Value = DateTime.Now;
            txtidbooking.Text = "";
            tbrating.Text = "";
            tbkomen.Text = "";
        }

        private void dgvreview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvreview.Rows[e.RowIndex];

                txtidbooking.Text = row.Cells["id_booking"].Value?.ToString();

                tbrating.Text = "";
                tbkomen.Text = "";
                dtptglreview.Value = DateTime.Now;

                dgvreview.Rows[e.RowIndex].Selected = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvreview.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih data booking terlebih dahulu.");
                    //MessageBox.Show($"SelectedRows.Count: {dgvreview.SelectedRows.Count}");
                    return;
                }

                IReviewController reviewController = new ReviewController();

                int rating = int.Parse(tbrating.Text); ;
                string komentar = tbkomen.Text;
                DateTime tanggal_review = DateTime.Now;
                int id_booking = Convert.ToInt32(dgvreview.SelectedRows[0].Cells["id_booking"].Value);;

                reviewController.AddReview(
                    rating,
                    komentar,
                    tanggal_review,
                    id_booking
                );
                cleartb();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan: {ex.Message}");
            }
            LoadTableReview();
        }

        private void ViewReview_Load(object sender, EventArgs e)
        {
            LoadTableReview();
        }
    }
}
