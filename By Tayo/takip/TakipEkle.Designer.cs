namespace By_Tayo
{
    partial class TakipEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakipEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cihaz = new System.Windows.Forms.GroupBox();
            this.imei = new System.Windows.Forms.MaskedTextBox();
            this.serino = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uyedegilse = new System.Windows.Forms.GroupBox();
            this.musTel = new System.Windows.Forms.MaskedTextBox();
            this.musadi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uyeyse = new System.Windows.Forms.GroupBox();
            this.musteriarama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.musteri = new System.Windows.Forms.ComboBox();
            this.uyeMi = new System.Windows.Forms.CheckBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.takipno = new System.Windows.Forms.TextBox();
            this.kopyala = new System.Windows.Forms.Button();
            this.cihaz.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.uyedegilse.SuspendLayout();
            this.uyeyse.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cihaz Markası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cihaz Modeli:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cihaz İMEİ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cihaz Seri No:";
            // 
            // cihaz
            // 
            this.cihaz.Controls.Add(this.imei);
            this.cihaz.Controls.Add(this.serino);
            this.cihaz.Controls.Add(this.model);
            this.cihaz.Controls.Add(this.marka);
            this.cihaz.Controls.Add(this.label1);
            this.cihaz.Controls.Add(this.label4);
            this.cihaz.Controls.Add(this.label2);
            this.cihaz.Controls.Add(this.label3);
            this.cihaz.Location = new System.Drawing.Point(299, 12);
            this.cihaz.Name = "cihaz";
            this.cihaz.Size = new System.Drawing.Size(283, 179);
            this.cihaz.TabIndex = 4;
            this.cihaz.TabStop = false;
            this.cihaz.Text = "Cihaz Bilgileri";
            // 
            // imei
            // 
            this.imei.Location = new System.Drawing.Point(89, 104);
            this.imei.Mask = "000000000000000";
            this.imei.Name = "imei";
            this.imei.Size = new System.Drawing.Size(177, 20);
            this.imei.TabIndex = 8;
            // 
            // serino
            // 
            this.serino.Location = new System.Drawing.Point(88, 141);
            this.serino.MaxLength = 100;
            this.serino.Name = "serino";
            this.serino.Size = new System.Drawing.Size(178, 20);
            this.serino.TabIndex = 9;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(89, 67);
            this.model.MaxLength = 150;
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(177, 20);
            this.model.TabIndex = 7;
            // 
            // marka
            // 
            this.marka.BackColor = System.Drawing.SystemColors.Window;
            this.marka.Location = new System.Drawing.Point(89, 34);
            this.marka.MaxLength = 150;
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(177, 20);
            this.marka.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uyedegilse);
            this.groupBox2.Controls.Add(this.uyeyse);
            this.groupBox2.Controls.Add(this.uyeMi);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 305);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgileri";
            // 
            // uyedegilse
            // 
            this.uyedegilse.Controls.Add(this.musTel);
            this.uyedegilse.Controls.Add(this.musadi);
            this.uyedegilse.Controls.Add(this.label8);
            this.uyedegilse.Controls.Add(this.label7);
            this.uyedegilse.Location = new System.Drawing.Point(7, 182);
            this.uyedegilse.Name = "uyedegilse";
            this.uyedegilse.Size = new System.Drawing.Size(268, 100);
            this.uyedegilse.TabIndex = 2;
            this.uyedegilse.TabStop = false;
            this.uyedegilse.Text = "Müşteri Bilgi Girişi";
            // 
            // musTel
            // 
            this.musTel.Location = new System.Drawing.Point(99, 64);
            this.musTel.Mask = "(999) 000-0000";
            this.musTel.Name = "musTel";
            this.musTel.Size = new System.Drawing.Size(163, 20);
            this.musTel.TabIndex = 5;
            // 
            // musadi
            // 
            this.musadi.Location = new System.Drawing.Point(99, 26);
            this.musadi.MaxLength = 100;
            this.musadi.Name = "musadi";
            this.musadi.Size = new System.Drawing.Size(163, 20);
            this.musadi.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Müşteri Telefonu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Müşteri Adı:";
            // 
            // uyeyse
            // 
            this.uyeyse.Controls.Add(this.musteriarama);
            this.uyeyse.Controls.Add(this.label6);
            this.uyeyse.Controls.Add(this.label5);
            this.uyeyse.Controls.Add(this.musteri);
            this.uyeyse.Enabled = false;
            this.uyeyse.Location = new System.Drawing.Point(7, 53);
            this.uyeyse.Name = "uyeyse";
            this.uyeyse.Size = new System.Drawing.Size(268, 123);
            this.uyeyse.TabIndex = 1;
            this.uyeyse.TabStop = false;
            this.uyeyse.Text = "Müşteri Seçimi";
            // 
            // musteriarama
            // 
            this.musteriarama.Location = new System.Drawing.Point(89, 27);
            this.musteriarama.MaxLength = 100;
            this.musteriarama.Name = "musteriarama";
            this.musteriarama.Size = new System.Drawing.Size(147, 20);
            this.musteriarama.TabIndex = 2;
            this.musteriarama.TextChanged += new System.EventHandler(this.musteriarama_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Müşteri Arama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Müşteri Seçiniz";
            // 
            // musteri
            // 
            this.musteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.musteri.FormattingEnabled = true;
            this.musteri.Location = new System.Drawing.Point(39, 77);
            this.musteri.Name = "musteri";
            this.musteri.Size = new System.Drawing.Size(197, 21);
            this.musteri.TabIndex = 3;
            // 
            // uyeMi
            // 
            this.uyeMi.AutoSize = true;
            this.uyeMi.Location = new System.Drawing.Point(79, 27);
            this.uyeMi.Name = "uyeMi";
            this.uyeMi.Size = new System.Drawing.Size(102, 17);
            this.uyeMi.TabIndex = 0;
            this.uyeMi.Text = "Müşteri üye mi ?";
            this.uyeMi.UseVisualStyleBackColor = true;
            this.uyeMi.CheckedChanged += new System.EventHandler(this.uyeMi_CheckedChanged);
            // 
            // Ekle
            // 
            this.Ekle.Image = global::By_Tayo.Properties.Resources.tik32;
            this.Ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ekle.Location = new System.Drawing.Point(215, 321);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(149, 43);
            this.Ekle.TabIndex = 11;
            this.Ekle.Text = "Teknik Takip Ekle    ";
            this.Ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Takip Numarası";
            // 
            // takipno
            // 
            this.takipno.Enabled = false;
            this.takipno.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takipno.ForeColor = System.Drawing.Color.Red;
            this.takipno.Location = new System.Drawing.Point(314, 237);
            this.takipno.Multiline = true;
            this.takipno.Name = "takipno";
            this.takipno.Size = new System.Drawing.Size(204, 49);
            this.takipno.TabIndex = 10;
            this.takipno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.takipno.TextChanged += new System.EventHandler(this.takipno_TextChanged);
            this.takipno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.takipno_KeyPress);
            // 
            // kopyala
            // 
            this.kopyala.Location = new System.Drawing.Point(523, 237);
            this.kopyala.Name = "kopyala";
            this.kopyala.Size = new System.Drawing.Size(59, 49);
            this.kopyala.TabIndex = 12;
            this.kopyala.Text = "Kodu Kopyala";
            this.kopyala.UseVisualStyleBackColor = true;
            this.kopyala.Click += new System.EventHandler(this.kopyala_Click);
            // 
            // TakipEkle
            // 
            this.AcceptButton = this.Ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.kopyala);
            this.Controls.Add(this.takipno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cihaz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(608, 412);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(608, 412);
            this.Name = "TakipEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teknik Takip Ekleme";
            this.Load += new System.EventHandler(this.TakipEkle_Load);
            this.cihaz.ResumeLayout(false);
            this.cihaz.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.uyedegilse.ResumeLayout(false);
            this.uyedegilse.PerformLayout();
            this.uyeyse.ResumeLayout(false);
            this.uyeyse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox cihaz;
        private System.Windows.Forms.TextBox serino;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox uyedegilse;
        private System.Windows.Forms.TextBox musadi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox uyeyse;
        private System.Windows.Forms.TextBox musteriarama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox musteri;
        private System.Windows.Forms.CheckBox uyeMi;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox takipno;
        private System.Windows.Forms.MaskedTextBox musTel;
        private System.Windows.Forms.MaskedTextBox imei;
        private System.Windows.Forms.Button kopyala;
    }
}