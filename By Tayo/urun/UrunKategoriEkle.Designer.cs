namespace By_Tayo
{
    partial class UrunKategoriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunKategoriEkle));
            this.kategoriadilabel = new System.Windows.Forms.Label();
            this.KategoriAdi = new System.Windows.Forms.TextBox();
            this.UrunKategoriEkleButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kategoriadilabel
            // 
            this.kategoriadilabel.AutoSize = true;
            this.kategoriadilabel.Location = new System.Drawing.Point(80, 30);
            this.kategoriadilabel.Name = "kategoriadilabel";
            this.kategoriadilabel.Size = new System.Drawing.Size(67, 13);
            this.kategoriadilabel.TabIndex = 0;
            this.kategoriadilabel.Text = "Kategori Adı:";
            // 
            // KategoriAdi
            // 
            this.KategoriAdi.Location = new System.Drawing.Point(33, 56);
            this.KategoriAdi.MaxLength = 100;
            this.KategoriAdi.Name = "KategoriAdi";
            this.KategoriAdi.Size = new System.Drawing.Size(164, 20);
            this.KategoriAdi.TabIndex = 1;
            // 
            // UrunKategoriEkleButon
            // 
            this.UrunKategoriEkleButon.Image = global::By_Tayo.Properties.Resources.tik32;
            this.UrunKategoriEkleButon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UrunKategoriEkleButon.Location = new System.Drawing.Point(71, 82);
            this.UrunKategoriEkleButon.Name = "UrunKategoriEkleButon";
            this.UrunKategoriEkleButon.Size = new System.Drawing.Size(84, 49);
            this.UrunKategoriEkleButon.TabIndex = 2;
            this.UrunKategoriEkleButon.Text = "Ekle    ";
            this.UrunKategoriEkleButon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UrunKategoriEkleButon.UseVisualStyleBackColor = true;
            this.UrunKategoriEkleButon.Click += new System.EventHandler(this.UrunKategoriEkleButon_Click);
            // 
            // UrunKategoriEkle
            // 
            this.AcceptButton = this.UrunKategoriEkleButon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 137);
            this.Controls.Add(this.UrunKategoriEkleButon);
            this.Controls.Add(this.KategoriAdi);
            this.Controls.Add(this.kategoriadilabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(236, 176);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(236, 176);
            this.Name = "UrunKategoriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Kategori Ekle";
            this.Load += new System.EventHandler(this.UrunKategoriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kategoriadilabel;
        private System.Windows.Forms.Button UrunKategoriEkleButon;
        protected System.Windows.Forms.TextBox KategoriAdi;
    }
}