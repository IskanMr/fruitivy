namespace fruitivy
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbUsernameSignUp = new System.Windows.Forms.Label();
            this.tbEmailSignUp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPembeliLogin = new System.Windows.Forms.RadioButton();
            this.rbPenjualLogin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPasswordSignUp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1023, 621);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.tbPasswordSignUp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.tbUsernameSignUp);
            this.panel1.Controls.Add(this.tbEmailSignUp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbPembeliLogin);
            this.panel1.Controls.Add(this.rbPenjualLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(313, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 548);
            this.panel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Daftar sebagai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(79, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sudah memiliki akun?";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblLogin.Location = new System.Drawing.Point(265, 486);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(55, 20);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(49, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Masuk";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(53, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 31);
            this.textBox1.TabIndex = 6;
            // 
            // tbUsernameSignUp
            // 
            this.tbUsernameSignUp.AutoSize = true;
            this.tbUsernameSignUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameSignUp.Location = new System.Drawing.Point(49, 253);
            this.tbUsernameSignUp.Name = "tbUsernameSignUp";
            this.tbUsernameSignUp.Size = new System.Drawing.Size(111, 23);
            this.tbUsernameSignUp.TabIndex = 5;
            this.tbUsernameSignUp.Text = "Username";
            // 
            // tbEmailSignUp
            // 
            this.tbEmailSignUp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbEmailSignUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmailSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmailSignUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailSignUp.Location = new System.Drawing.Point(53, 203);
            this.tbEmailSignUp.Name = "tbEmailSignUp";
            this.tbEmailSignUp.Size = new System.Drawing.Size(302, 31);
            this.tbEmailSignUp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // rbPembeliLogin
            // 
            this.rbPembeliLogin.AutoSize = true;
            this.rbPembeliLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPembeliLogin.Location = new System.Drawing.Point(192, 127);
            this.rbPembeliLogin.Name = "rbPembeliLogin";
            this.rbPembeliLogin.Size = new System.Drawing.Size(109, 27);
            this.rbPembeliLogin.TabIndex = 2;
            this.rbPembeliLogin.TabStop = true;
            this.rbPembeliLogin.Text = "Pembeli";
            this.rbPembeliLogin.UseVisualStyleBackColor = true;
            // 
            // rbPenjualLogin
            // 
            this.rbPenjualLogin.AutoSize = true;
            this.rbPenjualLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPenjualLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPenjualLogin.Location = new System.Drawing.Point(56, 127);
            this.rbPenjualLogin.Name = "rbPenjualLogin";
            this.rbPenjualLogin.Size = new System.Drawing.Size(102, 27);
            this.rbPenjualLogin.TabIndex = 1;
            this.rbPenjualLogin.TabStop = true;
            this.rbPenjualLogin.Text = "Penjual";
            this.rbPenjualLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daftar";
            // 
            // tbPasswordSignUp
            // 
            this.tbPasswordSignUp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbPasswordSignUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPasswordSignUp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPasswordSignUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordSignUp.Location = new System.Drawing.Point(53, 360);
            this.tbPasswordSignUp.Name = "tbPasswordSignUp";
            this.tbPasswordSignUp.Size = new System.Drawing.Size(302, 31);
            this.tbPasswordSignUp.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kata Sandi";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1021, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SignUpForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tbUsernameSignUp;
        private System.Windows.Forms.TextBox tbEmailSignUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPembeliLogin;
        private System.Windows.Forms.RadioButton rbPenjualLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPasswordSignUp;
    }
}