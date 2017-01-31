namespace By_Tayo
{
    partial class MusteriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkle));
            this.Musteri_kategori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MusAdresi = new System.Windows.Forms.TextBox();
            this.MusSoyadi = new System.Windows.Forms.TextBox();
            this.MusAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.katekle = new System.Windows.Forms.PictureBox();
            this.MusTelefonu = new System.Windows.Forms.MaskedTextBox();
            this.ButonEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).BeginInit();
            this.SuspendLayout();
            // 
            // Musteri_kategori
            // 
            this.Musteri_kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Musteri_kategori.FormattingEnabled = true;
            this.Musteri_kategori.Location = new System.Drawing.Point(245, 178);
            this.Musteri_kategori.Name = "Musteri_kategori";
            this.Musteri_kategori.Size = new System.Drawing.Size(179, 21);
            this.Musteri_kategori.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(163, 176);
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
            this.MusSoyadi.Location = new System.Drawing.Point(78, 93);
            this.MusSoyadi.MaxLength = 50;
            this.MusSoyadi.Name = "MusSoyadi";
            this.MusSoyadi.Size = new System.Drawing.Size(180, 22);
            this.MusSoyadi.TabIndex = 2;
            // 
            // MusAdi
            // 
            this.MusAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MusAdi.Location = new System.Drawing.Point(78, 51);
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
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.katekle);
            this.groupBox1.Controls.Add(this.MusTelefonu);
            this.groupBox1.Controls.Add(this.ButonEkle);
            this.groupBox1.Controls.Add(this.Musteri_kategori);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.MusAdresi);
            this.groupBox1.Controls.Add(this.MusSoyadi);
            this.groupBox1.Controls.Add(this.MusAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 287);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Ekle  ";
            // 
            // katekle
            // 
            this.katekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.katekle.Image = global::By_Tayo.Properties.Resources.kategori;
            this.katekle.Location = new System.Drawing.Point(441, 173);
            this.katekle.Name = "katekle";
            this.katekle.Size = new System.Drawing.Size(32, 32);
            this.katekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.katekle.TabIndex = 33;
            this.katekle.TabStop = false;
            this.katekle.Tag = "Müşteri Kategorisi Ekle";
            this.katekle.Click += new System.EventHandler(this.katekle_Click);
            // 
            // MusTelefonu
            // 
            this.MusTelefonu.Location = new System.Drawing.Point(361, 120);
            this.MusTelefonu.Mask = "(999) 000-0000";
            this.MusTelefonu.Name = "MusTelefonu";
            this.MusTelefonu.Size = new System.Drawing.Size(179, 20);
            this.MusTelefonu.TabIndex = 4;
            // 
            // ButonEkle
            // 
            this.ButonEkle.Image = global::By_Tayo.Properties.Resources.ekle;
            this.ButonEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButonEkle.Location = new System.Drawing.Point(236, 223);
            this.ButonEkle.Name = "ButonEkle";
            this.ButonEkle.Size = new System.Drawing.Size(127, 39);
            this.ButonEkle.TabIndex = 6;
            this.ButonEkle.Text = "Müşteri Ekle    ";
            this.ButonEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButonEkle.UseVisualStyleBackColor = true;
            this.ButonEkle.Click += new System.EventHandler(this.ButonEkle_Click);
            // 
            // MusteriEkle
            // 
            this.AcceptButton = this.ButonEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 304);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(598, 343);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(598, 343);
            this.Name = "MusteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.MusteriEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Musteri_kategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MusAdresi;
        private System.Windows.Forms.TextBox MusSoyadi;
        private System.Windows.Forms.TextBox MusAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButonEkle;
        private System.Windows.Forms.MaskedTextBox MusTelefonu;
        private System.Windows.Forms.PictureBox katekle;

    }
}