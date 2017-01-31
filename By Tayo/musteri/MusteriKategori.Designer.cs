namespace By_Tayo
{
    partial class MusteriKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriKategori));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataId = new System.Windows.Forms.TextBox();
            this.MusteriSil = new System.Windows.Forms.Button();
            this.MusteriGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(304, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DataId
            // 
            this.DataId.Location = new System.Drawing.Point(335, 66);
            this.DataId.Name = "DataId";
            this.DataId.Size = new System.Drawing.Size(32, 20);
            this.DataId.TabIndex = 20;
            this.DataId.Text = "0";
            this.DataId.Visible = false;
            // 
            // MusteriSil
            // 
            this.MusteriSil.Image = global::By_Tayo.Properties.Resources.carpi32;
            this.MusteriSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MusteriSil.Location = new System.Drawing.Point(322, 151);
            this.MusteriSil.Name = "MusteriSil";
            this.MusteriSil.Size = new System.Drawing.Size(87, 40);
            this.MusteriSil.TabIndex = 19;
            this.MusteriSil.Text = "     Sil ";
            this.MusteriSil.UseVisualStyleBackColor = true;
            this.MusteriSil.Click += new System.EventHandler(this.MusteriSil_Click);
            // 
            // MusteriGuncelle
            // 
            this.MusteriGuncelle.Image = global::By_Tayo.Properties.Resources.duzenle;
            this.MusteriGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MusteriGuncelle.Location = new System.Drawing.Point(322, 92);
            this.MusteriGuncelle.Name = "MusteriGuncelle";
            this.MusteriGuncelle.Size = new System.Drawing.Size(87, 40);
            this.MusteriGuncelle.TabIndex = 18;
            this.MusteriGuncelle.Text = "Güncelle ";
            this.MusteriGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MusteriGuncelle.UseVisualStyleBackColor = true;
            this.MusteriGuncelle.Click += new System.EventHandler(this.MusteriGuncelle_Click);
            // 
            // MusteriKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.DataId);
            this.Controls.Add(this.MusteriSil);
            this.Controls.Add(this.MusteriGuncelle);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 300);
            this.Name = "MusteriKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Kategorileri";
            this.Load += new System.EventHandler(this.MusteriKategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox DataId;
        private System.Windows.Forms.Button MusteriSil;
        private System.Windows.Forms.Button MusteriGuncelle;
    }
}