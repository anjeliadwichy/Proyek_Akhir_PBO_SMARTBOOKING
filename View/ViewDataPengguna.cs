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
    public partial class ViewDataPengguna : Form
    {
        public ViewDataPengguna()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewDataPengguna_Load(object sender, EventArgs e)
        {
            IPenggunaController controller = new PenggunaController();
            var listPengguna = controller.GetAll();

            var dataGrid = listPengguna.Select(p => new
            {
                p.id_pengguna,
                p.nama,
                p.email,
                p.no_telepon
            }).ToList();

            dataGridView1.DataSource = dataGrid;

            dataGridView1.Columns["id_pengguna"].HeaderText = "ID Pengguna";
            dataGridView1.Columns["nama"].HeaderText = "Nama Pengguna";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["no_telepon"].HeaderText = "No Telepon";
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }
    }
}
