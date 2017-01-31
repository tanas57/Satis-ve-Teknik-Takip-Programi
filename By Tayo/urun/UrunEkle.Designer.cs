namespace By_Tayo
{
    partial class UrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunEkle));
            this.barkodlu = new System.Windows.Forms.CheckBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AlisFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.katekle = new System.Windows.Forms.PictureBox();
            this.UrunKategori = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UrunFiyat = new System.Windows.Forms.TextBox();
            this.UrunBarkod = new System.Windows.Forms.TextBox();
            this.UrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).BeginInit();
            this.SuspendLayout();
            // 
            // barkodlu
            // 
            this.barkodlu.AutoSize = true;
            this.barkodlu.Checked = true;
            this.barkodlu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barkodlu.Location = new System.Drawing.Point(262, 64);
            this.barkodlu.Name = "barkodlu";
            this.barkodlu.Size = new System.Drawing.Size(76, 17);
            this.barkodlu.TabIndex = 3;
            this.barkodlu.Text = "Barkodsuz";
            this.barkodlu.UseVisualStyleBackColor = true;
            this.barkodlu.CheckedChanged += new System.EventHandler(this.barkodlu_CheckedChanged);
            // 
            // Ekle
            // 
            this.Ekle.Image = global::By_Tayo.Properties.Resources.tik32;
            this.Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ekle.Location = new System.Drawing.Point(89, 214);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(94, 40);
            this.Ekle.TabIndex = 7;
            this.Ekle.Text = "      Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AlisFiyat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.katekle);
            this.groupBox1.Controls.Add(this.barkodlu);
            this.groupBox1.Controls.Add(this.Ekle);
            this.groupBox1.Controls.Add(this.UrunKategori);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.UrunFiyat);
            this.groupBox1.Controls.Add(this.UrunBarkod);
            this.groupBox1.Controls.Add(this.UrunAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // AlisFiyat
            // 
            this.AlisFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AlisFiyat.Location = new System.Drawing.Point(95, 103);
            this.AlisFiyat.MaxLength = 10;
            this.AlisFiyat.Name = "AlisFiyat";
            this.AlisFiyat.Size = new System.Drawing.Size(160, 20);
            this.AlisFiyat.TabIndex = 4;
            this.AlisFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlisFiyat_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ürün Satış Fiyatı:";
            // 
            // katekle
            // 
            this.katekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.katekle.Image = global::By_Tayo.Properties.Resources.kategori;
            this.katekle.Location = new System.Drawing.Point(272, 174);
            this.katekle.Name = "katekle";
            this.katekle.Size = new System.Drawing.Size(32, 32);
            this.katekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.katekle.TabIndex = 34;
            this.katekle.TabStop = false;
            this.katekle.Tag = "Müşteri Kategorisi Ekle";
            this.katekle.Click += new System.EventHandler(this.katekle_Click);
            // 
            // UrunKategori
            // 
            this.UrunKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UrunKategori.FormattingEnabled = true;
            this.UrunKategori.Location = new System.Drawing.Point(95, 179);
            this.UrunKategori.Name = "UrunKategori";
            this.UrunKategori.Size = new System.Drawing.Size(160, 21);
            this.UrunKategori.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürün Kategori:";
            // 
            // UrunFiyat
            // 
            this.UrunFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UrunFiyat.Location = new System.Drawing.Point(95, 140);
            this.UrunFiyat.MaxLength = 10;
            this.UrunFiyat.Name = "UrunFiyat";
            this.UrunFiyat.Size = new System.Drawing.Size(160, 20);
            this.UrunFiyat.TabIndex = 5;
            this.UrunFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrunFiyat_KeyPress);
            // 
            // UrunBarkod
            // 
            this.UrunBarkod.Enabled = false;
            this.UrunBarkod.Location = new System.Drawing.Point(95, 62);
            this.UrunBarkod.MaxLength = 15;
            this.UrunBarkod.Name = "UrunBarkod";
            this.UrunBarkod.Size = new System.Drawing.Size(160, 20);
            this.UrunBarkod.TabIndex = 2;
            this.UrunBarkod.Text = "Barkod Eklenmedi";
            this.UrunBarkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrunBarkod_KeyPress);
            // 
            // UrunAdi
            // 
            this.UrunAdi.Location = new System.Drawing.Point(95, 23);
            this.UrunAdi.MaxLength = 100;
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Size = new System.Drawing.Size(160, 20);
            this.UrunAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Alış Fiyatı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Barkod:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // UrunEkle
            // 
            this.AcceptButton = this.Ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 284);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(363, 323);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(363, 323);
            this.Name = "UrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Ürün Ekle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox barkodlu;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox UrunKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UrunFiyat;
        private System.Windows.Forms.TextBox UrunBarkod;
        private System.Windows.Forms.TextBox UrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox katekle;
        private System.Windows.Forms.TextBox AlisFiyat;
        private System.Windows.Forms.Label label5;
    }
}