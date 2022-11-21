namespace fruitivy.Views
{
    partial class ItemBox
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
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblHapus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbItem
            // 
            this.pbItem.Location = new System.Drawing.Point(30, 29);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(100, 93);
            this.pbItem.TabIndex = 0;
            this.pbItem.TabStop = false;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(148, 48);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(52, 19);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(147, 80);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(68, 25);
            this.lblHarga.TabIndex = 2;
            this.lblHarga.Text = "Harga";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEdit.Location = new System.Drawing.Point(572, 65);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(48, 25);
            this.lblEdit.TabIndex = 3;
            this.lblEdit.Text = "Edit";
            this.lblEdit.Click += new System.EventHandler(this.lblEdit_Click);
            // 
            // lblHapus
            // 
            this.lblHapus.AutoSize = true;
            this.lblHapus.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHapus.ForeColor = System.Drawing.Color.Red;
            this.lblHapus.Location = new System.Drawing.Point(640, 65);
            this.lblHapus.Name = "lblHapus";
            this.lblHapus.Size = new System.Drawing.Size(71, 25);
            this.lblHapus.TabIndex = 4;
            this.lblHapus.Text = "Hapus";
            this.lblHapus.Click += new System.EventHandler(this.lblHapus_Click);
            // 
            // ItemBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblHapus);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.pbItem);
            this.Name = "ItemBox";
            this.Size = new System.Drawing.Size(738, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblHapus;
    }
}
