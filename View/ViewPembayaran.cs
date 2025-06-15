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
    public partial class ViewPembayaran : Form
    {
        IMetodePembayaranController metodePembayaranController = new MetodePembayaranController();
        IPembayaranController pembayaranController = new PembayaranController();
        public ViewPembayaran()
        {
            InitializeComponent();
        }

        private void LoadComboBoxMetode()
        {
            var listmetode = metodePembayaranController.GetAll();
            if (listmetode != null && listmetode.Count > 0)
            {
                cbmetode.DataSource = listmetode;
                cbmetode.DisplayMember = "metode_pembayaran";
                cbmetode.ValueMember = "id_metode_pembayaran";
            }
        }

        private void ViewPembayaran_Load(object sender, EventArgs e)
        {
            LoadComboBoxMetode();
            dgvpembayaran.DataSource = pembayaranController.GetBlmBayar();

        }

        private void dgvpembayaran_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvpembayaran.Rows[e.RowIndex];
                tbidbooking.Text = row.Cells["id_booking"].Value?.ToString();
                tbtotal.Text = row.Cells["total_harga"].Value?.ToString();

                dgvpembayaran.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbidbooking.Text, out int idBooking) || !int.TryParse(tbtotal.Text, out int totalHarga) || cbmetode.SelectedValue == null)
            {
                MessageBox.Show("Data tidak valid.");
                return;
            }

            int idMetode = Convert.ToInt32(cbmetode.SelectedValue);
            DateTime tanggalPembayaran = DateTime.Now;

            pembayaranController.Add(totalHarga, tanggalPembayaran, idMetode, idBooking);

            tbidbooking.Clear();
            tbtotal.Clear();
            dgvpembayaran.DataSource = pembayaranController.GetBlmBayar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
