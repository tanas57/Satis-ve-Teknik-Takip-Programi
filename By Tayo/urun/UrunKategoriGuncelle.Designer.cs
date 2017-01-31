namespace By_Tayo
{
    partial class UrunKategoriGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunKategoriGuncelle));
            this.UrunKategoriAdi = new System.Windows.Forms.TextBox();
            this.ButonUrunKategoriGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.katekle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).BeginInit();
            this.SuspendLayout();
            // 
            // UrunKategoriAdi
            // 
            this.UrunKategoriAdi.Location = new System.Drawing.Point(70, 31);
            this.UrunKategoriAdi.MaxLength = 100;
            this.UrunKategoriAdi.Name = "UrunKategoriAdi";
            this.UrunKategoriAdi.Size = new System.Drawing.Size(207, 20);
            this.UrunKategoriAdi.TabIndex = 0;
            // 
            // ButonUrunKategoriGuncelle
            // 
            this.ButonUrunKategoriGuncelle.Image = global::By_Tayo.Properties.Resources.tik32;
            this.ButonUrunKategoriGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButonUrunKategoriGuncelle.Location = new System.Drawing.Point(136, 54);
            this.ButonUrunKategoriGuncelle.Name = "ButonUrunKategoriGuncelle";
            this.ButonUrunKategoriGuncelle.Size = new System.Drawing.Size(92, 38);
            this.ButonUrunKategoriGuncelle.TabIndex = 1;
            this.ButonUrunKategoriGuncelle.Text = "Güncelle";
            this.ButonUrunKategoriGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButonUrunKategoriGuncelle.UseVisualStyleBackColor = true;
            this.ButonUrunKategoriGuncelle.Click += new System.EventHandler(this.ButonUrunKategoriGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Adı";
            // 
            // katekle
            // 
            this.katekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.katekle.Image = global::By_Tayo.Properties.Resources.kategori;
            this.katekle.Location = new System.Drawing.Point(292, 23);
            this.katekle.Name = "katekle";
            this.katekle.Size = new System.Drawing.Size(32, 32);
            this.katekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.katekle.TabIndex = 35;
            this.katekle.TabStop = false;
            this.katekle.Tag = "Müşteri Kategorisi Ekle";
            this.katekle.Click += new System.EventHandler(this.katekle_Click);
            // 
            // UrunKategoriGuncelle
            // 
            this.AcceptButton = this.ButonUrunKategoriGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 94);
            this.Controls.Add(this.katekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButonUrunKategoriGuncelle);
            this.Controls.Add(this.UrunKategoriAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(366, 133);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(366, 133);
            this.Name = "UrunKategoriGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Kategori Güncelle";
            this.Load += new System.EventHandler(this.KategoriGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrunKategoriAdi;
        private System.Windows.Forms.Button ButonUrunKategoriGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox katekle;
    }
}