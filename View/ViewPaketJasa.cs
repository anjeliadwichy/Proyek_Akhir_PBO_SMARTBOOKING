using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projectakhirsem2.Model;
using projectakhirsem2.Controller;


namespace projectakhirsem2.View
{
    public partial class ViewPaketJasa : Form
    {
        private PaketJasaController paketJasaController = new();
        private JenisLayananController jenisLayananController = new();
        public ViewPaketJasa()
        {
            InitializeComponent();
        }

        private void LoadComboBoxJenisLayanan()
        {
            var listJenis = jenisLayananController.GetAll();
            if (listJenis != null && listJenis.Count > 0)
            {
                cbjenislayanan.DataSource = listJenis;
                cbjenislayanan.DisplayMember = "nama_jenis";
                cbjenislayanan.ValueMember = "id_jenis_layanan";
            }
        }

        private void LoadTablePaketJasa()
        {
            var paketList = paketJasaController.GetAll();
            var layananList = jenisLayananController.GetAll();

            var viewList = paketList.Select(p => new
            {
                p.id_paket_jasa,
                p.nama_paket,
                p.harga,
                p.deskripsi,
                p.id_jenis_layanan,
                JenisLayanan = layananList.FirstOrDefault(l => l.id_jenis_layanan == p.id_jenis_layanan)?.nama_jenis ?? "-"
            }).ToList();    

            dgvpaketjasa.DataSource = null;
            dgvpaketjasa.DataSource = viewList;

            dgvpaketjasa.Columns["id_paket_jasa"].HeaderText = "ID Paket Jasa";
            dgvpaketjasa.Columns["nama_paket"].HeaderText = "Nama Paket Jasa";
            dgvpaketjasa.Columns["harga"].HeaderText = "Harga";
            dgvpaketjasa.Columns["deskripsi"].HeaderText = "Deskripsi";
            dgvpaketjasa.Columns["JenisLayanan"].HeaderText = "Jenis Layanan";

            dgvpaketjasa.Columns["id_jenis_layanan"].Visible = false;

        }

        private void cleartb()
        {
            tbnamapaket.Clear();
            tbharga.Clear();
            tbdeskripsi.Clear();
            cbjenislayanan.SelectedIndex = -1;
            dgvpaketjasa.ClearSelection();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (dgvpaketjasa.SelectedRows.Count > 0)
            {
                int id = (int)dgvpaketjasa.SelectedRows[0].Cells["id_paket_jasa"].Value;
                paketJasaController.Delete(id);
                cleartb();
                dgvpaketjasa.ClearSelection();
                LoadTablePaketJasa();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dgvpaketjasa.CurrentRow != null)
            {
                if (cbjenislayanan.SelectedValue == null || !int.TryParse(cbjenislayanan.SelectedValue.ToString(), out int idJenis))
                {
                    MessageBox.Show("Pilih jenis layanan terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = (int)dgvpaketjasa.CurrentRow.Cells["id_paket_jasa"].Value;
                string nama = tbnamapaket.Text;
                int harga = int.Parse(tbharga.Text);
                string deskripsi = tbdeskripsi.Text;

                paketJasaController.Update(id, nama, idJenis, harga, deskripsi);
                //MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cleartb();
                LoadTablePaketJasa();
            }
            else
            {
                MessageBox.Show("Tidak ada baris yang dipilih.");
            }
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (cbjenislayanan.SelectedValue == null || !int.TryParse(cbjenislayanan.SelectedValue.ToString(), out int idJenis))
            {
                MessageBox.Show("Pilih jenis layanan terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nama = tbnamapaket.Text;
            int harga = int.Parse(tbharga.Text);
            string deskripsi = tbdeskripsi.Text;

            paketJasaController.Add(nama, idJenis, harga, deskripsi);
            cleartb();
            dgvpaketjasa.ClearSelection();
            LoadTablePaketJasa();
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            cleartb();
        }

        private void cbjenislayanan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewPaketJasa_Load(object sender, EventArgs e)
        {
            LoadComboBoxJenisLayanan();
            LoadTablePaketJasa();
        }

        private void dgvpaketjasa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvpaketjasa.Rows[e.RowIndex];
                tbnamapaket.Text = row.Cells["nama_paket"].Value?.ToString();
                tbharga.Text = row.Cells["harga"].Value?.ToString();
                tbdeskripsi.Text = row.Cells["deskripsi"].Value?.ToString();
                cbjenislayanan.SelectedValue = row.Cells["id_jenis_layanan"].Value;

                dgvpaketjasa.Rows[e.RowIndex].Selected = true;
                cbjenislayanan.SelectedValue?.ToString();
            }
        }
    }
}
