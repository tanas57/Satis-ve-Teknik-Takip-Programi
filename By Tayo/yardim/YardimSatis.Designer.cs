namespace By_Tayo
{
    partial class YardimSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YardimSatis));
            this.label2 = new System.Windows.Forms.Label();
            this.kodlar = new System.Windows.Forms.ComboBox();
            this.kodAciklama = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(603, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hata Kodu";
            // 
            // kodlar
            // 
            this.kodlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kodlar.FormattingEnabled = true;
            this.kodlar.Items.AddRange(new object[] {
            "S-01",
            "S-02"});
            this.kodlar.Location = new System.Drawing.Point(585, 40);
            this.kodlar.Name = "kodlar";
            this.kodlar.Size = new System.Drawing.Size(121, 21);
            this.kodlar.TabIndex = 2;
            this.kodlar.SelectedIndexChanged += new System.EventHandler(this.kodlar_SelectedIndexChanged);
            // 
            // kodAciklama
            // 
            this.kodAciklama.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kodAciklama.Location = new System.Drawing.Point(534, 67);
            this.kodAciklama.Multiline = true;
            this.kodAciklama.Name = "kodAciklama";
            this.kodAciklama.Size = new System.Drawing.Size(220, 198);
            this.kodAciklama.TabIndex = 3;
            this.kodAciklama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Satış modülünde karşınıza çıkan hataları ve bilmediğiniz menüleri",
            "bu form yardımıyla öğrenmenizi sağlayacağız.",
            "",
            "Satış modülünde yeni satış ekleme işlemi yapılmaktadır. Yeni satış eklerken satış" +
                "lar",
            "iki adet farklı şekilde eklenmektedir. Birincisi ürün kategorisini seçilir, seçil" +
                "ince",
            "hemen altındaki seçim alanında bu kategoride yer alan ürünler yer almaktadır. Bur" +
                "adan",
            "hangi ürünün satışı yapılacaksa seçilir, kaç adet satılacaksa miktarı girilir. Eğ" +
                "er",
            "ürünün satıldığı müşteri, müşterilerde ekliyse seçenek işaretlenir. Açılan menüde" +
                "n",
            "kayıtlı müşteri seçilir.",
            "Satışta not eklemek istiyorsanız büyük metin kutusundan notunuzu ekleyebilirsiniz" +
                ".",
            "Satışı ekle butonu ile satış eklenir. İkinci seçenek ise barkod numarası girilere" +
                "k veya",
            "barkod okutulur, ara butonu ile arama yapılır barkod numarası kayıtlı ürünlerde v" +
                "arsa",
            "ürün ismi fiyat bilgileri gelir. Kaç adet satışı yapılacaksa miktar girilir. Ürün" +
                "ü",
            "satın alan kayıtlı müşteri ise seçenek işaretlenir ve açılan seçim kutusundan müş" +
                "teri",
            "seçimi yapılır. Not eklenecekse büyük metin kutusuna notunuzu ekleyerek Satış Ekl" +
                "e",
            "butonu ile satış eklenir."});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(516, 264);
            this.listBox1.TabIndex = 4;
            // 
            // YardimSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 282);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.kodAciklama);
            this.Controls.Add(this.kodlar);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(782, 321);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(782, 321);
            this.Name = "YardimSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yardım - Satış";
            this.Load += new System.EventHandler(this.YardimSatis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kodlar;
        private System.Windows.Forms.TextBox kodAciklama;
        private System.Windows.Forms.ListBox listBox1;
    }
}