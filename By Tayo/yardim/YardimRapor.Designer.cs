namespace By_Tayo
{
    partial class YardimRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YardimRapor));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.kodAciklama = new System.Windows.Forms.TextBox();
            this.kodlar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Raporlama modülünde bulunanlar;",
            "\t* Günlük Raporlar",
            "\t* Haftalık Raporlar",
            "\t* Aylık Raporlar",
            "",
            "Günlük Raporlar; Günlük olarak toplam ne kadar satış yapıldığı",
            "hangi ürünün en çok satıldığı, hangi ürün kategorisinden en çok",
            "satış yapıldığı bilgileri gösterilmektedir. Aynı zamanda kategorilere göre",
            "kaç adet satış yapıldığı grafik üzerinde gösterilmiştir.",
            "",
            "Haftalık Raporlar; Haftalık olarak toplam ne kadar satış yapıldığı",
            "hangi ürünün en çok satıldığı, hangi ürün kategorisinden en çok",
            "satış yapıldığı bilgileri gösterilmektedir. Aynı zamanda kategorilere göre",
            "kaç adet satış yapıldığı grafik üzerinde gösterilmiştir.",
            "",
            "Aylık Raporlar; Aylık olarak toplam ne kadar satış yapıldığı",
            "hangi ürünün en çok satıldığı, hangi ürün kategorisinden en çok",
            "satış yapıldığı bilgileri gösterilmektedir. Aynı zamanda kategorilere göre",
            "kaç adet satış yapıldığı grafik üzerinde gösterilmiştir."});
            this.listBox1.Location = new System.Drawing.Point(13, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(515, 260);
            this.listBox1.TabIndex = 20;
            // 
            // kodAciklama
            // 
            this.kodAciklama.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kodAciklama.Location = new System.Drawing.Point(534, 65);
            this.kodAciklama.Multiline = true;
            this.kodAciklama.Name = "kodAciklama";
            this.kodAciklama.Size = new System.Drawing.Size(220, 198);
            this.kodAciklama.TabIndex = 19;
            this.kodAciklama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kodlar
            // 
            this.kodlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kodlar.FormattingEnabled = true;
            this.kodlar.Items.AddRange(new object[] {
            "R-01",
            "R-02",
            "R-03"});
            this.kodlar.Location = new System.Drawing.Point(585, 38);
            this.kodlar.Name = "kodlar";
            this.kodlar.Size = new System.Drawing.Size(121, 21);
            this.kodlar.TabIndex = 18;
            this.kodlar.SelectedIndexChanged += new System.EventHandler(this.kodlar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(603, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hata Kodu";
            // 
            // YardimRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 281);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.kodAciklama);
            this.Controls.Add(this.kodlar);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(782, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(782, 320);
            this.Name = "YardimRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yardım Rapor";
            this.Load += new System.EventHandler(this.YardimRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox kodAciklama;
        private System.Windows.Forms.ComboBox kodlar;
        private System.Windows.Forms.Label label2;
    }
}