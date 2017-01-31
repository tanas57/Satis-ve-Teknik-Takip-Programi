namespace By_Tayo
{
    partial class MusteriGuncelle2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGuncelle2));
            this.idyeGoreGrup = new System.Windows.Forms.GroupBox();
            this.MusteriBilgiGrup = new System.Windows.Forms.GroupBox();
            this.katekle = new System.Windows.Forms.PictureBox();
            this.Musteri_telefonu = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButonAramayaGoreGuncelle = new System.Windows.Forms.Button();
            this.Musteri_bakiye = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Musteri_kategori = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Musteri_adresi = new System.Windows.Forms.TextBox();
            this.Musteri_soyadi = new System.Windows.Forms.TextBox();
            this.Musteri_adi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Musteri_adi_combo = new System.Windows.Forms.ComboBox();
            this.AramaMusteriAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idyeGoreGrup.SuspendLayout();
            this.MusteriBilgiGrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idyeGoreGrup
            // 
            this.idyeGoreGrup.Controls.Add(this.MusteriBilgiGrup);
            this.idyeGoreGrup.Controls.Add(this.groupBox2);
            this.idyeGoreGrup.Location = new System.Drawing.Point(11, 12);
            this.idyeGoreGrup.Name = "idyeGoreGrup";
            this.idyeGoreGrup.Size = new System.Drawing.Size(571, 295);
            this.idyeGoreGrup.TabIndex = 33;
            this.idyeGoreGrup.TabStop = false;
            this.idyeGoreGrup.Text = "Müşteri Güncelleme";
            // 
            // MusteriBilgiGrup
            // 
            this.MusteriBilgiGrup.Controls.Add(this.katekle);
            this.MusteriBilgiGrup.Controls.Add(this.Musteri_telefonu);
            this.MusteriBilgiGrup.Controls.Add(this.label3);
            this.MusteriBilgiGrup.Controls.Add(this.ButonAramayaGoreGuncelle);
            this.MusteriBilgiGrup.Controls.Add(this.Musteri_bakiye);
            this.MusteriBilgiGrup.Controls.Add(this.label4);
            this.MusteriBilgiGrup.Controls.Add(this.Musteri_kategori);
            this.MusteriBilgiGrup.Controls.Add(this.label6);
            this.MusteriBilgiGrup.Controls.Add(this.Musteri_adresi);
            this.MusteriBilgiGrup.Controls.Add(this.Musteri_soyadi);
            this.MusteriBilgiGrup.Controls.Add(this.Musteri_adi);
            this.MusteriBilgiGrup.Controls.Add(this.label7);
            this.MusteriBilgiGrup.Controls.Add(this.label8);
            this.MusteriBilgiGrup.Controls.Add(this.label9);
            this.MusteriBilgiGrup.Controls.Add(this.label10);
            this.MusteriBilgiGrup.Enabled = false;
            this.MusteriBilgiGrup.Location = new System.Drawing.Point(4, 94);
            this.MusteriBilgiGrup.Name = "MusteriBilgiGrup";
            this.MusteriBilgiGrup.Size = new System.Drawing.Size(557, 191);
            this.MusteriBilgiGrup.TabIndex = 36;
            this.MusteriBilgiGrup.TabStop = false;
            this.MusteriBilgiGrup.Text = "Müşteri Bilgileri";
            // 
            // katekle
            // 
            this.katekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.katekle.Image = global::By_Tayo.Properties.Resources.kategori;
            this.katekle.Location = new System.Drawing.Point(453, 111);
            this.katekle.Name = "katekle";
            this.katekle.Size = new System.Drawing.Size(32, 32);
            this.katekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.katekle.TabIndex = 39;
            this.katekle.TabStop = false;
            this.katekle.Tag = "Müşteri Kategorisi Ekle";
            this.katekle.Click += new System.EventHandler(this.katekle_Click);
            // 
            // Musteri_telefonu
            // 
            this.Musteri_telefonu.Location = new System.Drawing.Point(354, 85);
            this.Musteri_telefonu.Mask = "(999) 000-0000";
            this.Musteri_telefonu.Name = "Musteri_telefonu";
            this.Musteri_telefonu.Size = new System.Drawing.Size(180, 20);
            this.Musteri_telefonu.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(9, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Müşterinin borcu bulunmaktadır.";
            this.label3.Visible = false;
            // 
            // ButonAramayaGoreGuncelle
            // 
            this.ButonAramayaGoreGuncelle.Image = global::By_Tayo.Properties.Resources.tik32;
            this.ButonAramayaGoreGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButonAramayaGoreGuncelle.Location = new System.Drawing.Point(259, 146);
            this.ButonAramayaGoreGuncelle.Name = "ButonAramayaGoreGuncelle";
            this.ButonAramayaGoreGuncelle.Size = new System.Drawing.Size(127, 39);
            this.ButonAramayaGoreGuncelle.TabIndex = 31;
            this.ButonAramayaGoreGuncelle.Text = "Müşteyi Güncelle";
            this.ButonAramayaGoreGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButonAramayaGoreGuncelle.UseVisualStyleBackColor = true;
            this.ButonAramayaGoreGuncelle.Click += new System.EventHandler(this.ButonAramayaGoreGuncelle_Click);
            // 
            // Musteri_bakiye
            // 
            this.Musteri_bakiye.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Musteri_bakiye.Location = new System.Drawing.Point(12, 120);
            this.Musteri_bakiye.MaxLength = 10;
            this.Musteri_bakiye.Multiline = true;
            this.Musteri_bakiye.Name = "Musteri_bakiye";
            this.Musteri_bakiye.Size = new System.Drawing.Size(153, 33);
            this.Musteri_bakiye.TabIndex = 36;
            this.Musteri_bakiye.Text = "0";
            this.Musteri_bakiye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Musteri_bakiye_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Müşteri Bakiyesi";
            // 
            // Musteri_kategori
            // 
            this.Musteri_kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Musteri_kategori.FormattingEnabled = true;
            this.Musteri_kategori.Location = new System.Drawing.Point(268, 119);
            this.Musteri_kategori.Name = "Musteri_kategori";
            this.Musteri_kategori.Size = new System.Drawing.Size(179, 21);
            this.Musteri_kategori.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(186, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Kategori:";
            // 
            // Musteri_adresi
            // 
            this.Musteri_adresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Musteri_adresi.Location = new System.Drawing.Point(354, 9);
            this.Musteri_adresi.MaxLength = 250;
            this.Musteri_adresi.Multiline = true;
            this.Musteri_adresi.Name = "Musteri_adresi";
            this.Musteri_adresi.Size = new System.Drawing.Size(180, 70);
            this.Musteri_adresi.TabIndex = 27;
            // 
            // Musteri_soyadi
            // 
            this.Musteri_soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Musteri_soyadi.Location = new System.Drawing.Point(75, 72);
            this.Musteri_soyadi.MaxLength = 50;
            this.Musteri_soyadi.Name = "Musteri_soyadi";
            this.Musteri_soyadi.Size = new System.Drawing.Size(180, 22);
            this.Musteri_soyadi.TabIndex = 26;
            // 
            // Musteri_adi
            // 
            this.Musteri_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Musteri_adi.Location = new System.Drawing.Point(75, 30);
            this.Musteri_adi.MaxLength = 50;
            this.Musteri_adi.Name = "Musteri_adi";
            this.Musteri_adi.Size = new System.Drawing.Size(180, 22);
            this.Musteri_adi.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(273, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Telefonu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(286, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Adresi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(4, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Soyadı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(29, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Musteri_adi_combo);
            this.groupBox2.Controls.Add(this.AramaMusteriAdi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 70);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Arama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Müşteriyi seçin ->";
            // 
            // Musteri_adi_combo
            // 
            this.Musteri_adi_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Musteri_adi_combo.Enabled = false;
            this.Musteri_adi_combo.FormattingEnabled = true;
            this.Musteri_adi_combo.Location = new System.Drawing.Point(352, 27);
            this.Musteri_adi_combo.Name = "Musteri_adi_combo";
            this.Musteri_adi_combo.Size = new System.Drawing.Size(180, 21);
            this.Musteri_adi_combo.TabIndex = 36;
            this.Musteri_adi_combo.SelectedIndexChanged += new System.EventHandler(this.Musteri_adi_combo_SelectedIndexChanged);
            // 
            // AramaMusteriAdi
            // 
            this.AramaMusteriAdi.Location = new System.Drawing.Point(81, 30);
            this.AramaMusteriAdi.MaxLength = 100;
            this.AramaMusteriAdi.Name = "AramaMusteriAdi";
            this.AramaMusteriAdi.Size = new System.Drawing.Size(148, 20);
            this.AramaMusteriAdi.TabIndex = 35;
            this.AramaMusteriAdi.TextChanged += new System.EventHandler(this.AramaMusteriAdi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Müşteri Adı\r\nveya Soyadı:";
            // 
            // MusteriGuncelle2
            // 
            this.AcceptButton = this.ButonAramayaGoreGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 311);
            this.Controls.Add(this.idyeGoreGrup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusteriGuncelle2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Güncelle";
            this.Load += new System.EventHandler(this.MusteriGuncelle2_Load);
            this.idyeGoreGrup.ResumeLayout(false);
            this.MusteriBilgiGrup.ResumeLayout(false);
            this.MusteriBilgiGrup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox idyeGoreGrup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox MusteriBilgiGrup;
        private System.Windows.Forms.Button ButonAramayaGoreGuncelle;
        private System.Windows.Forms.ComboBox Musteri_kategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Musteri_adresi;
        private System.Windows.Forms.TextBox Musteri_soyadi;
        private System.Windows.Forms.TextBox Musteri_adi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Musteri_adi_combo;
        private System.Windows.Forms.TextBox AramaMusteriAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Musteri_bakiye;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Musteri_telefonu;
        private System.Windows.Forms.PictureBox katekle;
    }
}