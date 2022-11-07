namespace WindowsFormsApp1
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lbForgotPass = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblTextSU = new System.Windows.Forms.Label();
            this.lbSignUp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(53, 90);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 22);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.Control;
            this.tbUsername.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(57, 115);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(0);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(317, 29);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbPassword.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPassword.Location = new System.Drawing.Point(57, 183);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(317, 29);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(53, 158);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(84, 22);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lbForgotPass
            // 
            this.lbForgotPass.AutoSize = true;
            this.lbForgotPass.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPass.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(148)))), ((int)(((byte)(79)))));
            this.lbForgotPass.Location = new System.Drawing.Point(229, 220);
            this.lbForgotPass.Name = "lbForgotPass";
            this.lbForgotPass.Size = new System.Drawing.Size(145, 22);
            this.lbForgotPass.TabIndex = 5;
            this.lbForgotPass.TabStop = true;
            this.lbForgotPass.Text = "Forgot password?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(148)))), ((int)(((byte)(79)))));
            this.btnLogin.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(57, 269);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(317, 38);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblTextSU
            // 
            this.lblTextSU.AutoSize = true;
            this.lblTextSU.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextSU.Location = new System.Drawing.Point(86, 349);
            this.lblTextSU.Name = "lblTextSU";
            this.lblTextSU.Size = new System.Drawing.Size(187, 22);
            this.lblTextSU.TabIndex = 7;
            this.lblTextSU.Text = "Don\'t have an account?";
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(148)))), ((int)(((byte)(79)))));
            this.lbSignUp.Location = new System.Drawing.Point(269, 349);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(66, 22);
            this.lbSignUp.TabIndex = 8;
            this.lbSignUp.TabStop = true;
            this.lbSignUp.Text = "Sign up";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(439, 392);
            this.Controls.Add(this.lbSignUp);
            this.Controls.Add(this.lblTextSU);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbForgotPass);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel lbForgotPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblTextSU;
        private System.Windows.Forms.LinkLabel lbSignUp;
    }
}

