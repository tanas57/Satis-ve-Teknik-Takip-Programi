namespace By_Tayo
{
    partial class MusteriKategoriSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriKategoriSil));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Silme = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Müşteri kategorisi silinmesini onaylıyor musunuz ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Silme
            // 
            this.Silme.Image = global::By_Tayo.Properties.Resources.carpi32;
            this.Silme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Silme.Location = new System.Drawing.Point(163, 81);
            this.Silme.Name = "Silme";
            this.Silme.Size = new System.Drawing.Size(85, 40);
            this.Silme.TabIndex = 6;
            this.Silme.Text = "Hayır   ";
            this.Silme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Silme.UseVisualStyleBackColor = true;
            this.Silme.Click += new System.EventHandler(this.Silme_Click);
            // 
            // Sil
            // 
            this.Sil.Image = global::By_Tayo.Properties.Resources.tik32;
            this.Sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sil.Location = new System.Drawing.Point(72, 81);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(85, 40);
            this.Sil.TabIndex = 0;
            this.Sil.Text = "Evet    ";
            this.Sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // MusteriKategoriSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 125);
            this.Controls.Add(this.Silme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriKategoriSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Kategori Sil";
            this.Load += new System.EventHandler(this.MusteriKategoriSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Silme;
    }
}