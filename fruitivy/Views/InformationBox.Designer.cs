namespace fruitivy.Views
{
    partial class InformationBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInfoType = new System.Windows.Forms.Label();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.linkInfo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblInfoType
            // 
            this.lblInfoType.AutoSize = true;
            this.lblInfoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoType.Location = new System.Drawing.Point(27, 24);
            this.lblInfoType.Name = "lblInfoType";
            this.lblInfoType.Size = new System.Drawing.Size(39, 16);
            this.lblInfoType.TabIndex = 0;
            this.lblInfoType.Text = "Type";
            // 
            // lblInfoTitle
            // 
            this.lblInfoTitle.AutoSize = true;
            this.lblInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTitle.Location = new System.Drawing.Point(25, 52);
            this.lblInfoTitle.MaximumSize = new System.Drawing.Size(335, 0);
            this.lblInfoTitle.Name = "lblInfoTitle";
            this.lblInfoTitle.Size = new System.Drawing.Size(50, 24);
            this.lblInfoTitle.TabIndex = 1;
            this.lblInfoTitle.Text = "Title";
            // 
            // linkInfo
            // 
            this.linkInfo.AutoSize = true;
            this.linkInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(148)))), ((int)(((byte)(79)))));
            this.linkInfo.Location = new System.Drawing.Point(27, 138);
            this.linkInfo.Name = "linkInfo";
            this.linkInfo.Size = new System.Drawing.Size(75, 16);
            this.linkInfo.TabIndex = 2;
            this.linkInfo.TabStop = true;
            this.linkInfo.Text = "Read more";
            this.linkInfo.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(12)))));
            this.linkInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInfo_LinkClicked);
            // 
            // InformationBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.linkInfo);
            this.Controls.Add(this.lblInfoTitle);
            this.Controls.Add(this.lblInfoType);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "InformationBox";
            this.Padding = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.Size = new System.Drawing.Size(388, 178);
            this.Load += new System.EventHandler(this.InformationBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoType;
        private System.Windows.Forms.Label lblInfoTitle;
        private System.Windows.Forms.LinkLabel linkInfo;
    }
}
