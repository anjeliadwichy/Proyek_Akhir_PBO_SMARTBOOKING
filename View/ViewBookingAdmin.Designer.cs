namespace projectakhirsem2.View
{
    partial class ViewBookingAdmin
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
            label1 = new Label();
            tbcatatan = new TextBox();
            label3 = new Label();
            cbstatus = new ComboBox();
            label11 = new Label();
            btsubmit = new Button();
            dtptglbooking = new DateTimePicker();
            dgvbooking = new DataGridView();
            dtpwaktuselesai = new DateTimePicker();
            dtpwaktumulai = new DateTimePicker();
            dtptglmain = new DateTimePicker();
            cbpaket = new ComboBox();
            tbtempat = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbid = new TextBox();
            label13 = new Label();
            cbfotografer = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvbooking).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 22);
            label1.Name = "label1";
            label1.Size = new Size(480, 37);
            label1.TabIndex = 0;
            label1.Text = "Ubah Status dan Tambah Fotografer";
            // 
            // tbcatatan
            // 
            tbcatatan.Enabled = false;
            tbcatatan.Location = new Point(196, 489);
            tbcatatan.Multiline = true;
            tbcatatan.Name = "tbcatatan";
            tbcatatan.ReadOnly = true;
            tbcatatan.Size = new Size(220, 48);
            tbcatatan.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(29, 489);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 47;
            label3.Text = "Catatan";
            // 
            // cbstatus
            // 
            cbstatus.FormattingEnabled = true;
            cbstatus.Items.AddRange(new object[] { "Pending", "Disetujui", "Dibatalkan", "Selesai" });
            cbstatus.Location = new Point(196, 337);
            cbstatus.Name = "cbstatus";
            cbstatus.Size = new Size(220, 23);
            cbstatus.TabIndex = 45;
            cbstatus.SelectedIndexChanged += cbstatus_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(29, 338);
            label11.Name = "label11";
            label11.Size = new Size(94, 17);
            label11.TabIndex = 44;
            label11.Text = "Status Booking";
            // 
            // btsubmit
            // 
            btsubmit.Location = new Point(320, 556);
            btsubmit.Name = "btsubmit";
            btsubmit.Size = new Size(96, 33);
            btsubmit.TabIndex = 41;
            btsubmit.Text = "Update";
            btsubmit.UseVisualStyleBackColor = true;
            btsubmit.Click += btsubmit_Click;
            // 
            // dtptglbooking
            // 
            dtptglbooking.CustomFormat = "";
            dtptglbooking.Enabled = false;
            dtptglbooking.Format = DateTimePickerFormat.Custom;
            dtptglbooking.Location = new Point(196, 129);
            dtptglbooking.Name = "dtptglbooking";
            dtptglbooking.Size = new Size(109, 23);
            dtptglbooking.TabIndex = 40;
            // 
            // dgvbooking
            // 
            dgvbooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbooking.Location = new Point(446, 89);
            dgvbooking.Name = "dgvbooking";
            dgvbooking.ReadOnly = true;
            dgvbooking.Size = new Size(702, 353);
            dgvbooking.TabIndex = 39;
            dgvbooking.CellClick += dgvbooking_CellClick;
            // 
            // dtpwaktuselesai
            // 
            dtpwaktuselesai.CustomFormat = "HH:mm";
            dtpwaktuselesai.Enabled = false;
            dtpwaktuselesai.Format = DateTimePickerFormat.Custom;
            dtpwaktuselesai.Location = new Point(196, 293);
            dtpwaktuselesai.Name = "dtpwaktuselesai";
            dtpwaktuselesai.RightToLeft = RightToLeft.No;
            dtpwaktuselesai.ShowUpDown = true;
            dtpwaktuselesai.Size = new Size(51, 23);
            dtpwaktuselesai.TabIndex = 38;
            // 
            // dtpwaktumulai
            // 
            dtpwaktumulai.CalendarTrailingForeColor = SystemColors.HighlightText;
            dtpwaktumulai.CustomFormat = "HH:mm";
            dtpwaktumulai.Enabled = false;
            dtpwaktumulai.Format = DateTimePickerFormat.Custom;
            dtpwaktumulai.Location = new Point(196, 251);
            dtpwaktumulai.Name = "dtpwaktumulai";
            dtpwaktumulai.ShowUpDown = true;
            dtpwaktumulai.Size = new Size(51, 23);
            dtpwaktumulai.TabIndex = 37;
            // 
            // dtptglmain
            // 
            dtptglmain.Enabled = false;
            dtptglmain.Format = DateTimePickerFormat.Custom;
            dtptglmain.Location = new Point(196, 210);
            dtptglmain.Name = "dtptglmain";
            dtptglmain.Size = new Size(109, 23);
            dtptglmain.TabIndex = 36;
            // 
            // cbpaket
            // 
            cbpaket.Enabled = false;
            cbpaket.FormattingEnabled = true;
            cbpaket.Location = new Point(196, 169);
            cbpaket.Name = "cbpaket";
            cbpaket.Size = new Size(220, 23);
            cbpaket.TabIndex = 35;
            // 
            // tbtempat
            // 
            tbtempat.Enabled = false;
            tbtempat.Location = new Point(196, 424);
            tbtempat.Multiline = true;
            tbtempat.Name = "tbtempat";
            tbtempat.ReadOnly = true;
            tbtempat.Size = new Size(220, 46);
            tbtempat.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(29, 297);
            label9.Name = "label9";
            label9.Size = new Size(87, 17);
            label9.TabIndex = 33;
            label9.Text = "Waktu Selesai";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(29, 133);
            label8.Name = "label8";
            label8.Size = new Size(105, 17);
            label8.TabIndex = 32;
            label8.Text = "Tanggal Booking";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(29, 425);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 31;
            label2.Text = "Tempat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(29, 255);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 30;
            label7.Text = "Waktu mulai";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(29, 214);
            label6.Name = "label6";
            label6.Size = new Size(129, 17);
            label6.TabIndex = 29;
            label6.Text = "Tanggal Pelaksanaan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(29, 173);
            label5.Name = "label5";
            label5.Size = new Size(39, 17);
            label5.TabIndex = 28;
            label5.Text = "Paket";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(29, 90);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 49;
            label4.Text = "Id Booking";
            // 
            // tbid
            // 
            tbid.Location = new Point(196, 89);
            tbid.Name = "tbid";
            tbid.ReadOnly = true;
            tbid.Size = new Size(109, 23);
            tbid.TabIndex = 50;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F);
            label13.Location = new Point(29, 380);
            label13.Name = "label13";
            label13.Size = new Size(97, 17);
            label13.TabIndex = 51;
            label13.Text = "Pilih Fotografer";
            label13.Click += label13_Click;
            // 
            // cbfotografer
            // 
            cbfotografer.Enabled = false;
            cbfotografer.FormattingEnabled = true;
            cbfotografer.Location = new Point(196, 379);
            cbfotografer.Name = "cbfotografer";
            cbfotografer.Size = new Size(220, 23);
            cbfotografer.TabIndex = 52;
            // 
            // ViewBookingAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 616);
            Controls.Add(cbfotografer);
            Controls.Add(label13);
            Controls.Add(tbid);
            Controls.Add(label4);
            Controls.Add(tbcatatan);
            Controls.Add(label3);
            Controls.Add(cbstatus);
            Controls.Add(label11);
            Controls.Add(btsubmit);
            Controls.Add(dtptglbooking);
            Controls.Add(dgvbooking);
            Controls.Add(dtpwaktuselesai);
            Controls.Add(dtpwaktumulai);
            Controls.Add(dtptglmain);
            Controls.Add(cbpaket);
            Controls.Add(tbtempat);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBookingAdmin";
            RightToLeft = RightToLeft.Yes;
            Text = "ViewBookingAdmin";
            Load += ViewBookingAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvbooking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbcatatan;
        private Label label3;
        private ComboBox cbstatus;
        private Label label11;
        private Button btsubmit;
        private DateTimePicker dtptglbooking;
        private DataGridView dgvbooking;
        private DateTimePicker dtpwaktuselesai;
        private DateTimePicker dtpwaktumulai;
        private DateTimePicker dtptglmain;
        private ComboBox cbpaket;
        private TextBox tbtempat;
        private Label label9;
        private Label label8;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tbid;
        private Label label13;
        private ComboBox cbfotografer;
    }
}