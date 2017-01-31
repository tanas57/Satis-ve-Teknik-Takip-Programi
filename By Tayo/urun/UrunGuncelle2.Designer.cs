namespace By_Tayo
{
    partial class UrunGuncelle2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunGuncelle2));
            this.UrunArama = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UrunBarkodaGoreGrup = new System.Windows.Forms.GroupBox();
            this.AramaButonBarkod = new System.Windows.Forms.Button();
            this.BarkodNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UrunAdaGoreGrup = new System.Windows.Forms.GroupBox();
            this.AramaButonAd = new System.Windows.Forms.Button();
            this.UrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UrunGuncelleme = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AlisFiyat = new System.Windows.Forms.TextBox();
            this.katekle = new System.Windows.Forms.PictureBox();
            this.Guncelle = new System.Windows.Forms.Button();
            this.UrunKategori = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UrunFiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.barkodlu = new System.Windows.Forms.CheckBox();
            this.UrunAd = new System.Windows.Forms.TextBox();
            this.UrunBarkod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UrunArama.SuspendLayout();
            this.UrunBarkodaGoreGrup.SuspendLayout();
            this.UrunAdaGoreGrup.SuspendLayout();
            this.UrunGuncelleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).BeginInit();
            this.SuspendLayout();
            // 
            // UrunArama
            // 
            this.UrunArama.Controls.Add(this.comboBox1);
            this.UrunArama.Controls.Add(this.label3);
            this.UrunArama.Controls.Add(this.UrunBarkodaGoreGrup);
            this.UrunArama.Controls.Add(this.UrunAdaGoreGrup);
            this.UrunArama.Location = new System.Drawing.Point(12, 12);
            this.UrunArama.Name = "UrunArama";
            this.UrunArama.Size = new System.Drawing.Size(544, 214);
            this.UrunArama.TabIndex = 1;
            this.UrunArama.TabStop = false;
            this.UrunArama.Text = "Ürün Arama";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(78, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bulunan Ürünler -->";
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
            this.AramaButonBarkod.Location = new System.Drawing.Point(119, 85);
            this.AramaButonBarkod.Name = "AramaButonBarkod";
            this.AramaButonBarkod.Size = new System.Drawing.Size(79, 41);
            this.AramaButonBarkod.TabIndex = 2;
            this.AramaButonBarkod.Text = "Arama ";
            this.AramaButonBarkod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AramaButonBarkod.UseVisualStyleBackColor = true;
            this.AramaButonBarkod.Click += new System.EventHandler(this.AramaButonBarkod_Click);
            // 
            // BarkodNo
            // 
            this.BarkodNo.Location = new System.Drawing.Point(75, 51);
            this.BarkodNo.MaxLength = 15;
            this.BarkodNo.Name = "BarkodNo";
            this.BarkodNo.Size = new System.Drawing.Size(178, 20);
            this.BarkodNo.TabIndex = 1;
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
            this.AramaButonAd.Location = new System.Drawing.Point(99, 85);
            this.AramaButonAd.Name = "AramaButonAd";
            this.AramaButonAd.Size = new System.Drawing.Size(79, 41);
            this.AramaButonAd.TabIndex = 2;
            this.AramaButonAd.Text = "Arama ";
            this.AramaButonAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // UrunGuncelleme
            // 
            this.UrunGuncelleme.Controls.Add(this.label8);
            this.UrunGuncelleme.Controls.Add(this.AlisFiyat);
            this.UrunGuncelleme.Controls.Add(this.katekle);
            this.UrunGuncelleme.Controls.Add(this.Guncelle);
            this.UrunGuncelleme.Controls.Add(this.UrunKategori);
            this.UrunGuncelleme.Controls.Add(this.label6);
            this.UrunGuncelleme.Controls.Add(this.UrunFiyat);
            this.UrunGuncelleme.Controls.Add(this.label7);
            this.UrunGuncelleme.Controls.Add(this.barkodlu);
            this.UrunGuncelleme.Controls.Add(this.UrunAd);
            this.UrunGuncelleme.Controls.Add(this.UrunBarkod);
            this.UrunGuncelleme.Controls.Add(this.label5);
            this.UrunGuncelleme.Controls.Add(this.label4);
            this.UrunGuncelleme.Enabled = false;
            this.UrunGuncelleme.Location = new System.Drawing.Point(13, 242);
            this.UrunGuncelleme.Name = "UrunGuncelleme";
            this.UrunGuncelleme.Size = new System.Drawing.Size(542, 201);
            this.UrunGuncelleme.TabIndex = 2;
            this.UrunGuncelleme.TabStop = false;
            this.UrunGuncelleme.Text = "Ürün Güncelleme";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Ürün Satış Fiyatı:";
            // 
            // AlisFiyat
            // 
            this.AlisFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AlisFiyat.Location = new System.Drawing.Point(112, 106);
            this.AlisFiyat.MaxLength = 10;
            this.AlisFiyat.Name = "AlisFiyat";
            this.AlisFiyat.Size = new System.Drawing.Size(160, 20);
            this.AlisFiyat.TabIndex = 8;
            this.AlisFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlisFiyat_KeyPress);
            // 
            // katekle
            // 
            this.katekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.katekle.Image = global::By_Tayo.Properties.Resources.kategori;
            this.katekle.Location = new System.Drawing.Point(287, 138);
            this.katekle.Name = "katekle";
            this.katekle.Size = new System.Drawing.Size(32, 32);
            this.katekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.katekle.TabIndex = 35;
            this.katekle.TabStop = false;
            this.katekle.Tag = "Müşteri Kategorisi Ekle";
            this.katekle.Click += new System.EventHandler(this.katekle_Click);
            // 
            // Guncelle
            // 
            this.Guncelle.Image = global::By_Tayo.Properties.Resources.tik32;
            this.Guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guncelle.Location = new System.Drawing.Point(371, 154);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(110, 40);
            this.Guncelle.TabIndex = 11;
            this.Guncelle.Text = "Güncelle    ";
            this.Guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // UrunKategori
            // 
            this.UrunKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UrunKategori.FormattingEnabled = true;
            this.UrunKategori.Location = new System.Drawing.Point(112, 143);
            this.UrunKategori.Name = "UrunKategori";
            this.UrunKategori.Size = new System.Drawing.Size(160, 21);
            this.UrunKategori.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ürün Kategori:";
            // 
            // UrunFiyat
            // 
            this.UrunFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UrunFiyat.Location = new System.Drawing.Point(371, 106);
            this.UrunFiyat.MaxLength = 10;
            this.UrunFiyat.Name = "UrunFiyat";
            this.UrunFiyat.Size = new System.Drawing.Size(160, 20);
            this.UrunFiyat.TabIndex = 9;
            this.UrunFiyat.TextChanged += new System.EventHandler(this.UrunFiyat_TextChanged);
            this.UrunFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrunFiyat_KeyPress);
            this.UrunFiyat.Validating += new System.ComponentModel.CancelEventHandler(this.UrunFiyat_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ürün Alış Fiyatı:";
            // 
            // barkodlu
            // 
            this.barkodlu.AutoSize = true;
            this.barkodlu.Checked = true;
            this.barkodlu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barkodlu.Location = new System.Drawing.Point(278, 67);
            this.barkodlu.Name = "barkodlu";
            this.barkodlu.Size = new System.Drawing.Size(76, 17);
            this.barkodlu.TabIndex = 7;
            this.barkodlu.Text = "Barkodsuz";
            this.barkodlu.UseVisualStyleBackColor = true;
            this.barkodlu.CheckedChanged += new System.EventHandler(this.barkodlu_CheckedChanged);
            // 
            // UrunAd
            // 
            this.UrunAd.Location = new System.Drawing.Point(112, 32);
            this.UrunAd.MaxLength = 150;
            this.UrunAd.Name = "UrunAd";
            this.UrunAd.Size = new System.Drawing.Size(160, 20);
            this.UrunAd.TabIndex = 5;
            // 
            // UrunBarkod
            // 
            this.UrunBarkod.Enabled = false;
            this.UrunBarkod.Location = new System.Drawing.Point(112, 67);
            this.UrunBarkod.MaxLength = 15;
            this.UrunBarkod.Name = "UrunBarkod";
            this.UrunBarkod.Size = new System.Drawing.Size(160, 20);
            this.UrunBarkod.TabIndex = 6;
            this.UrunBarkod.Text = "Barkod Eklenmedi";
            this.UrunBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrunBarkod_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ürün Barkod:";
            // 
            // UrunGuncelle2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 448);
            this.Controls.Add(this.UrunGuncelleme);
            this.Controls.Add(this.UrunArama);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UrunGuncelle2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Güncelleme";
            this.Load += new System.EventHandler(this.UrunGuncelle2_Load);
            this.UrunArama.ResumeLayout(false);
            this.UrunArama.PerformLayout();
            this.UrunBarkodaGoreGrup.ResumeLayout(false);
            this.UrunBarkodaGoreGrup.PerformLayout();
            this.UrunAdaGoreGrup.ResumeLayout(false);
            this.UrunAdaGoreGrup.PerformLayout();
            this.UrunGuncelleme.ResumeLayout(false);
            this.UrunGuncelleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UrunArama;
        private System.Windows.Forms.GroupBox UrunBarkodaGoreGrup;
        private System.Windows.Forms.Button AramaButonBarkod;
        private System.Windows.Forms.TextBox BarkodNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox UrunAdaGoreGrup;
        private System.Windows.Forms.Button AramaButonAd;
        private System.Windows.Forms.TextBox UrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox UrunGuncelleme;
        private System.Windows.Forms.CheckBox barkodlu;
        private System.Windows.Forms.TextBox UrunAd;
        private System.Windows.Forms.TextBox UrunBarkod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.ComboBox UrunKategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UrunFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox katekle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AlisFiyat;


    }
}