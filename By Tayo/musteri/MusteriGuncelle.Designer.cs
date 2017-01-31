namespace By_Tayo
{
    partial class MusteriGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGuncelle));
            this.idyeGoreGrup = new System.Windows.Forms.GroupBox();
            this.katekle = new System.Windows.Forms.PictureBox();
            this.MusTelefonu = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Musteri_bakiye = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ButonidyeGoreGuncelleme = new System.Windows.Forms.Button();
            this.Musteri_kategori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MusAdresi = new System.Windows.Forms.TextBox();
            this.MusSoyadi = new System.Windows.Forms.TextBox();
            this.MusAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idyeGoreGrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).BeginInit();
            this.SuspendLayout();
            // 
            // idyeGoreGrup
            // 
            this.idyeGoreGrup.Controls.Add(this.katekle);
            this.idyeGoreGrup.Controls.Add(this.MusTelefonu);
            this.idyeGoreGrup.Controls.Add(this.label7);
            this.idyeGoreGrup.Controls.Add(this.Musteri_bakiye);
            this.idyeGoreGrup.Controls.Add(this.label6);
            this.idyeGoreGrup.Controls.Add(this.ButonidyeGoreGuncelleme);
            this.idyeGoreGrup.Controls.Add(this.Musteri_kategori);
            this.idyeGoreGrup.Controls.Add(this.label5);
            this.idyeGoreGrup.Controls.Add(this.MusAdresi);
            this.idyeGoreGrup.Controls.Add(this.MusSoyadi);
            this.idyeGoreGrup.Controls.Add(this.MusAdi);
            this.idyeGoreGrup.Controls.Add(this.label4);
            this.idyeGoreGrup.Controls.Add(this.label3);
            this.idyeGoreGrup.Controls.Add(this.label2);
            this.idyeGoreGrup.Controls.Add(this.label1);
            this.idyeGoreGrup.Location = new System.Drawing.Point(12, 12);
            this.idyeGoreGrup.Name = "idyeGoreGrup";
            this.idyeGoreGrup.Size = new System.Drawing.Size(564, 287);
            this.idyeGoreGrup.TabIndex = 32;
            this.idyeGoreGrup.TabStop = false;
            this.idyeGoreGrup.Text = "Müşteri Güncelleme";
            this.idyeGoreGrup.Enter += new System.EventHandler(this.idyeGoreGrup_Enter);
            // 
            // katekle
            // 
            this.katekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.katekle.Image = global::By_Tayo.Properties.Resources.kategori;
            this.katekle.Location = new System.Drawing.Point(518, 177);
            this.katekle.Name = "katekle";
            this.katekle.Size = new System.Drawing.Size(32, 32);
            this.katekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.katekle.TabIndex = 36;
            this.katekle.TabStop = false;
            this.katekle.Tag = "Müşteri Kategorisi Ekle";
            this.katekle.Click += new System.EventHandler(this.katekle_Click);
            // 
            // MusTelefonu
            // 
            this.MusTelefonu.Location = new System.Drawing.Point(360, 123);
            this.MusTelefonu.Mask = "(999) 000-0000";
            this.MusTelefonu.Name = "MusTelefonu";
            this.MusTelefonu.Size = new System.Drawing.Size(180, 20);
            this.MusTelefonu.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(14, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Müşterinin borcu bulunmaktadır.";
            this.label7.Visible = false;
            // 
            // Musteri_bakiye
            // 
            this.Musteri_bakiye.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Musteri_bakiye.Location = new System.Drawing.Point(17, 208);
            this.Musteri_bakiye.MaxLength = 10;
            this.Musteri_bakiye.Multiline = true;
            this.Musteri_bakiye.Name = "Musteri_bakiye";
            this.Musteri_bakiye.Size = new System.Drawing.Size(153, 33);
            this.Musteri_bakiye.TabIndex = 6;
            this.Musteri_bakiye.Text = "0";
            this.Musteri_bakiye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Musteri_bakiye_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Müşteri Bakiyesi";
            // 
            // ButonidyeGoreGuncelleme
            // 
            this.ButonidyeGoreGuncelleme.Image = global::By_Tayo.Properties.Resources.tik32;
            this.ButonidyeGoreGuncelleme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButonidyeGoreGuncelleme.Location = new System.Drawing.Point(341, 229);
            this.ButonidyeGoreGuncelleme.Name = "ButonidyeGoreGuncelleme";
            this.ButonidyeGoreGuncelleme.Size = new System.Drawing.Size(131, 39);
            this.ButonidyeGoreGuncelleme.TabIndex = 7;
            this.ButonidyeGoreGuncelleme.Text = "Müşteriyi Güncelle";
            this.ButonidyeGoreGuncelleme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButonidyeGoreGuncelleme.UseVisualStyleBackColor = true;
            this.ButonidyeGoreGuncelleme.Click += new System.EventHandler(this.ButonidyeGoreGuncelleme_Click);
            // 
            // Musteri_kategori
            // 
            this.Musteri_kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Musteri_kategori.FormattingEnabled = true;
            this.Musteri_kategori.Location = new System.Drawing.Point(332, 184);
            this.Musteri_kategori.Name = "Musteri_kategori";
            this.Musteri_kategori.Size = new System.Drawing.Size(179, 21);
            this.Musteri_kategori.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(250, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Kategori:";
            // 
            // MusAdresi
            // 
            this.MusAdresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusAdresi.Location = new System.Drawing.Point(360, 45);
            this.MusAdresi.MaxLength = 250;
            this.MusAdresi.Multiline = true;
            this.MusAdresi.Name = "MusAdresi";
            this.MusAdresi.Size = new System.Drawing.Size(180, 70);
            this.MusAdresi.TabIndex = 3;
            // 
            // MusSoyadi
            // 
            this.MusSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusSoyadi.Location = new System.Drawing.Point(76, 108);
            this.MusSoyadi.MaxLength = 50;
            this.MusSoyadi.Name = "MusSoyadi";
            this.MusSoyadi.Size = new System.Drawing.Size(180, 22);
            this.MusSoyadi.TabIndex = 2;
            // 
            // MusAdi
            // 
            this.MusAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusAdi.Location = new System.Drawing.Point(76, 66);
            this.MusAdi.MaxLength = 50;
            this.MusAdi.Name = "MusAdi";
            this.MusAdi.Size = new System.Drawing.Size(180, 22);
            this.MusAdi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(279, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Telefonu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(292, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Adresi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Adı:";
            // 
            // MusteriGuncelle
            // 
            this.AcceptButton = this.ButonidyeGoreGuncelleme;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 310);
            this.Controls.Add(this.idyeGoreGrup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(602, 349);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(602, 349);
            this.Name = "MusteriGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Güncelleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MusteriGuncelle_FormClosing);
            this.Load += new System.EventHandler(this.MusteriGuncelle_Load);
            this.idyeGoreGrup.ResumeLayout(false);
            this.idyeGoreGrup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox idyeGoreGrup;
        private System.Windows.Forms.Button ButonidyeGoreGuncelleme;
        private System.Windows.Forms.ComboBox Musteri_kategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MusAdresi;
        private System.Windows.Forms.TextBox MusSoyadi;
        private System.Windows.Forms.TextBox MusAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Musteri_bakiye;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MusTelefonu;
        private System.Windows.Forms.PictureBox katekle;




    }
}