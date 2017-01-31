namespace By_Tayo
{
    partial class TkpGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TkpGuncelle));
            this.grup1 = new System.Windows.Forms.GroupBox();
            this.imei = new System.Windows.Forms.MaskedTextBox();
            this.CihazBGuncelle = new System.Windows.Forms.Button();
            this.serino = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adsoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MusteriBGuncelle = new System.Windows.Forms.Button();
            this.grup2 = new System.Windows.Forms.GroupBox();
            this.telefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grup1.SuspendLayout();
            this.grup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grup1
            // 
            this.grup1.Controls.Add(this.imei);
            this.grup1.Controls.Add(this.CihazBGuncelle);
            this.grup1.Controls.Add(this.serino);
            this.grup1.Controls.Add(this.model);
            this.grup1.Controls.Add(this.marka);
            this.grup1.Controls.Add(this.label4);
            this.grup1.Controls.Add(this.label3);
            this.grup1.Controls.Add(this.label2);
            this.grup1.Controls.Add(this.label1);
            this.grup1.Location = new System.Drawing.Point(12, 61);
            this.grup1.Name = "grup1";
            this.grup1.Size = new System.Drawing.Size(235, 191);
            this.grup1.TabIndex = 9;
            this.grup1.TabStop = false;
            this.grup1.Text = "Cihaz Bilgi";
            // 
            // imei
            // 
            this.imei.Location = new System.Drawing.Point(82, 85);
            this.imei.Mask = "000000000000000";
            this.imei.Name = "imei";
            this.imei.Size = new System.Drawing.Size(140, 20);
            this.imei.TabIndex = 9;
            // 
            // CihazBGuncelle
            // 
            this.CihazBGuncelle.Image = global::By_Tayo.Properties.Resources.tik32;
            this.CihazBGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CihazBGuncelle.Location = new System.Drawing.Point(82, 143);
            this.CihazBGuncelle.Name = "CihazBGuncelle";
            this.CihazBGuncelle.Size = new System.Drawing.Size(90, 42);
            this.CihazBGuncelle.TabIndex = 7;
            this.CihazBGuncelle.Text = "Güncelle";
            this.CihazBGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CihazBGuncelle.UseVisualStyleBackColor = true;
            this.CihazBGuncelle.Click += new System.EventHandler(this.CihazBGuncelle_Click);
            // 
            // serino
            // 
            this.serino.Location = new System.Drawing.Point(82, 111);
            this.serino.MaxLength = 100;
            this.serino.Name = "serino";
            this.serino.Size = new System.Drawing.Size(140, 20);
            this.serino.TabIndex = 6;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(82, 60);
            this.model.MaxLength = 150;
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(140, 20);
            this.model.TabIndex = 4;
            // 
            // marka
            // 
            this.marka.Location = new System.Drawing.Point(82, 33);
            this.marka.MaxLength = 150;
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(140, 20);
            this.marka.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cihaz SeriNo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cihaz İmei:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cihaz Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cihaz Marka:";
            // 
            // adsoyad
            // 
            this.adsoyad.Location = new System.Drawing.Point(109, 66);
            this.adsoyad.MaxLength = 100;
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(120, 20);
            this.adsoyad.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Müşteri Telefon:";
            // 
            // MusteriBGuncelle
            // 
            this.MusteriBGuncelle.Image = global::By_Tayo.Properties.Resources.tik32;
            this.MusteriBGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MusteriBGuncelle.Location = new System.Drawing.Point(109, 143);
            this.MusteriBGuncelle.Name = "MusteriBGuncelle";
            this.MusteriBGuncelle.Size = new System.Drawing.Size(90, 42);
            this.MusteriBGuncelle.TabIndex = 8;
            this.MusteriBGuncelle.Text = "Güncelle";
            this.MusteriBGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MusteriBGuncelle.UseVisualStyleBackColor = true;
            this.MusteriBGuncelle.Click += new System.EventHandler(this.MusteriBGuncelle_Click);
            // 
            // grup2
            // 
            this.grup2.Controls.Add(this.telefon);
            this.grup2.Controls.Add(this.MusteriBGuncelle);
            this.grup2.Controls.Add(this.adsoyad);
            this.grup2.Controls.Add(this.label6);
            this.grup2.Controls.Add(this.label5);
            this.grup2.Location = new System.Drawing.Point(253, 61);
            this.grup2.Name = "grup2";
            this.grup2.Size = new System.Drawing.Size(235, 191);
            this.grup2.TabIndex = 10;
            this.grup2.TabStop = false;
            this.grup2.Text = "Müşteri Bilgi";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(109, 98);
            this.telefon.Mask = "(999) 000-0000";
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(120, 20);
            this.telefon.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Müşteri Adı Soyadı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Takip Numarası:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(178, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "label8";
            // 
            // TkpGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 275);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grup1);
            this.Controls.Add(this.grup2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(516, 314);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(516, 314);
            this.Name = "TkpGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takip Güncelleme";
            this.Load += new System.EventHandler(this.TkpGuncelle_Load);
            this.grup1.ResumeLayout(false);
            this.grup1.PerformLayout();
            this.grup2.ResumeLayout(false);
            this.grup2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grup1;
        private System.Windows.Forms.Button CihazBGuncelle;
        public System.Windows.Forms.TextBox serino;
        public System.Windows.Forms.TextBox model;
        public System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox adsoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button MusteriBGuncelle;
        private System.Windows.Forms.GroupBox grup2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.MaskedTextBox imei;
        public System.Windows.Forms.MaskedTextBox telefon;
    }
}