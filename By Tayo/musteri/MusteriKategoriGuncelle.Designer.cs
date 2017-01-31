namespace By_Tayo
{
    partial class MusteriKategoriGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriKategoriGuncelle));
            this.katAdi = new System.Windows.Forms.TextBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // katAdi
            // 
            this.katAdi.Location = new System.Drawing.Point(82, 29);
            this.katAdi.MaxLength = 100;
            this.katAdi.Name = "katAdi";
            this.katAdi.Size = new System.Drawing.Size(185, 20);
            this.katAdi.TabIndex = 0;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Image = global::By_Tayo.Properties.Resources.duzenle;
            this.BtnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuncelle.Location = new System.Drawing.Point(111, 68);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(97, 45);
            this.BtnGuncelle.TabIndex = 1;
            this.BtnGuncelle.Text = "   Güncelle  ";
            this.BtnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Adı";
            // 
            // MusteriKategoriGuncelle
            // 
            this.AcceptButton = this.BtnGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 124);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.katAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(344, 163);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(344, 163);
            this.Name = "MusteriKategoriGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Kategori Güncelle";
            this.Load += new System.EventHandler(this.MusteriKategoriGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox katAdi;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Label label1;
    }
}