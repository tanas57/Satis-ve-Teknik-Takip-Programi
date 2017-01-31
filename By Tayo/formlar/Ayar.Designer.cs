namespace By_Tayo
{
    partial class Ayar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Guncellee = new System.Windows.Forms.Button();
            this.telefon = new System.Windows.Forms.MaskedTextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.unvan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.yeni_dizin = new System.Windows.Forms.TextBox();
            this.Guncelle = new System.Windows.Forms.Button();
            this.yedek_dizin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DizinAc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.otoBaslangic = new System.Windows.Forms.CheckBox();
            this.formukapat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Guncellee);
            this.groupBox1.Controls.Add(this.telefon);
            this.groupBox1.Controls.Add(this.adres);
            this.groupBox1.Controls.Add(this.unvan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firma Bilgileri";
            // 
            // Guncellee
            // 
            this.Guncellee.Location = new System.Drawing.Point(158, 142);
            this.Guncellee.Name = "Guncellee";
            this.Guncellee.Size = new System.Drawing.Size(75, 23);
            this.Guncellee.TabIndex = 4;
            this.Guncellee.Text = "Güncelle";
            this.Guncellee.UseVisualStyleBackColor = true;
            this.Guncellee.Click += new System.EventHandler(this.Guncellee_Click);
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(65, 116);
            this.telefon.Mask = "(999) 000-0000";
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(168, 20);
            this.telefon.TabIndex = 3;
            this.telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(65, 55);
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(168, 51);
            this.adres.TabIndex = 2;
            // 
            // unvan
            // 
            this.unvan.Location = new System.Drawing.Point(65, 25);
            this.unvan.Name = "unvan";
            this.unvan.Size = new System.Drawing.Size(168, 20);
            this.unvan.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefonu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adresi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ünvanı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.yeni_dizin);
            this.groupBox2.Controls.Add(this.Guncelle);
            this.groupBox2.Controls.Add(this.yedek_dizin);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.DizinAc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(256, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yedekleme Ayarları";
            // 
            // yeni_dizin
            // 
            this.yeni_dizin.Enabled = false;
            this.yeni_dizin.Location = new System.Drawing.Point(13, 86);
            this.yeni_dizin.Name = "yeni_dizin";
            this.yeni_dizin.Size = new System.Drawing.Size(274, 20);
            this.yeni_dizin.TabIndex = 9;
            this.yeni_dizin.Text = "0";
            this.yeni_dizin.Visible = false;
            // 
            // Guncelle
            // 
            this.Guncelle.Location = new System.Drawing.Point(168, 116);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(75, 23);
            this.Guncelle.TabIndex = 8;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // yedek_dizin
            // 
            this.yedek_dizin.Location = new System.Drawing.Point(87, 25);
            this.yedek_dizin.Name = "yedek_dizin";
            this.yedek_dizin.Size = new System.Drawing.Size(206, 20);
            this.yedek_dizin.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dizini güncelle:";
            // 
            // DizinAc
            // 
            this.DizinAc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DizinAc.Location = new System.Drawing.Point(87, 52);
            this.DizinAc.Name = "DizinAc";
            this.DizinAc.Size = new System.Drawing.Size(75, 23);
            this.DizinAc.TabIndex = 6;
            this.DizinAc.Text = "Dizini Aç";
            this.DizinAc.UseVisualStyleBackColor = true;
            this.DizinAc.Click += new System.EventHandler(this.DizinAc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yedek Dizininiz:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 76);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::By_Tayo.Properties.Resources.ayar;
            this.pictureBox1.Location = new System.Drawing.Point(13, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programsal ayarların yapdıldığı kısıma hoş geldiniz.\r\nFirma bilgilerini, program " +
                "açılış ayarları ve yedekleme ayarları\r\nbu kısımda bulunmaktadır.";
            // 
            // otoBaslangic
            // 
            this.otoBaslangic.AutoSize = true;
            this.otoBaslangic.Location = new System.Drawing.Point(148, 271);
            this.otoBaslangic.Name = "otoBaslangic";
            this.otoBaslangic.Size = new System.Drawing.Size(270, 17);
            this.otoBaslangic.TabIndex = 9;
            this.otoBaslangic.Text = "Bilgisayar başlangıcında program otomatik başlatılsın";
            this.otoBaslangic.UseVisualStyleBackColor = true;
            this.otoBaslangic.CheckedChanged += new System.EventHandler(this.otoBaslangic_CheckedChanged);
            // 
            // formukapat
            // 
            this.formukapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.formukapat.Location = new System.Drawing.Point(0, 0);
            this.formukapat.Name = "formukapat";
            this.formukapat.Size = new System.Drawing.Size(75, 23);
            this.formukapat.TabIndex = 3;
            this.formukapat.Text = "formukapat";
            this.formukapat.UseVisualStyleBackColor = true;
            this.formukapat.Visible = false;
            this.formukapat.Click += new System.EventHandler(this.formukapat_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Klasör Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.formukapat;
            this.ClientSize = new System.Drawing.Size(550, 310);
            this.Controls.Add(this.formukapat);
            this.Controls.Add(this.otoBaslangic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 349);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(566, 349);
            this.Name = "Ayar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox telefon;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox unvan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yedek_dizin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DizinAc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.TextBox yeni_dizin;
        private System.Windows.Forms.Button Guncellee;
        private System.Windows.Forms.CheckBox otoBaslangic;
        private System.Windows.Forms.Button formukapat;
        private System.Windows.Forms.Button button1;
    }
}