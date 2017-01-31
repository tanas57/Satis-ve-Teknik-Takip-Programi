namespace By_Tayo
{
    partial class UrunKategoriSil2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunKategoriSil2));
            this.AramaGrup = new System.Windows.Forms.GroupBox();
            this.katekle = new System.Windows.Forms.PictureBox();
            this.UrunKategoriCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AramaKategoriAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GuncellemeGrup = new System.Windows.Forms.GroupBox();
            this.SilHayir = new System.Windows.Forms.Button();
            this.SilEvet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AramaGrup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).BeginInit();
            this.GuncellemeGrup.SuspendLayout();
            this.SuspendLayout();
            // 
            // AramaGrup
            // 
            this.AramaGrup.Controls.Add(this.katekle);
            this.AramaGrup.Controls.Add(this.UrunKategoriCombo);
            this.AramaGrup.Controls.Add(this.label3);
            this.AramaGrup.Controls.Add(this.AramaKategoriAdi);
            this.AramaGrup.Controls.Add(this.label1);
            this.AramaGrup.Location = new System.Drawing.Point(12, 12);
            this.AramaGrup.Name = "AramaGrup";
            this.AramaGrup.Size = new System.Drawing.Size(317, 127);
            this.AramaGrup.TabIndex = 7;
            this.AramaGrup.TabStop = false;
            this.AramaGrup.Text = "Arama";
            // 
            // katekle
            // 
            this.katekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.katekle.Image = global::By_Tayo.Properties.Resources.kategori;
            this.katekle.Location = new System.Drawing.Point(222, 71);
            this.katekle.Name = "katekle";
            this.katekle.Size = new System.Drawing.Size(32, 32);
            this.katekle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.katekle.TabIndex = 35;
            this.katekle.TabStop = false;
            this.katekle.Tag = "Müşteri Kategorisi Ekle";
            this.katekle.Click += new System.EventHandler(this.katekle_Click);
            // 
            // UrunKategoriCombo
            // 
            this.UrunKategoriCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UrunKategoriCombo.Enabled = false;
            this.UrunKategoriCombo.FormattingEnabled = true;
            this.UrunKategoriCombo.Location = new System.Drawing.Point(77, 79);
            this.UrunKategoriCombo.Name = "UrunKategoriCombo";
            this.UrunKategoriCombo.Size = new System.Drawing.Size(136, 21);
            this.UrunKategoriCombo.TabIndex = 3;
            this.UrunKategoriCombo.SelectedIndexChanged += new System.EventHandler(this.UrunKategoriCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seçiniz -->";
            // 
            // AramaKategoriAdi
            // 
            this.AramaKategoriAdi.Location = new System.Drawing.Point(34, 30);
            this.AramaKategoriAdi.Name = "AramaKategoriAdi";
            this.AramaKategoriAdi.Size = new System.Drawing.Size(179, 20);
            this.AramaKategoriAdi.TabIndex = 1;
            this.AramaKategoriAdi.TextChanged += new System.EventHandler(this.AramaKategoriAdi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Kategorisi Arama";
            // 
            // GuncellemeGrup
            // 
            this.GuncellemeGrup.Controls.Add(this.SilHayir);
            this.GuncellemeGrup.Controls.Add(this.SilEvet);
            this.GuncellemeGrup.Controls.Add(this.label2);
            this.GuncellemeGrup.Enabled = false;
            this.GuncellemeGrup.Location = new System.Drawing.Point(15, 145);
            this.GuncellemeGrup.Name = "GuncellemeGrup";
            this.GuncellemeGrup.Size = new System.Drawing.Size(314, 143);
            this.GuncellemeGrup.TabIndex = 8;
            this.GuncellemeGrup.TabStop = false;
            this.GuncellemeGrup.Text = "Silme";
            // 
            // SilHayir
            // 
            this.SilHayir.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilHayir.Image = global::By_Tayo.Properties.Resources.carpi32;
            this.SilHayir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SilHayir.Location = new System.Drawing.Point(157, 67);
            this.SilHayir.Name = "SilHayir";
            this.SilHayir.Size = new System.Drawing.Size(84, 39);
            this.SilHayir.TabIndex = 8;
            this.SilHayir.Text = "Hayır ";
            this.SilHayir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SilHayir.UseVisualStyleBackColor = true;
            this.SilHayir.Click += new System.EventHandler(this.SilHayir_Click_1);
            // 
            // SilEvet
            // 
            this.SilEvet.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilEvet.Image = global::By_Tayo.Properties.Resources.tik32;
            this.SilEvet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SilEvet.Location = new System.Drawing.Point(67, 67);
            this.SilEvet.Name = "SilEvet";
            this.SilEvet.Size = new System.Drawing.Size(84, 39);
            this.SilEvet.TabIndex = 7;
            this.SilEvet.Text = "Evet  ";
            this.SilEvet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SilEvet.UseVisualStyleBackColor = true;
            this.SilEvet.Click += new System.EventHandler(this.SilEvet_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori silme işlemi";
            // 
            // UrunKategoriSil2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 293);
            this.Controls.Add(this.GuncellemeGrup);
            this.Controls.Add(this.AramaGrup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 332);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 332);
            this.Name = "UrunKategoriSil2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Kategori Silme";
            this.Load += new System.EventHandler(this.UrunKategoriSil2_Load);
            this.AramaGrup.ResumeLayout(false);
            this.AramaGrup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.katekle)).EndInit();
            this.GuncellemeGrup.ResumeLayout(false);
            this.GuncellemeGrup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AramaGrup;
        private System.Windows.Forms.ComboBox UrunKategoriCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AramaKategoriAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GuncellemeGrup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SilHayir;
        private System.Windows.Forms.Button SilEvet;
        private System.Windows.Forms.PictureBox katekle;

    }
}