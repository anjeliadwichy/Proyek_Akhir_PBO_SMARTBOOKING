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
using projectakhirsem2.Model;

namespace projectakhirsem2.View
{
    public partial class ViewBookingAdmin : Form
    {
        IBookingController bookingController = new BookingController();
        IStatusBookingController statusBookingController = new StatusBookingController();
        IPaketJasaController paketJasaController = new PaketJasaController();
        IPembayaranController pembayaranController = new PembayaranController();
        IMetodePembayaranController metodePembayaranController = new MetodePembayaranController();
        IPenggunaController penggunaController = new PenggunaController();
        IFotograferController fotograferController = new FotograferController();
        public ViewBookingAdmin()
        {
            InitializeComponent();
        }

        protected void LoadBookingData()
        {
            var dataBooking = bookingController.GetAll() ?? new List<ModelBooking>();
            var dataPembayaran = pembayaranController.GetAllPembayaranAdmin() ?? new List<ModelPembayaran>();
            var dataMetode = metodePembayaranController.GetAll() ?? new List<ModelMetodePembayaran>();
            var dataFotografer = fotograferController.GetAll() ?? new List<ModelFotografer>();
            var dataPaket = paketJasaController.GetAll() ?? new List<ModelPaketJasa>();
            var dataPengguna = penggunaController.GetAll() ?? new List<ModelPengguna>();

            var result = dataBooking.Select(b =>
            {
                var pembayaran = dataPembayaran.FirstOrDefault(p => p.id_booking == b.id_booking);
                var metode = pembayaran != null ? dataMetode.FirstOrDefault(m => m.id_metode_pembayaran == pembayaran.id_metode_pembayaran) : null;
                var fotografer = dataFotografer.FirstOrDefault(f => f.id_fotografer == b.id_fotografer);
                var paket = dataPaket.FirstOrDefault(p => p.id_paket_jasa == b.id_paket_jasa);
                var pengguna = dataPengguna.FirstOrDefault(u => u.id_pengguna == b.id_pengguna);

                return new
                {
                    b.id_booking,
                    b.tanggal_booking,
                    b.tanggal_pelaksanaan,
                    b.waktu_mulai,
                    b.waktu_selesai,
                    b.tempat,
                    b.catatan,
                    b.id_pengguna,
                    b.id_status_booking,
                    b.id_paket_jasa,
                    b.id_fotografer,
                    NamaFotografer = fotografer?.nama ?? "Belum Ditentukan",
                    NamaPaket = paket?.nama_paket ?? "Tidak Diketahui",
                    NamaPengguna = pengguna?.nama ?? "Tidak Diketahui",
                    Status = b.id_status_booking == 1 ? "Pending" :
                             b.id_status_booking == 2 ? "Disetujui" :
                             b.id_status_booking == 3 ? "Dibatalkan" :
                             b.id_status_booking == 4 ? "Selesai" : "Unknown",
                    MetodePembayaran = metode?.metode_pembayaran ?? "Belum Bayar"
                };
            }).ToList();

            dgvbooking.DataSource = result;

            // Header kolom
            dgvbooking.Columns["id_booking"].HeaderText = "ID Booking";
            dgvbooking.Columns["tanggal_booking"].HeaderText = "Tanggal Booking";
            dgvbooking.Columns["tanggal_pelaksanaan"].HeaderText = "Tanggal Pelaksanaan";
            dgvbooking.Columns["waktu_mulai"].HeaderText = "Waktu Mulai";
            dgvbooking.Columns["waktu_selesai"].HeaderText = "Waktu Selesai";
            dgvbooking.Columns["tempat"].HeaderText = "Tempat";
            dgvbooking.Columns["catatan"].HeaderText = "Catatan";
            dgvbooking.Columns["NamaPengguna"].HeaderText = "Nama Pengguna";
            dgvbooking.Columns["NamaPaket"].HeaderText = "Nama Paket";
            dgvbooking.Columns["NamaFotografer"].HeaderText = "Nama Fotografer";
            dgvbooking.Columns["Status"].HeaderText = "Status Booking";
            dgvbooking.Columns["MetodePembayaran"].HeaderText = "Metode Pembayaran";

            // Sembunyikan kolom ID
            dgvbooking.Columns["id_status_booking"].Visible = false;
            dgvbooking.Columns["id_paket_jasa"].Visible = false;
            dgvbooking.Columns["id_fotografer"].Visible = false;
            dgvbooking.Columns["id_pengguna"].Visible = false;
        }

