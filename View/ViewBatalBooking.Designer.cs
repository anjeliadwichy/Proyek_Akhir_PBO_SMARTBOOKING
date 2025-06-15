namespace projectakhirsem2.View
{
    partial class ViewBatalBooking
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
            dgvbatalkan = new DataGridView();
            tbidbooking = new TextBox();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvbatalkan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(463, 25);
            label1.Name = "label1";
            label1.Size = new Size(260, 40);
            label1.TabIndex = 0;
            label1.Text = "Batalkan Booking";
            // 
            // dgvbatalkan
            // 
            dgvbatalkan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvbatalkan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvbatalkan.Location = new Point(243, 100);
            dgvbatalkan.Name = "dgvbatalkan";
            dgvbatalkan.Size = new Size(869, 185);
            dgvbatalkan.TabIndex = 1;
            dgvbatalkan.CellClick += dgvbatalkan_CellClick;
            // 
            // tbidbooking
            // 
            tbidbooking.Location = new Point(107, 100);
            tbidbooking.Name = "tbidbooking";
            tbidbooking.ReadOnly = true;
            tbidbooking.Size = new Size(100, 23);
            tbidbooking.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 101);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 3;
            label2.Text = "ID Booking";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(107, 150);
            button1.Name = "button1";
            button1.Size = new Size(100, 38);
            button1.TabIndex = 4;
            button1.Text = "Batalkan";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewBatalBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(tbidbooking);
            Controls.Add(dgvbatalkan);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBatalBooking";
            Text = "ViewBatalBooking";
            Load += ViewBatalBooking_Load;
            ((System.ComponentModel.ISupportInitialize)dgvbatalkan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvbatalkan;
        private TextBox tbidbooking;
        private Label label2;
        private Button button1;
    }
}