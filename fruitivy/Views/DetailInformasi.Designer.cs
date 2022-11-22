namespace fruitivy.Views
{
    partial class DetailInformasi
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
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.lblInfoType = new System.Windows.Forms.Label();
            this.lblInfoDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfoTitle
            // 
            this.lblInfoTitle.AutoSize = true;
            this.lblInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTitle.Location = new System.Drawing.Point(27, 24);
            this.lblInfoTitle.Name = "lblInfoTitle";
            this.lblInfoTitle.Size = new System.Drawing.Size(71, 31);
            this.lblInfoTitle.TabIndex = 0;
            this.lblInfoTitle.Text = "Title";
            // 
            // lblInfoType
            // 
            this.lblInfoType.AutoSize = true;
            this.lblInfoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoType.Location = new System.Drawing.Point(31, 61);
            this.lblInfoType.Name = "lblInfoType";
            this.lblInfoType.Size = new System.Drawing.Size(43, 16);
            this.lblInfoType.TabIndex = 1;
            this.lblInfoType.Text = "Type";
            // 
            // lblInfoDescription
            // 
            this.lblInfoDescription.AutoSize = true;
            this.lblInfoDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDescription.Location = new System.Drawing.Point(30, 108);
            this.lblInfoDescription.MaximumSize = new System.Drawing.Size(1420, 0);
            this.lblInfoDescription.Name = "lblInfoDescription";
            this.lblInfoDescription.Size = new System.Drawing.Size(89, 20);
            this.lblInfoDescription.TabIndex = 2;
            this.lblInfoDescription.Text = "Description";
            // 
            // DetailInformasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1446, 636);
            this.Controls.Add(this.lblInfoDescription);
            this.Controls.Add(this.lblInfoType);
            this.Controls.Add(this.lblInfoTitle);
            this.Name = "DetailInformasi";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Text = "DetailInformasi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.Label lblInfoType;
        private System.Windows.Forms.Label lblInfoDescription;
    }
}