        public void ClearInputFields()
        {
            tbid.Clear();
            dtptglbooking.Value = DateTime.Now;
            dtptglmain.Value = DateTime.Now;
            dtpwaktumulai.Value = DateTime.Today + TimeSpan.FromHours(0);
            dtpwaktuselesai.Value = DateTime.Today + TimeSpan.FromHours(0);
            tbtempat.Clear();
            tbcatatan.Clear();
            cbpaket.SelectedIndex = 0;
            cbstatus.SelectedIndex = 0;
            cbfotografer.SelectedIndex = 0;
            cbstatus.SelectedIndex = 0;
            dgvbooking.ClearSelection();
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

        protected void LoadComboBoxFotografer()
        {
            var fotografer = new FotograferController();
            var listFotografer = fotografer.GetAll();

            if (listFotografer != null && listFotografer.Count > 0)
            {
                cbfotografer.DataSource = listFotografer;
                cbfotografer.DisplayMember = "nama";
                cbfotografer.ValueMember = "id_fotografer";
            }
        }

        private void ViewBookingAdmin_Load(object sender, EventArgs e)
        {
            LoadComboBoxPaket();
            LoadComboBoxStatus();
            LoadComboBoxFotografer();
            LoadBookingData();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dgvbooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvbooking.Rows[e.RowIndex];
                tbid.Text = row.Cells["id_booking"].Value?.ToString();
                cbpaket.SelectedValue = row.Cells["id_paket_jasa"].Value;
                //cbpaket.Text = row.Cells["id_paket_jasa"].Value?.ToString();
                dtptglbooking.Value = Convert.ToDateTime(row.Cells["tanggal_booking"].Value);
                dtptglmain.Value = Convert.ToDateTime(row.Cells["tanggal_pelaksanaan"].Value);
                if (TimeSpan.TryParse(row.Cells["waktu_mulai"].Value?.ToString(), out TimeSpan waktuMulai))
                {
                    dtpwaktumulai.Value = DateTime.Today + waktuMulai;
                }

                if (TimeSpan.TryParse(row.Cells["waktu_selesai"].Value?.ToString(), out TimeSpan waktuSelesai))
                {
                    dtpwaktuselesai.Value = DateTime.Today + waktuSelesai;
                }

                var idStatus = row.Cells["id_status_booking"].Value;
                if (idStatus != DBNull.Value && idStatus != null)
                {
                    cbstatus.SelectedValue = idStatus;
                }
                else
                {
                    cbstatus.SelectedIndex = 0;
                }

                var idFotografer = row.Cells["id_fotografer"].Value;
                if (idFotografer != DBNull.Value && idFotografer != null)
                {
                    cbfotografer.SelectedValue = idFotografer;
                }
                else
                {
                    cbfotografer.SelectedIndex = 0;
                }

                tbtempat.Text = row.Cells["tempat"].Value?.ToString();
                tbcatatan.Text = row.Cells["catatan"].Value?.ToString();
                dgvbooking.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbid.Text))
            {
                var idBooking = int.Parse(tbid.Text);
                if (cbstatus.SelectedValue == null)
                {
                    MessageBox.Show("Silakan pilih status booking.");
                    return;
                }
                int idStatus = Convert.ToInt32(cbstatus.SelectedValue);
                if (cbfotografer.SelectedValue == null)
                {
                    MessageBox.Show("Silakan pilih fotografer.");
                    return;
                }
                int idFotografer = Convert.ToInt32(cbfotografer.SelectedValue);

                if (idStatus == 1)
                {
                    bookingController.UpdateStatusOnly(idBooking, idStatus);
                    MessageBox.Show("Status booking diperbarui menjadi Pending. Tidak bisa menambahkan fotografer.");
                }
                else if (idStatus == 2)
                {
                    if (idFotografer == -1)
                    {
                        MessageBox.Show("Silakan pilih fotografer terlebih dahulu.");
                        return;
                    }

                    bookingController.UpdateStatusInputFotografer(idBooking, idStatus, idFotografer);
                }
                else
                {
                    bookingController.UpdateStatusOnly(idBooking, idStatus);
                }

                LoadBookingData();
                ClearInputFields();
            }
        }

        private void cbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbstatus.SelectedValue is int selectedStatus)
            {
                cbfotografer.Enabled = (selectedStatus == 2);
            }
        }
    }
}
