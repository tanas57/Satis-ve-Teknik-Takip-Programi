namespace By_Tayo
{
    partial class UrunKategoriGuncelle2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunKategoriGuncelle2));
            this.label1 = new System.Windows.Forms.Label();
            this.AramaKategoriAdi = new System.Windows.Forms.TextBox();
            this.AramaGrup = new System.Windows.Forms.GroupBox();
            this.katekle = new System.Windows.Forms.PictureBox();
            this.UrunKategoriCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GuncellemeKategoriAdi = new System.Windows.Forms.TextBox();
            this.Guncelle = new System.Windows.Forms.Button();
            this.GuncellemeGrup = new System.Windows.Forms.GroupBox();
            this.AramaGrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).BeginInit();
            this.GuncellemeGrup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kategorisi Arama";
            // 
            // AramaKategoriAdi
            // 
            this.AramaKategoriAdi.Location = new System.Drawing.Point(34, 30);
            this.AramaKategoriAdi.MaxLength = 100;
            this.AramaKategoriAdi.Name = "AramaKategoriAdi";
            this.AramaKategoriAdi.Size = new System.Drawing.Size(179, 20);
            this.AramaKategoriAdi.TabIndex = 1;
            this.AramaKategoriAdi.TextChanged += new System.EventHandler(this.AramaKategoriAdi_TextChanged);
            // 
            // AramaGrup
            // 
            this.AramaGrup.Controls.Add(this.katekle);
            this.AramaGrup.Controls.Add(this.UrunKategoriCombo);
            this.AramaGrup.Controls.Add(this.label3);
            this.AramaGrup.Controls.Add(this.AramaKategoriAdi);
            this.AramaGrup.Controls.Add(this.label1);
            this.AramaGrup.Location = new System.Drawing.Point(7, 11);
            this.AramaGrup.Name = "AramaGrup";
            this.AramaGrup.Size = new System.Drawing.Size(271, 127);
            this.AramaGrup.TabIndex = 2;
            this.AramaGrup.TabStop = false;
            this.AramaGrup.Text = "Arama";
            // 
            // katekle
            // 
            this.katekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.katekle.Image = global::By_Tayo.Properties.Resources.kategori;
            this.katekle.Location = new System.Drawing.Point(222, 71);
            this.katekle.Name = "katekle";
            this.katekle.Size = new System.Drawing.Size(32, 32);
            this.katekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.katekle.TabIndex = 35;
            this.katekle.TabStop = false;
            this.katekle.Tag = "Müşteri Kategorisi Ekle";
            this.katekle.Click += new System.EventHandler(this.katekle_Click);
            // 
            // UrunKategoriCombo
            // 
            this.UrunKategoriCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UrunKategoriCombo.Enabled = false;
            this.UrunKategoriCombo.FormattingEnabled = true;
            this.UrunKategoriCombo.Location = new System.Drawing.Point(77, 79);
            this.UrunKategoriCombo.Name = "UrunKategoriCombo";
            this.UrunKategoriCombo.Size = new System.Drawing.Size(136, 21);
            this.UrunKategoriCombo.TabIndex = 3;
            this.UrunKategoriCombo.SelectedIndexChanged += new System.EventHandler(this.UrunKategoriCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seçiniz -->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Kategori Adı";
            // 
            // GuncellemeKategoriAdi
            // 
            this.GuncellemeKategoriAdi.Location = new System.Drawing.Point(32, 51);
            this.GuncellemeKategoriAdi.MaxLength = 100;
            this.GuncellemeKategoriAdi.Name = "GuncellemeKategoriAdi";
            this.GuncellemeKategoriAdi.Size = new System.Drawing.Size(179, 20);
            this.GuncellemeKategoriAdi.TabIndex = 4;
            // 
            // Guncelle
            // 
            this.Guncelle.Image = global::By_Tayo.Properties.Resources.tik32;
            this.Guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guncelle.Location = new System.Drawing.Point(78, 88);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(99, 40);
            this.Guncelle.TabIndex = 5;
            this.Guncelle.Text = "Güncelle   ";
            this.Guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // GuncellemeGrup
            // 
            this.GuncellemeGrup.Controls.Add(this.Guncelle);
            this.GuncellemeGrup.Controls.Add(this.GuncellemeKategoriAdi);
            this.GuncellemeGrup.Controls.Add(this.label2);
            this.GuncellemeGrup.Enabled = false;
            this.GuncellemeGrup.Location = new System.Drawing.Point(9, 144);
            this.GuncellemeGrup.Name = "GuncellemeGrup";
            this.GuncellemeGrup.Size = new System.Drawing.Size(268, 143);
            this.GuncellemeGrup.TabIndex = 6;
            this.GuncellemeGrup.TabStop = false;
            this.GuncellemeGrup.Text = "Güncelleme";
            // 
            // UrunKategoriGuncelle2
            // 
            this.AcceptButton = this.Guncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 292);
            this.Controls.Add(this.GuncellemeGrup);
            this.Controls.Add(this.AramaGrup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 331);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 331);
            this.Name = "UrunKategoriGuncelle2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Kategorisi Güncelleme";
            this.Load += new System.EventHandler(this.UrunKategoriGuncelle2_Load);
            this.AramaGrup.ResumeLayout(false);
            this.AramaGrup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).EndInit();
            this.GuncellemeGrup.ResumeLayout(false);
            this.GuncellemeGrup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AramaKategoriAdi;
        private System.Windows.Forms.GroupBox AramaGrup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GuncellemeKategoriAdi;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.GroupBox GuncellemeGrup;
        private System.Windows.Forms.ComboBox UrunKategoriCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox katekle;
    }
}