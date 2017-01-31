namespace By_Tayo
{
    partial class Urunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urunler));
            this.UrunArama = new System.Windows.Forms.GroupBox();
            this.UrunBarkodaGoreGrup = new System.Windows.Forms.GroupBox();
            this.AramaButonBarkod = new System.Windows.Forms.Button();
            this.BarkodNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UrunAdaGoreGrup = new System.Windows.Forms.GroupBox();
            this.AramaButonAd = new System.Windows.Forms.Button();
            this.UrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Urunid = new System.Windows.Forms.TextBox();
            this.ButonGuncelle = new System.Windows.Forms.Button();
            this.ButonSil = new System.Windows.Forms.Button();
            this.UrunArama.SuspendLayout();
            this.UrunBarkodaGoreGrup.SuspendLayout();
            this.UrunAdaGoreGrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UrunArama
            // 
            this.UrunArama.Controls.Add(this.UrunBarkodaGoreGrup);
            this.UrunArama.Controls.Add(this.UrunAdaGoreGrup);
            this.UrunArama.Location = new System.Drawing.Point(83, 7);
            this.UrunArama.Name = "UrunArama";
            this.UrunArama.Size = new System.Drawing.Size(544, 174);
            this.UrunArama.TabIndex = 0;
            this.UrunArama.TabStop = false;
            this.UrunArama.Text = "Ürün Arama";
            // 
            // UrunBarkodaGoreGrup
            // 
            this.UrunBarkodaGoreGrup.Controls.Add(this.AramaButonBarkod);
            this.UrunBarkodaGoreGrup.Controls.Add(this.BarkodNo);
            this.UrunBarkodaGoreGrup.Controls.Add(this.label2);
            this.UrunBarkodaGoreGrup.Location = new System.Drawing.Point(279, 19);
            this.UrunBarkodaGoreGrup.Name = "UrunBarkodaGoreGrup";
            this.UrunBarkodaGoreGrup.Size = new System.Drawing.Size(259, 142);
            this.UrunBarkodaGoreGrup.TabIndex = 1;
            this.UrunBarkodaGoreGrup.TabStop = false;
            this.UrunBarkodaGoreGrup.Text = "Barkod Numarasına Göre Arama";
            // 
            // AramaButonBarkod
            // 
            this.AramaButonBarkod.Image = global::By_Tayo.Properties.Resources.ara;
            this.AramaButonBarkod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AramaButonBarkod.Location = new System.Drawing.Point(75, 90);
            this.AramaButonBarkod.Name = "AramaButonBarkod";
            this.AramaButonBarkod.Size = new System.Drawing.Size(91, 31);
            this.AramaButonBarkod.TabIndex = 3;
            this.AramaButonBarkod.Text = "     Arama";
            this.AramaButonBarkod.UseVisualStyleBackColor = true;
            this.AramaButonBarkod.Click += new System.EventHandler(this.AramaButonBarkod_Click);
            // 
            // BarkodNo
            // 
            this.BarkodNo.Location = new System.Drawing.Point(75, 51);
            this.BarkodNo.MaxLength = 15;
            this.BarkodNo.Name = "BarkodNo";
            this.BarkodNo.Size = new System.Drawing.Size(178, 20);
            this.BarkodNo.TabIndex = 3;
            this.BarkodNo.TextChanged += new System.EventHandler(this.BarkodNo_TextChanged);
            this.BarkodNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarkodNo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barkod No:";
            // 
            // UrunAdaGoreGrup
            // 
            this.UrunAdaGoreGrup.Controls.Add(this.AramaButonAd);
            this.UrunAdaGoreGrup.Controls.Add(this.UrunAdi);
            this.UrunAdaGoreGrup.Controls.Add(this.label1);
            this.UrunAdaGoreGrup.Location = new System.Drawing.Point(14, 19);
            this.UrunAdaGoreGrup.Name = "UrunAdaGoreGrup";
            this.UrunAdaGoreGrup.Size = new System.Drawing.Size(259, 142);
            this.UrunAdaGoreGrup.TabIndex = 0;
            this.UrunAdaGoreGrup.TabStop = false;
            this.UrunAdaGoreGrup.Text = "Ürün Adına Göre Arama";
            // 
            // AramaButonAd
            // 
            this.AramaButonAd.AccessibleName = "a";
            this.AramaButonAd.Image = global::By_Tayo.Properties.Resources.ara;
            this.AramaButonAd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AramaButonAd.Location = new System.Drawing.Point(67, 90);
            this.AramaButonAd.Name = "AramaButonAd";
            this.AramaButonAd.Size = new System.Drawing.Size(91, 31);
            this.AramaButonAd.TabIndex = 2;
            this.AramaButonAd.Text = "     Arama";
            this.AramaButonAd.UseVisualStyleBackColor = true;
            this.AramaButonAd.Click += new System.EventHandler(this.AramaButonAd_Click);
            // 
            // UrunAdi
            // 
            this.UrunAdi.AccessibleName = "a";
            this.UrunAdi.Location = new System.Drawing.Point(67, 55);
            this.UrunAdi.MaxLength = 100;
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Size = new System.Drawing.Size(178, 20);
            this.UrunAdi.TabIndex = 1;
            this.UrunAdi.TextChanged += new System.EventHandler(this.UrunAdi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 230);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Urunid
            // 
            this.Urunid.Location = new System.Drawing.Point(690, 223);
            this.Urunid.Name = "Urunid";
            this.Urunid.Size = new System.Drawing.Size(36, 20);
            this.Urunid.TabIndex = 2;
            this.Urunid.Visible = false;
            // 
            // ButonGuncelle
            // 
            this.ButonGuncelle.Image = global::By_Tayo.Properties.Resources.duzenle;
            this.ButonGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButonGuncelle.Location = new System.Drawing.Point(677, 259);
            this.ButonGuncelle.Name = "ButonGuncelle";
            this.ButonGuncelle.Size = new System.Drawing.Size(94, 38);
            this.ButonGuncelle.TabIndex = 3;
            this.ButonGuncelle.Text = "Güncelle  ";
            this.ButonGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButonGuncelle.UseVisualStyleBackColor = true;
            this.ButonGuncelle.Click += new System.EventHandler(this.ButonGuncelle_Click);
            // 
            // ButonSil
            // 
            this.ButonSil.Image = global::By_Tayo.Properties.Resources.carpi32;
            this.ButonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButonSil.Location = new System.Drawing.Point(678, 303);
            this.ButonSil.Name = "ButonSil";
            this.ButonSil.Size = new System.Drawing.Size(93, 38);
            this.ButonSil.TabIndex = 4;
            this.ButonSil.Text = "    Sil";
            this.ButonSil.UseVisualStyleBackColor = true;
            this.ButonSil.Click += new System.EventHandler(this.ButonSil_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 419);
            this.Controls.Add(this.ButonSil);
            this.Controls.Add(this.ButonGuncelle);
            this.Controls.Add(this.Urunid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UrunArama);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(792, 458);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(792, 458);
            this.Name = "Urunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            this.UrunArama.ResumeLayout(false);
            this.UrunBarkodaGoreGrup.ResumeLayout(false);
            this.UrunBarkodaGoreGrup.PerformLayout();
            this.UrunAdaGoreGrup.ResumeLayout(false);
            this.UrunAdaGoreGrup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UrunArama;
        private System.Windows.Forms.GroupBox UrunBarkodaGoreGrup;
        private System.Windows.Forms.GroupBox UrunAdaGoreGrup;
        private System.Windows.Forms.Button AramaButonBarkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AramaButonAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Urunid;
        private System.Windows.Forms.Button ButonGuncelle;
        private System.Windows.Forms.Button ButonSil;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox BarkodNo;
        public System.Windows.Forms.TextBox UrunAdi;
    }
}