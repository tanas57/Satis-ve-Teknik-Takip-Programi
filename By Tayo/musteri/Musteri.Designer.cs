namespace By_Tayo
{
    partial class Musteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteri));
            this.label2 = new System.Windows.Forms.Label();
            this.Musteri_adsoyad = new System.Windows.Forms.TextBox();
            this.KaraListe = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tarih1 = new System.Windows.Forms.DateTimePicker();
            this.Tarih2 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DataId = new System.Windows.Forms.TextBox();
            this.Listele = new System.Windows.Forms.Button();
            this.Detay = new System.Windows.Forms.Button();
            this.MusteriSil = new System.Windows.Forms.Button();
            this.MusteriGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // Musteri_adsoyad
            // 
            this.Musteri_adsoyad.Location = new System.Drawing.Point(73, 30);
            this.Musteri_adsoyad.MaxLength = 100;
            this.Musteri_adsoyad.Name = "Musteri_adsoyad";
            this.Musteri_adsoyad.Size = new System.Drawing.Size(222, 20);
            this.Musteri_adsoyad.TabIndex = 21;
            this.Musteri_adsoyad.TextChanged += new System.EventHandler(this.Musteri_adsoyad_TextChanged);
            // 
            // KaraListe
            // 
            this.KaraListe.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KaraListe.FormattingEnabled = true;
            this.KaraListe.ItemHeight = 16;
            this.KaraListe.Location = new System.Drawing.Point(6, 30);
            this.KaraListe.Name = "KaraListe";
            this.KaraListe.Size = new System.Drawing.Size(214, 84);
            this.KaraListe.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kayıt Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 198);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Tarih1
            // 
            this.Tarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tarih1.Location = new System.Drawing.Point(73, 66);
            this.Tarih1.Name = "Tarih1";
            this.Tarih1.Size = new System.Drawing.Size(92, 20);
            this.Tarih1.TabIndex = 2;
            this.Tarih1.ValueChanged += new System.EventHandler(this.Tarih1_ValueChanged);
            // 
            // Tarih2
            // 
            this.Tarih2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tarih2.Location = new System.Drawing.Point(187, 66);
            this.Tarih2.Name = "Tarih2";
            this.Tarih2.Size = new System.Drawing.Size(91, 20);
            this.Tarih2.TabIndex = 3;
            this.Tarih2.ValueChanged += new System.EventHandler(this.Tarih2_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(285, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Aktif";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DataId
            // 
            this.DataId.Location = new System.Drawing.Point(590, 166);
            this.DataId.Name = "DataId";
            this.DataId.Size = new System.Drawing.Size(32, 20);
            this.DataId.TabIndex = 8;
            this.DataId.Text = "0";
            this.DataId.Visible = false;
            this.DataId.TextChanged += new System.EventHandler(this.DataId_TextChanged);
            // 
            // Listele
            // 
            this.Listele.Image = global::By_Tayo.Properties.Resources.ara;
            this.Listele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Listele.Location = new System.Drawing.Point(132, 90);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(85, 35);
            this.Listele.TabIndex = 5;
            this.Listele.Text = "Listele";
            this.Listele.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Listele.UseVisualStyleBackColor = true;
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // Detay
            // 
            this.Detay.Image = global::By_Tayo.Properties.Resources.bilgi32;
            this.Detay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Detay.Location = new System.Drawing.Point(226, 55);
            this.Detay.Name = "Detay";
            this.Detay.Size = new System.Drawing.Size(76, 41);
            this.Detay.TabIndex = 7;
            this.Detay.Text = "Detay";
            this.Detay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Detay.UseVisualStyleBackColor = true;
            this.Detay.Click += new System.EventHandler(this.Detay_Click);
            // 
            // MusteriSil
            // 
            this.MusteriSil.Image = global::By_Tayo.Properties.Resources.carpi32;
            this.MusteriSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MusteriSil.Location = new System.Drawing.Point(569, 251);
            this.MusteriSil.Name = "MusteriSil";
            this.MusteriSil.Size = new System.Drawing.Size(82, 40);
            this.MusteriSil.TabIndex = 10;
            this.MusteriSil.Text = "     Sil";
            this.MusteriSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MusteriSil.UseVisualStyleBackColor = true;
            this.MusteriSil.Click += new System.EventHandler(this.MusteriSil_Click);
            // 
            // MusteriGuncelle
            // 
            this.MusteriGuncelle.Image = global::By_Tayo.Properties.Resources.duzenle;
            this.MusteriGuncelle.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.MusteriGuncelle.Location = new System.Drawing.Point(569, 192);
            this.MusteriGuncelle.Name = "MusteriGuncelle";
            this.MusteriGuncelle.Size = new System.Drawing.Size(82, 40);
            this.MusteriGuncelle.TabIndex = 9;
            this.MusteriGuncelle.Text = "Güncelle";
            this.MusteriGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MusteriGuncelle.UseVisualStyleBackColor = true;
            this.MusteriGuncelle.Click += new System.EventHandler(this.MusteriGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tarih2);
            this.groupBox1.Controls.Add(this.Tarih1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Listele);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.Musteri_adsoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 134);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Arama";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Detay);
            this.groupBox2.Controls.Add(this.KaraListe);
            this.groupBox2.Location = new System.Drawing.Point(353, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 133);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borçlu Müşteriler";
            // 
            // Musteri
            // 
            this.AcceptButton = this.Listele;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 340);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataId);
            this.Controls.Add(this.MusteriSil);
            this.Controls.Add(this.MusteriGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(687, 379);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(687, 379);
            this.Name = "Musteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.Musteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Listele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MusteriGuncelle;
        private System.Windows.Forms.Button MusteriSil;
        public System.Windows.Forms.TextBox DataId;
        private System.Windows.Forms.Button Detay;
        public System.Windows.Forms.TextBox Musteri_adsoyad;
        public System.Windows.Forms.ListBox KaraListe;
        public System.Windows.Forms.DateTimePicker Tarih1;
        public System.Windows.Forms.DateTimePicker Tarih2;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}