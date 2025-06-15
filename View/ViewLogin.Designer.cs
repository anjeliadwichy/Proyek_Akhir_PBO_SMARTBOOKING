namespace projectakhirsem2
{
    partial class ViewLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbemail = new TextBox();
            tbpassword = new TextBox();
            btlogin = new Button();
            btsignuplogin = new Button();
            pdatabooking = new PictureBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pdatabooking).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 10);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 153);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 201);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // tbemail
            // 
            tbemail.Location = new Point(150, 150);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(193, 23);
            tbemail.TabIndex = 3;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(150, 198);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(193, 23);
            tbpassword.TabIndex = 4;
            // 
            // btlogin
            // 
            btlogin.Location = new Point(252, 281);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(91, 34);
            btlogin.TabIndex = 5;
            btlogin.Text = "Login";
            btlogin.UseVisualStyleBackColor = true;
            btlogin.Click += btlogin_Click;
            // 
            // btsignuplogin
            // 
            btsignuplogin.Location = new Point(57, 281);
            btsignuplogin.Name = "btsignuplogin";
            btsignuplogin.Size = new Size(91, 34);
            btsignuplogin.TabIndex = 6;
            btsignuplogin.Text = "Sign Up";
            btsignuplogin.UseVisualStyleBackColor = true;
            btsignuplogin.Click += btsignuplogin_Click;
            // 
            // pdatabooking
            // 
            pdatabooking.BackColor = Color.Transparent;
            pdatabooking.BackgroundImageLayout = ImageLayout.None;
            pdatabooking.Image = (Image)resources.GetObject("pdatabooking.Image");
            pdatabooking.InitialImage = (Image)resources.GetObject("pdatabooking.InitialImage");
            pdatabooking.Location = new Point(179, 65);
            pdatabooking.MaximumSize = new Size(100, 100);
            pdatabooking.Name = "pdatabooking";
            pdatabooking.Size = new Size(50, 56);
            pdatabooking.SizeMode = PictureBoxSizeMode.StretchImage;
            pdatabooking.TabIndex = 7;
            pdatabooking.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(150, 237);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkBox1.Click += checkBox1_Click;
            // 
            // ViewLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 349);
            Controls.Add(checkBox1);
            Controls.Add(pdatabooking);
            Controls.Add(btsignuplogin);
            Controls.Add(btlogin);
            Controls.Add(tbpassword);
            Controls.Add(tbemail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewLogin";
            Text = "Log In";
            Load += ViewLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pdatabooking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbemail;
        private TextBox tbpassword;
        private Button btlogin;
        private Button btsignuplogin;
        private PictureBox pdatabooking;
        private CheckBox checkBox1;
    }
}
