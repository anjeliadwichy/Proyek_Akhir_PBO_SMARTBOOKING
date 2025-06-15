namespace projectakhirsem2.View
{
    partial class ViewReview
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
            dgvreview = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtidbooking = new TextBox();
            tbkomen = new TextBox();
            tbrating = new TextBox();
            dtptglreview = new DateTimePicker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvreview).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(489, 27);
            label1.Name = "label1";
            label1.Size = new Size(177, 40);
            label1.TabIndex = 0;
            label1.Text = "Beri Review";
            // 
            // dgvreview
            // 
            dgvreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvreview.Location = new Point(489, 116);
            dgvreview.MultiSelect = false;
            dgvreview.Name = "dgvreview";
            dgvreview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvreview.Size = new Size(619, 249);
            dgvreview.TabIndex = 1;
            dgvreview.CellClick += dgvreview_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 119);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Id Booking";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 168);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 3;
            label3.Text = "Tanggal Review";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 216);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 4;
            label4.Text = "Rating";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 266);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 5;
            label5.Text = "Komentar";
            // 
            // txtidbooking
            // 
            txtidbooking.Location = new Point(159, 116);
            txtidbooking.Name = "txtidbooking";
            txtidbooking.Size = new Size(100, 23);
            txtidbooking.TabIndex = 6;
            // 
            // tbkomen
            // 
            tbkomen.Location = new Point(159, 263);
            tbkomen.Multiline = true;
            tbkomen.Name = "tbkomen";
            tbkomen.Size = new Size(249, 104);
            tbkomen.TabIndex = 7;
            // 
            // tbrating
            // 
            tbrating.Location = new Point(159, 213);
            tbrating.Name = "tbrating";
            tbrating.Size = new Size(249, 23);
            tbrating.TabIndex = 8;
            // 
            // dtptglreview
            // 
            dtptglreview.Location = new Point(159, 162);
            dtptglreview.Name = "dtptglreview";
            dtptglreview.Size = new Size(200, 23);
            dtptglreview.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(324, 390);
            button1.Name = "button1";
            button1.Size = new Size(84, 34);
            button1.TabIndex = 10;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ViewReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 450);
            Controls.Add(button1);
            Controls.Add(dtptglreview);
            Controls.Add(tbrating);
            Controls.Add(tbkomen);
            Controls.Add(txtidbooking);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvreview);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewReview";
            Text = "ViewReview";
            Load += ViewReview_Load;
            ((System.ComponentModel.ISupportInitialize)dgvreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvreview;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtidbooking;
        private TextBox tbkomen;
        private TextBox tbrating;
        private DateTimePicker dtptglreview;
        private Button button1;
    }
}