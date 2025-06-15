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
    public partial class ViewFotografer : Form
    {
        IFotograferController fotograferController = new FotograferController();
        public ViewFotografer()
        {
            InitializeComponent();
        }

        private void LoadTableFotografer()
        {
            var listPaket = fotograferController.GetAll();
            dgvfotografer.DataSource = listPaket;
            dgvfotografer.DataSource = null;
            dgvfotografer.DataSource = fotograferController.GetAll();
            dgvfotografer.Columns["id_fotografer"].HeaderText = "ID Fotografer";
            dgvfotografer.Columns["nama"].HeaderText = "Nama Fotografer";
            dgvfotografer.Columns["email"].HeaderText = "Email";
            dgvfotografer.Columns["no_telepon"].HeaderText = "No Telepon";
        }
        public void cleartb()
        {
            tbnamafoto.Clear();
            tbtelepon.Clear();
            tbemail.Clear();
        }

        private void dgvfotografer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvfotografer.Rows[e.RowIndex];
                tbnamafoto.Text = row.Cells["nama"].Value?.ToString();
                tbtelepon.Text = row.Cells["no_telepon"].Value?.ToString();
                tbemail.Text = row.Cells["email"].Value?.ToString();

                dgvfotografer.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgvfotografer.CurrentRow != null)
            {
                int id = (int)dgvfotografer.CurrentRow.Cells["id_fotografer"].Value;
                string nama = tbnamafoto.Text;
                string email = tbemail.Text;
                string no_telepon = tbtelepon.Text;

                fotograferController.Update(id, nama, email, no_telepon);
                cleartb();
                LoadTableFotografer();
            }
            else
            {
                MessageBox.Show("Tidak ada baris yang dipilih.");
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            string nama = tbnamafoto.Text;
            string email = tbemail.Text;
            string no_telepon = tbtelepon.Text;

            fotograferController.Add(nama, email, no_telepon);
            cleartb();
            dgvfotografer.ClearSelection();
            LoadTableFotografer();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (dgvfotografer.CurrentRow != null)
            {
                int id = (int)dgvfotografer.CurrentRow.Cells["id_fotografer"].Value;
                fotograferController.Delete(id);
                cleartb();
                dgvfotografer.ClearSelection();
                LoadTableFotografer();
            }
            else
            {
                MessageBox.Show("Tidak ada baris yang dipilih untuk dihapus.");
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleartb();
            dgvfotografer.ClearSelection();
        }

        private void ViewFotografer_Load(object sender, EventArgs e)
        {
            LoadTableFotografer();
        }
    }
}
