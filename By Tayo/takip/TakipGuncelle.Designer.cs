namespace By_Tayo
{
    partial class TakipGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakipGuncelle));
            this.grup4 = new System.Windows.Forms.GroupBox();
            this.AraButton = new System.Windows.Forms.Button();
            this.AramaText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SeriNo = new System.Windows.Forms.RadioButton();
            this.İmeiNo = new System.Windows.Forms.RadioButton();
            this.AdveSoyad = new System.Windows.Forms.RadioButton();
            this.TkpNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.grup2 = new System.Windows.Forms.GroupBox();
            this.cihazlar = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grup3 = new System.Windows.Forms.GroupBox();
            this.grup5 = new System.Windows.Forms.GroupBox();
            this.Guncelle = new System.Windows.Forms.Button();
            this.tkpKapat = new System.Windows.Forms.CheckBox();
            this.guncelleme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mustel = new System.Windows.Forms.MaskedTextBox();
            this.musadsoyad = new System.Windows.Forms.TextBox();
            this.cihazbilgi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.islemler = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grup4.SuspendLayout();
            this.grup2.SuspendLayout();
            this.grup3.SuspendLayout();
            this.grup5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grup4
            // 
            this.grup4.Controls.Add(this.AraButton);
            this.grup4.Controls.Add(this.AramaText);
            this.grup4.Controls.Add(this.label2);
            this.grup4.Controls.Add(this.SeriNo);
            this.grup4.Controls.Add(this.İmeiNo);
            this.grup4.Controls.Add(this.AdveSoyad);
            this.grup4.Controls.Add(this.TkpNo);
            this.grup4.Controls.Add(this.label1);
            this.grup4.Location = new System.Drawing.Point(3, 3);
            this.grup4.Name = "grup4";
            this.grup4.Size = new System.Drawing.Size(294, 149);
            this.grup4.TabIndex = 0;
            this.grup4.TabStop = false;
            this.grup4.Text = "Takip Arama";
            // 
            // AraButton
            // 
            this.AraButton.Location = new System.Drawing.Point(89, 108);
            this.AraButton.Name = "AraButton";
            this.AraButton.Size = new System.Drawing.Size(78, 35);
            this.AraButton.TabIndex = 7;
            this.AraButton.Text = "Ara";
            this.AraButton.UseVisualStyleBackColor = true;
            this.AraButton.Click += new System.EventHandler(this.AraButton_Click);
            // 
            // AramaText
            // 
            this.AramaText.Location = new System.Drawing.Point(89, 81);
            this.AramaText.MaxLength = 100;
            this.AramaText.Name = "AramaText";
            this.AramaText.Size = new System.Drawing.Size(191, 20);
            this.AramaText.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giriş yapınız -->";
            // 
            // SeriNo
            // 
            this.SeriNo.AutoSize = true;
            this.SeriNo.Location = new System.Drawing.Point(194, 47);
            this.SeriNo.Name = "SeriNo";
            this.SeriNo.Size = new System.Drawing.Size(60, 17);
            this.SeriNo.TabIndex = 4;
            this.SeriNo.TabStop = true;
            this.SeriNo.Text = "Seri No";
            this.SeriNo.UseVisualStyleBackColor = true;
            // 
            // İmeiNo
            // 
            this.İmeiNo.AutoSize = true;
            this.İmeiNo.Location = new System.Drawing.Point(89, 47);
            this.İmeiNo.Name = "İmeiNo";
            this.İmeiNo.Size = new System.Drawing.Size(91, 17);
            this.İmeiNo.TabIndex = 3;
            this.İmeiNo.TabStop = true;
            this.İmeiNo.Text = "İmei Numarası";
            this.İmeiNo.UseVisualStyleBackColor = true;
            // 
            // AdveSoyad
            // 
            this.AdveSoyad.AutoSize = true;
            this.AdveSoyad.Location = new System.Drawing.Point(194, 24);
            this.AdveSoyad.Name = "AdveSoyad";
            this.AdveSoyad.Size = new System.Drawing.Size(86, 17);
            this.AdveSoyad.TabIndex = 2;
            this.AdveSoyad.TabStop = true;
            this.AdveSoyad.Text = "Ad ve Soyad";
            this.AdveSoyad.UseVisualStyleBackColor = true;
            // 
            // TkpNo
            // 
            this.TkpNo.AutoSize = true;
            this.TkpNo.Location = new System.Drawing.Point(89, 24);
            this.TkpNo.Name = "TkpNo";
            this.TkpNo.Size = new System.Drawing.Size(99, 17);
            this.TkpNo.TabIndex = 1;
            this.TkpNo.TabStop = true;
            this.TkpNo.Text = "Takip Numarası";
            this.TkpNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Türü:";
            // 
            // grup2
            // 
            this.grup2.Controls.Add(this.cihazlar);
            this.grup2.Controls.Add(this.label3);
            this.grup2.Enabled = false;
            this.grup2.Location = new System.Drawing.Point(303, 5);
            this.grup2.Name = "grup2";
            this.grup2.Size = new System.Drawing.Size(294, 147);
            this.grup2.TabIndex = 1;
            this.grup2.TabStop = false;
            this.grup2.Text = "Bulunan Cihaz(lar)";
            // 
            // cihazlar
            // 
            this.cihazlar.FormattingEnabled = true;
            this.cihazlar.Location = new System.Drawing.Point(104, 17);
            this.cihazlar.Name = "cihazlar";
            this.cihazlar.Size = new System.Drawing.Size(177, 121);
            this.cihazlar.TabIndex = 1;
            this.cihazlar.SelectedIndexChanged += new System.EventHandler(this.cihazlar_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cihaz Seçiniz -->";
            // 
            // grup3
            // 
            this.grup3.Controls.Add(this.grup5);
            this.grup3.Controls.Add(this.groupBox1);
            this.grup3.Controls.Add(this.islemler);
            this.grup3.Controls.Add(this.label4);
            this.grup3.Enabled = false;
            this.grup3.Location = new System.Drawing.Point(3, 158);
            this.grup3.Name = "grup3";
            this.grup3.Size = new System.Drawing.Size(594, 225);
            this.grup3.TabIndex = 2;
            this.grup3.TabStop = false;
            this.grup3.Text = "Takip Güncelleme";
            // 
            // grup5
            // 
            this.grup5.Controls.Add(this.Guncelle);
            this.grup5.Controls.Add(this.tkpKapat);
            this.grup5.Controls.Add(this.guncelleme);
            this.grup5.Controls.Add(this.label5);
            this.grup5.Location = new System.Drawing.Point(300, 115);
            this.grup5.Name = "grup5";
            this.grup5.Size = new System.Drawing.Size(281, 104);
            this.grup5.TabIndex = 7;
            this.grup5.TabStop = false;
            this.grup5.Text = "Güncelleme";
            // 
            // Guncelle
            // 
            this.Guncelle.Image = global::By_Tayo.Properties.Resources.tik32;
            this.Guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guncelle.Location = new System.Drawing.Point(179, 64);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(94, 37);
            this.Guncelle.TabIndex = 5;
            this.Guncelle.Text = "Güncelle ";
            this.Guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // tkpKapat
            // 
            this.tkpKapat.AutoSize = true;
            this.tkpKapat.Location = new System.Drawing.Point(49, 75);
            this.tkpKapat.Name = "tkpKapat";
            this.tkpKapat.Size = new System.Drawing.Size(94, 17);
            this.tkpKapat.TabIndex = 4;
            this.tkpKapat.Text = "Takibi Kapatın";
            this.tkpKapat.UseVisualStyleBackColor = true;
            // 
            // guncelleme
            // 
            this.guncelleme.Location = new System.Drawing.Point(16, 26);
            this.guncelleme.Multiline = true;
            this.guncelleme.Name = "guncelleme";
            this.guncelleme.Size = new System.Drawing.Size(257, 32);
            this.guncelleme.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(101, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Güncelleme Ekle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mustel);
            this.groupBox1.Controls.Add(this.musadsoyad);
            this.groupBox1.Controls.Add(this.cihazbilgi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(300, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cihaz ve Müşteri Bilgi";
            // 
            // mustel
            // 
            this.mustel.Enabled = false;
            this.mustel.Location = new System.Drawing.Point(106, 71);
            this.mustel.Mask = "(999) 000-0000";
            this.mustel.Name = "mustel";
            this.mustel.Size = new System.Drawing.Size(153, 20);
            this.mustel.TabIndex = 10;
            // 
            // musadsoyad
            // 
            this.musadsoyad.Enabled = false;
            this.musadsoyad.Location = new System.Drawing.Point(106, 46);
            this.musadsoyad.Name = "musadsoyad";
            this.musadsoyad.Size = new System.Drawing.Size(153, 20);
            this.musadsoyad.TabIndex = 9;
            // 
            // cihazbilgi
            // 
            this.cihazbilgi.Enabled = false;
            this.cihazbilgi.Location = new System.Drawing.Point(106, 19);
            this.cihazbilgi.Name = "cihazbilgi";
            this.cihazbilgi.Size = new System.Drawing.Size(153, 20);
            this.cihazbilgi.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Müşteri Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Müşteri Ad Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cihaz Bilgileri:";
            // 
            // islemler
            // 
            this.islemler.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemler.FormattingEnabled = true;
            this.islemler.ItemHeight = 16;
            this.islemler.Location = new System.Drawing.Point(7, 60);
            this.islemler.Name = "islemler";
            this.islemler.Size = new System.Drawing.Size(287, 148);
            this.islemler.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cihazla ilgili yapılan işlemler";
            // 
            // TakipGuncelle
            // 
            this.AcceptButton = this.AraButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 389);
            this.Controls.Add(this.grup3);
            this.Controls.Add(this.grup2);
            this.Controls.Add(this.grup4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(617, 428);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(617, 428);
            this.Name = "TakipGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takip Güncelleme";
            this.grup4.ResumeLayout(false);
            this.grup4.PerformLayout();
            this.grup2.ResumeLayout(false);
            this.grup2.PerformLayout();
            this.grup3.ResumeLayout(false);
            this.grup3.PerformLayout();
            this.grup5.ResumeLayout(false);
            this.grup5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grup4;
        private System.Windows.Forms.RadioButton AdveSoyad;
        private System.Windows.Forms.RadioButton TkpNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AraButton;
        private System.Windows.Forms.TextBox AramaText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton SeriNo;
        private System.Windows.Forms.RadioButton İmeiNo;
        private System.Windows.Forms.GroupBox grup2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grup3;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.CheckBox tkpKapat;
        private System.Windows.Forms.TextBox guncelleme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox islemler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox musadsoyad;
        private System.Windows.Forms.TextBox cihazbilgi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grup5;
        private System.Windows.Forms.ListBox cihazlar;
        public System.Windows.Forms.MaskedTextBox mustel;
    }
}