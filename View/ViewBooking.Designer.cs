namespace projectakhirsem2.View
{
    partial class ViewBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBooking));
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            tbtempat = new TextBox();
            cbpaket = new ComboBox();
            dtptglmain = new DateTimePicker();
            dtpwaktumulai = new DateTimePicker();
            dtpwaktuselesai = new DateTimePicker();
            dtptglbooking = new DateTimePicker();
            btsubmit = new Button();
            label11 = new Label();
            cbstatus = new ComboBox();
            label3 = new Label();
            tbcatatan = new TextBox();
            dgvbooking = new DataGridView();
            label4 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvbooking).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(433, 22);
            label1.Name = "label1";
            label1.Size = new Size(234, 40);
            label1.TabIndex = 0;
            label1.Text = "Booking Jadwal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(36, 133);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 4;
            label5.Text = "Pilih Paket";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(36, 172);
            label6.Name = "label6";
            label6.Size = new Size(129, 17);
            label6.TabIndex = 5;
            label6.Text = "Tanggal Pelaksanaan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F);
            label7.Location = new Point(36, 209);
            label7.Name = "label7";
            label7.Size = new Size(78, 17);
            label7.TabIndex = 6;
            label7.Text = "Waktu mulai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(36, 367);
            label2.Name = "label2";
            label2.Size = new Size(51, 17);
            label2.TabIndex = 7;
            label2.Text = "Tempat";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F);
            label8.Location = new Point(36, 96);
            label8.Name = "label8";
            label8.Size = new Size(105, 17);
            label8.TabIndex = 8;
            label8.Text = "Tanggal Booking";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(36, 248);
            label9.Name = "label9";
            label9.Size = new Size(87, 17);
            label9.TabIndex = 9;
            label9.Text = "Waktu Selesai";
            // 
            // tbtempat
            // 
            tbtempat.Location = new Point(203, 366);
            tbtempat.Multiline = true;
            tbtempat.Name = "tbtempat";
            tbtempat.Size = new Size(220, 41);
            tbtempat.TabIndex = 13;
            // 
            // cbpaket
            // 
            cbpaket.FormattingEnabled = true;
            cbpaket.Location = new Point(203, 129);
            cbpaket.Name = "cbpaket";
            cbpaket.Size = new Size(220, 23);
            cbpaket.TabIndex = 14;
            // 
            // dtptglmain
            // 
            dtptglmain.Format = DateTimePickerFormat.Custom;
            dtptglmain.Location = new Point(203, 167);
            dtptglmain.Name = "dtptglmain";
            dtptglmain.Size = new Size(109, 23);
            dtptglmain.TabIndex = 15;
            // 
            // dtpwaktumulai
            // 
            dtpwaktumulai.CalendarTrailingForeColor = SystemColors.HighlightText;
            dtpwaktumulai.CustomFormat = "HH:mm";
            dtpwaktumulai.Format = DateTimePickerFormat.Custom;
            dtpwaktumulai.Location = new Point(203, 205);
            dtpwaktumulai.Name = "dtpwaktumulai";
            dtpwaktumulai.ShowUpDown = true;
            dtpwaktumulai.Size = new Size(51, 23);
            dtpwaktumulai.TabIndex = 16;
            // 
            // dtpwaktuselesai
            // 
            dtpwaktuselesai.CustomFormat = "HH:mm";
            dtpwaktuselesai.Format = DateTimePickerFormat.Custom;
            dtpwaktuselesai.Location = new Point(203, 244);
            dtpwaktuselesai.Name = "dtpwaktuselesai";
            dtpwaktuselesai.RightToLeft = RightToLeft.No;
            dtpwaktuselesai.ShowUpDown = true;
            dtpwaktuselesai.Size = new Size(51, 23);
            dtpwaktuselesai.TabIndex = 17;
            // 
            // dtptglbooking
            // 
            dtptglbooking.CustomFormat = "";
            dtptglbooking.Enabled = false;
            dtptglbooking.Format = DateTimePickerFormat.Custom;
            dtptglbooking.Location = new Point(203, 92);
            dtptglbooking.Name = "dtptglbooking";
            dtptglbooking.Size = new Size(109, 23);
            dtptglbooking.TabIndex = 19;
            // 
            // btsubmit
            // 
            btsubmit.Location = new Point(312, 492);
            btsubmit.Name = "btsubmit";
            btsubmit.Size = new Size(96, 33);
            btsubmit.TabIndex = 20;
            btsubmit.Text = "Submit";
            btsubmit.UseVisualStyleBackColor = true;
            btsubmit.Click += btsubmit_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(36, 330);
            label11.Name = "label11";
            label11.Size = new Size(94, 17);
            label11.TabIndex = 23;
            label11.Text = "Status Booking";
            // 
            // cbstatus
            // 
            cbstatus.Enabled = false;
            cbstatus.FormattingEnabled = true;
            cbstatus.Items.AddRange(new object[] { "Pending", "Disetujui", "Dibatalkan", "Selesai" });
            cbstatus.Location = new Point(203, 329);
            cbstatus.Name = "cbstatus";
            cbstatus.Size = new Size(220, 23);
            cbstatus.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(36, 426);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 26;
            label3.Text = "Catatan";
            // 
            // tbcatatan
            // 
            tbcatatan.Location = new Point(203, 426);
            tbcatatan.Multiline = true;
            tbcatatan.Name = "tbcatatan";
            tbcatatan.Size = new Size(220, 40);
            tbcatatan.TabIndex = 27;
            // 
            // dgvbooking
            // 
            dgvbooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvbooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbooking.Location = new Point(455, 121);
            dgvbooking.Name = "dgvbooking";
            dgvbooking.ReadOnly = true;
            dgvbooking.Size = new Size(665, 279);
            dgvbooking.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(455, 92);
            label4.Name = "label4";
            label4.Size = new Size(158, 17);
            label4.TabIndex = 28;
            label4.Text = "Informasi Booking Anda";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(36, 275);
            label10.Name = "label10";
            label10.Size = new Size(404, 45);
            label10.TabIndex = 29;
            label10.Text = resources.GetString("label10.Text");
            // 
            // ViewBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 540);
            Controls.Add(label10);
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
            Name = "ViewBooking";
            Text = "ViewBooking";
            Load += ViewBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvbooking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label2;
        private Label label8;
        private Label label9;
        private TextBox tbtempat;
        private ComboBox cbpaket;
        private DateTimePicker dtptglmain;
        private DateTimePicker dtpwaktumulai;
        private DateTimePicker dtpwaktuselesai;
        private DateTimePicker dtptglbooking;
        private Button btsubmit;
        private Label label11;
        private ComboBox cbstatus;
        private Label label3;
        private TextBox tbcatatan;
        private DataGridView dgvbooking;
        private Label label4;
        private Label label10;
    }
}