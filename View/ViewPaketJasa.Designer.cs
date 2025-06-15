namespace projectakhirsem2.View
{
    partial class ViewPaketJasa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPaketJasa));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbnamapaket = new TextBox();
            tbharga = new TextBox();
            tbdeskripsi = new TextBox();
            cbjenislayanan = new ComboBox();
            btnupdate = new Button();
            btnsimpan = new Button();
            btnkembali = new Button();
            btnhapus = new Button();
            dgvpaketjasa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvpaketjasa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(499, 23);
            label1.Name = "label1";
            label1.Size = new Size(159, 40);
            label1.TabIndex = 0;
            label1.Text = "Paket Jasa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 99);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Nama Paket";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 140);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Jenis Layanan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 227);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Deskripsi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 184);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 5;
            label6.Text = "Harga";
            // 
            // tbnamapaket
            // 
            tbnamapaket.Location = new Point(120, 96);
            tbnamapaket.Name = "tbnamapaket";
            tbnamapaket.Size = new Size(248, 23);
            tbnamapaket.TabIndex = 7;
            // 
            // tbharga
            // 
            tbharga.Location = new Point(120, 181);
            tbharga.Name = "tbharga";
            tbharga.Size = new Size(248, 23);
            tbharga.TabIndex = 9;
            // 
            // tbdeskripsi
            // 
            tbdeskripsi.Location = new Point(120, 224);
            tbdeskripsi.Multiline = true;
            tbdeskripsi.Name = "tbdeskripsi";
            tbdeskripsi.Size = new Size(248, 87);
            tbdeskripsi.TabIndex = 10;
            // 
            // cbjenislayanan
            // 
            cbjenislayanan.FormattingEnabled = true;
            cbjenislayanan.Items.AddRange(new object[] { "Fotografi", "Videografi", "Desain", "Fotografi + Videografi" });
            cbjenislayanan.Location = new Point(120, 137);
            cbjenislayanan.Name = "cbjenislayanan";
            cbjenislayanan.Size = new Size(248, 23);
            cbjenislayanan.TabIndex = 11;
            cbjenislayanan.SelectedIndexChanged += cbjenislayanan_SelectedIndexChanged;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(205, 328);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(79, 32);
            btnupdate.TabIndex = 13;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnsimpan
            // 
            btnsimpan.Location = new Point(289, 328);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(79, 32);
            btnsimpan.TabIndex = 14;
            btnsimpan.Text = "Simpan";
            btnsimpan.UseVisualStyleBackColor = true;
            btnsimpan.Click += btnsimpan_Click;
            // 
            // btnkembali
            // 
            btnkembali.Location = new Point(205, 369);
            btnkembali.Name = "btnkembali";
            btnkembali.Size = new Size(79, 32);
            btnkembali.TabIndex = 15;
            btnkembali.Text = "Clear";
            btnkembali.UseVisualStyleBackColor = true;
            btnkembali.Click += btnkembali_Click;
            // 
            // btnhapus
            // 
            btnhapus.Location = new Point(119, 328);
            btnhapus.Name = "btnhapus";
            btnhapus.Size = new Size(79, 32);
            btnhapus.TabIndex = 16;
            btnhapus.Text = "Hapus";
            btnhapus.UseVisualStyleBackColor = true;
            btnhapus.Click += btnhapus_Click;
            // 
            // dgvpaketjasa
            // 
            dgvpaketjasa.AllowUserToOrderColumns = true;
            dgvpaketjasa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvpaketjasa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvpaketjasa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpaketjasa.Location = new Point(398, 96);
            dgvpaketjasa.Name = "dgvpaketjasa";
            dgvpaketjasa.Size = new Size(732, 305);
            dgvpaketjasa.TabIndex = 17;
            dgvpaketjasa.CellClick += dgvpaketjasa_CellClick;
            // 
            // ViewPaketJasa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 437);
            Controls.Add(dgvpaketjasa);
            Controls.Add(btnhapus);
            Controls.Add(btnkembali);
            Controls.Add(btnsimpan);
            Controls.Add(btnupdate);
            Controls.Add(cbjenislayanan);
            Controls.Add(tbdeskripsi);
            Controls.Add(tbharga);
            Controls.Add(tbnamapaket);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewPaketJasa";
            Text = "Form1";
            Load += ViewPaketJasa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvpaketjasa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbnamapaket;
        private TextBox tbharga;
        private TextBox tbdeskripsi;
        private ComboBox cbjenislayanan;
        private Button btnupdate;
        private Button btnsimpan;
        private Button btnkembali;
        private Button btnhapus;
        private DataGridView dgvpaketjasa;
    }
}