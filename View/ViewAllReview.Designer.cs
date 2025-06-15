namespace projectakhirsem2.View
{
    partial class ViewAllReview
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
            dgvallreview = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvallreview).BeginInit();
            SuspendLayout();
            // 
            // dgvallreview
            // 
            dgvallreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvallreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvallreview.Location = new Point(143, 87);
            dgvallreview.Name = "dgvallreview";
            dgvallreview.ReadOnly = true;
            dgvallreview.Size = new Size(881, 313);
            dgvallreview.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(438, 21);
            label1.Name = "label1";
            label1.Size = new Size(336, 40);
            label1.TabIndex = 1;
            label1.Text = "Lihat Review Pengguna";
            // 
            // ViewAllReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 450);
            Controls.Add(label1);
            Controls.Add(dgvallreview);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewAllReview";
            Text = "ViewLihatBooking";
            Load += ViewAllReview_Load;
            ((System.ComponentModel.ISupportInitialize)dgvallreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvallreview;
        private Label label1;
    }
}