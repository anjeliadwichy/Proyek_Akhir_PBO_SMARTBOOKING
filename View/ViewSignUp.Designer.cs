namespace projectakhirsem2.View
{
    partial class ViewSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSignUp));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbnama = new TextBox();
            tbemail = new TextBox();
            tbnotelp = new TextBox();
            tbpasswordsup = new TextBox();
            btsignup = new Button();
            btbatal = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 20);
            label1.Name = "label1";
            label1.Size = new Size(117, 37);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 97);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 134);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 175);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "No. Telp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 217);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // tbnama
            // 
            tbnama.Location = new Point(166, 94);
            tbnama.Name = "tbnama";
            tbnama.Size = new Size(198, 23);
            tbnama.TabIndex = 6;
            // 
            // tbemail
            // 
            tbemail.Location = new Point(166, 131);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(198, 23);
            tbemail.TabIndex = 7;
            // 
            // tbnotelp
            // 
            tbnotelp.Location = new Point(166, 172);
            tbnotelp.Name = "tbnotelp";
            tbnotelp.Size = new Size(198, 23);
            tbnotelp.TabIndex = 8;
            // 
            // tbpasswordsup
            // 
            tbpasswordsup.Location = new Point(166, 214);
            tbpasswordsup.Name = "tbpasswordsup";
            tbpasswordsup.Size = new Size(198, 23);
            tbpasswordsup.TabIndex = 10;
            // 
            // btsignup
            // 
            btsignup.Location = new Point(280, 296);
            btsignup.Name = "btsignup";
            btsignup.Size = new Size(84, 29);
            btsignup.TabIndex = 11;
            btsignup.Text = "Sign Up";
            btsignup.UseVisualStyleBackColor = true;
            btsignup.Click += btsignup_Click;
            // 
            // btbatal
            // 
            btbatal.Location = new Point(68, 296);
            btbatal.Name = "btbatal";
            btbatal.Size = new Size(84, 29);
            btbatal.TabIndex = 12;
            btbatal.Text = "Batal";
            btbatal.UseVisualStyleBackColor = true;
            btbatal.Click += btbatal_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(166, 253);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ViewSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 367);
            Controls.Add(checkBox1);
            Controls.Add(btbatal);
            Controls.Add(btsignup);
            Controls.Add(tbpasswordsup);
            Controls.Add(tbnotelp);
            Controls.Add(tbemail);
            Controls.Add(tbnama);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewSignUp";
            Text = "Sign Up";
            Load += ViewSignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbnama;
        private TextBox tbemail;
        private TextBox tbnotelp;
        private TextBox tbpasswordsup;
        private Button btsignup;
        private Button btbatal;
        private CheckBox checkBox1;
    }
}