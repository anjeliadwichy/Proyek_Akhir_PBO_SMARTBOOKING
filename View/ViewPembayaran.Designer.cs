namespace projectakhirsem2.View
{
    partial class ViewPembayaran
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbidbooking = new TextBox();
            tbtotal = new TextBox();
            cbmetode = new ComboBox();
            label5 = new Label();
            dtptglpembayaran = new DateTimePicker();
            btsubmit = new Button();
            dgvpembayaran = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvpembayaran).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 104);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Booking";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 147);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 1;
            label2.Text = "Tanggal Pembayaran";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 188);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Total Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 232);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 3;
            label4.Text = "Metode Pembayaran";
            // 
            // tbidbooking
            // 
            tbidbooking.Location = new Point(148, 101);
            tbidbooking.Name = "tbidbooking";
            tbidbooking.ReadOnly = true;
            tbidbooking.Size = new Size(100, 23);
            tbidbooking.TabIndex = 4;
            // 
            // tbtotal
            // 
            tbtotal.Location = new Point(148, 185);
            tbtotal.Name = "tbtotal";
            tbtotal.ReadOnly = true;
            tbtotal.Size = new Size(182, 23);
            tbtotal.TabIndex = 6;
            // 
            // cbmetode
            // 
            cbmetode.FormattingEnabled = true;
            cbmetode.Location = new Point(148, 229);
            cbmetode.Name = "cbmetode";
            cbmetode.Size = new Size(182, 23);
            cbmetode.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(454, 25);
            label5.Name = "label5";
            label5.Size = new Size(304, 40);
            label5.TabIndex = 8;
            label5.Text = "Metode Pembayaran";
            // 
            // dtptglpembayaran
            // 
            dtptglpembayaran.Enabled = false;
            dtptglpembayaran.Format = DateTimePickerFormat.Short;
            dtptglpembayaran.Location = new Point(148, 141);
            dtptglpembayaran.Name = "dtptglpembayaran";
            dtptglpembayaran.Size = new Size(100, 23);
            dtptglpembayaran.TabIndex = 9;
            // 
            // btsubmit
            // 
            btsubmit.Location = new Point(242, 282);
            btsubmit.Name = "btsubmit";
            btsubmit.Size = new Size(87, 33);
            btsubmit.TabIndex = 10;
            btsubmit.Text = "Submit";
            btsubmit.UseVisualStyleBackColor = true;
            btsubmit.Click += btsubmit_Click;
            // 
            // dgvpembayaran
            // 
            dgvpembayaran.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvpembayaran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpembayaran.Location = new Point(357, 101);
            dgvpembayaran.Name = "dgvpembayaran";
            dgvpembayaran.Size = new Size(778, 214);
            dgvpembayaran.TabIndex = 11;
            dgvpembayaran.CellClick += dgvpembayaran_CellClick;
            // 
            // ViewPembayaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 450);
            Controls.Add(dgvpembayaran);
            Controls.Add(btsubmit);
            Controls.Add(dtptglpembayaran);
            Controls.Add(label5);
            Controls.Add(cbmetode);
            Controls.Add(tbtotal);
            Controls.Add(tbidbooking);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewPembayaran";
            Text = "ViewPembayaran";
            Load += ViewPembayaran_Load;
            ((System.ComponentModel.ISupportInitialize)dgvpembayaran).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbidbooking;
        private TextBox tbtotal;
        private ComboBox cbmetode;
        private Label label5;
        private DateTimePicker dtptglpembayaran;
        private Button btsubmit;
        private DataGridView dgvpembayaran;
    }
}