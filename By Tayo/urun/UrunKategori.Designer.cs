namespace By_Tayo
{
    partial class UrunKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunKategori));
            this.DataId = new System.Windows.Forms.TextBox();
            this.KategoriSil = new System.Windows.Forms.Button();
            this.KategoriGuncelle = new System.Windows.Forms.Button();
            this.KategoriDataGrid = new System.Windows.Forms.DataGridView();
            this.Kategori_Adi = new System.Windows.Forms.TextBox();
            this.kategoriadi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.katekle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.KategoriDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).BeginInit();
            this.SuspendLayout();
            // 
            // DataId
            // 
            this.DataId.Location = new System.Drawing.Point(325, 96);
            this.DataId.Name = "DataId";
            this.DataId.Size = new System.Drawing.Size(32, 20);
            this.DataId.TabIndex = 32;
            this.DataId.Text = "0";
            this.DataId.Visible = false;
            // 
            // KategoriSil
            // 
            this.KategoriSil.Image = global::By_Tayo.Properties.Resources.carpi32;
            this.KategoriSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KategoriSil.Location = new System.Drawing.Point(312, 171);
            this.KategoriSil.Name = "KategoriSil";
            this.KategoriSil.Size = new System.Drawing.Size(90, 42);
            this.KategoriSil.TabIndex = 31;
            this.KategoriSil.Text = "    Sil";
            this.KategoriSil.UseVisualStyleBackColor = true;
            this.KategoriSil.Click += new System.EventHandler(this.KategoriSil_Click);
            // 
            // KategoriGuncelle
            // 
            this.KategoriGuncelle.Image = global::By_Tayo.Properties.Resources.tik32;
            this.KategoriGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KategoriGuncelle.Location = new System.Drawing.Point(312, 122);
            this.KategoriGuncelle.Name = "KategoriGuncelle";
            this.KategoriGuncelle.Size = new System.Drawing.Size(90, 43);
            this.KategoriGuncelle.TabIndex = 30;
            this.KategoriGuncelle.Text = "Güncelle";
            this.KategoriGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.KategoriGuncelle.UseVisualStyleBackColor = true;
            this.KategoriGuncelle.Click += new System.EventHandler(this.KategoriGuncelle_Click);
            // 
            // KategoriDataGrid
            // 
            this.KategoriDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KategoriDataGrid.Location = new System.Drawing.Point(8, 59);
            this.KategoriDataGrid.Name = "KategoriDataGrid";
            this.KategoriDataGrid.Size = new System.Drawing.Size(298, 205);
            this.KategoriDataGrid.TabIndex = 26;
            this.KategoriDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KategoriDataGrid_CellContentClick);
            // 
            // Kategori_Adi
            // 
            this.Kategori_Adi.Location = new System.Drawing.Point(135, 33);
            this.Kategori_Adi.MaxLength = 100;
            this.Kategori_Adi.Name = "Kategori_Adi";
            this.Kategori_Adi.Size = new System.Drawing.Size(136, 20);
            this.Kategori_Adi.TabIndex = 20;
            this.Kategori_Adi.TextChanged += new System.EventHandler(this.Kategori_Adi_TextChanged);
            // 
            // kategoriadi
            // 
            this.kategoriadi.AutoSize = true;
            this.kategoriadi.Location = new System.Drawing.Point(65, 36);
            this.kategoriadi.Name = "kategoriadi";
            this.kategoriadi.Size = new System.Drawing.Size(64, 13);
            this.kategoriadi.TabIndex = 19;
            this.kategoriadi.Text = "Kategori Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kategori Arama";
            // 
            // katekle
            // 
            this.katekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.katekle.Image = global::By_Tayo.Properties.Resources.kategori;
            this.katekle.Location = new System.Drawing.Point(277, 21);
            this.katekle.Name = "katekle";
            this.katekle.Size = new System.Drawing.Size(32, 32);
            this.katekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.katekle.TabIndex = 35;
            this.katekle.TabStop = false;
            this.katekle.Tag = "Müşteri Kategorisi Ekle";
            this.katekle.Click += new System.EventHandler(this.katekle_Click);
            // 
            // UrunKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 275);
            this.Controls.Add(this.katekle);
            this.Controls.Add(this.DataId);
            this.Controls.Add(this.KategoriSil);
            this.Controls.Add(this.KategoriGuncelle);
            this.Controls.Add(this.KategoriDataGrid);
            this.Controls.Add(this.Kategori_Adi);
            this.Controls.Add(this.kategoriadi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(423, 314);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(423, 314);
            this.Name = "UrunKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Kategorileri";
            this.Load += new System.EventHandler(this.UrunKategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KategoriDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox DataId;
        private System.Windows.Forms.Button KategoriSil;
        private System.Windows.Forms.Button KategoriGuncelle;
        public System.Windows.Forms.DataGridView KategoriDataGrid;
        private System.Windows.Forms.Label kategoriadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox katekle;
        public System.Windows.Forms.TextBox Kategori_Adi;
    }
}