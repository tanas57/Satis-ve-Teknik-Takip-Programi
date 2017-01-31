namespace By_Tayo
{
    partial class MusteriKategoriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriKategoriEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.katAdi = new System.Windows.Forms.TextBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı";
            // 
            // katAdi
            // 
            this.katAdi.Location = new System.Drawing.Point(83, 48);
            this.katAdi.MaxLength = 100;
            this.katAdi.Name = "katAdi";
            this.katAdi.Size = new System.Drawing.Size(191, 20);
            this.katAdi.TabIndex = 1;
            // 
            // Ekle
            // 
            this.Ekle.Image = global::By_Tayo.Properties.Resources.ekle;
            this.Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ekle.Location = new System.Drawing.Point(113, 83);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(106, 36);
            this.Ekle.TabIndex = 2;
            this.Ekle.Text = "      Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // MusteriKategoriEkle
            // 
            this.AcceptButton = this.Ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 149);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.katAdi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(308, 188);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(308, 188);
            this.Name = "MusteriKategoriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Kategorisi Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox katAdi;
        private System.Windows.Forms.Button Ekle;
    }
}