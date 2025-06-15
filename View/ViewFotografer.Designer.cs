namespace projectakhirsem2.View
{
    partial class ViewFotografer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFotografer));
            dgvfotografer = new DataGridView();
            btnhapus = new Button();
            btnclear = new Button();
            btnsimpan = new Button();
            btnupdate = new Button();
            tbemail = new TextBox();
            tbnamafoto = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            tbtelepon = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvfotografer).BeginInit();
            SuspendLayout();
            // 
            // dgvfotografer
            // 
            dgvfotografer.AllowUserToOrderColumns = true;
            dgvfotografer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvfotografer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvfotografer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvfotografer.Location = new Point(496, 99);
            dgvfotografer.Name = "dgvfotografer";
            dgvfotografer.Size = new Size(592, 228);
            dgvfotografer.TabIndex = 31;
            dgvfotografer.CellClick += dgvfotografer_CellClick;
            // 
            // btnhapus
            // 
            btnhapus.Location = new Point(169, 295);
            btnhapus.Name = "btnhapus";
            btnhapus.Size = new Size(87, 32);
            btnhapus.TabIndex = 30;
            btnhapus.Text = "Hapus";
            btnhapus.UseVisualStyleBackColor = true;
            btnhapus.Click += btnhapus_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(338, 295);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(87, 32);
            btnclear.TabIndex = 29;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnsimpan
            // 
            btnsimpan.Location = new Point(338, 232);
            btnsimpan.Name = "btnsimpan";
            btnsimpan.Size = new Size(87, 32);
            btnsimpan.TabIndex = 28;
            btnsimpan.Text = "Simpan";
            btnsimpan.UseVisualStyleBackColor = true;
            btnsimpan.Click += btnsimpan_Click;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(169, 232);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(87, 32);
            btnupdate.TabIndex = 27;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(169, 184);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(256, 23);
            tbemail.TabIndex = 24;
            // 
            // tbnamafoto
            // 
            tbnamafoto.Location = new Point(169, 99);
            tbnamafoto.Name = "tbnamafoto";
            tbnamafoto.Size = new Size(256, 23);
            tbnamafoto.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 187);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 22;
            label6.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 143);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 20;
            label4.Text = "No. Telepon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 102);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 19;
            label3.Text = "Nama Fotografer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(447, 21);
            label1.Name = "label1";
            label1.Size = new Size(164, 40);
            label1.TabIndex = 18;
            label1.Text = "Fotografer";
            // 
            // tbtelepon
            // 
            tbtelepon.Location = new Point(169, 140);
            tbtelepon.Name = "tbtelepon";
            tbtelepon.Size = new Size(256, 23);
            tbtelepon.TabIndex = 32;
            // 
            // ViewFotografer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 364);
            Controls.Add(tbtelepon);
            Controls.Add(dgvfotografer);
            Controls.Add(btnhapus);
            Controls.Add(btnclear);
            Controls.Add(btnsimpan);
            Controls.Add(btnupdate);
            Controls.Add(tbemail);
            Controls.Add(tbnamafoto);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewFotografer";
            Text = "ViewFotografer";
            Load += ViewFotografer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvfotografer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvfotografer;
        private Button btnhapus;
        private Button btnclear;
        private Button btnsimpan;
        private Button btnupdate;
        private TextBox tbemail;
        private TextBox tbnamafoto;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox tbtelepon;
    }
}