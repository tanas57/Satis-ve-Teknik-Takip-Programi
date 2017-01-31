namespace By_Tayo
{
    partial class YardimUrun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YardimUrun));
            this.kodAciklama = new System.Windows.Forms.TextBox();
            this.kodlar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // kodAciklama
            // 
            this.kodAciklama.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kodAciklama.Location = new System.Drawing.Point(534, 67);
            this.kodAciklama.Multiline = true;
            this.kodAciklama.Name = "kodAciklama";
            this.kodAciklama.Size = new System.Drawing.Size(220, 198);
            this.kodAciklama.TabIndex = 7;
            this.kodAciklama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kodlar
            // 
            this.kodlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kodlar.FormattingEnabled = true;
            this.kodlar.Items.AddRange(new object[] {
            "U-01",
            "U-02",
            "U-03",
            "U-04",
            "U-05",
            "U-06",
            "U-07",
            "U-08",
            "U-09"});
            this.kodlar.Location = new System.Drawing.Point(585, 40);
            this.kodlar.Name = "kodlar";
            this.kodlar.Size = new System.Drawing.Size(121, 21);
            this.kodlar.TabIndex = 6;
            this.kodlar.SelectedIndexChanged += new System.EventHandler(this.kodlar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(603, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hata Kodu";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Ürünler modülünde bulunanlar:",
            "",
            "\t* Ürünler",
            "\t* Ürün Ekleme",
            "\t* Ürün Güncelleme",
            "\t* Ürün Silme",
            "",
            "\t- Ürün Kategorileri",
            "\t* Kategoriler",
            "\t* Kategori Ekleme",
            "\t* Kategori Güncelleme",
            "\t* Kategori Silme",
            "",
            "Ürünler modülünde ilk girişte sistemde kayıtlı tüm ürünler listelenir. Bunun hari" +
                "cinde",
            "sistemde arama modülü eklidir. Ürün adına veya ürün barkod numarasına göre",
            "arama yapılarak ürünler içerisinden aranan ürün daha kolay çıkarılabilir.",
            "Listelenen ürünler üzerinde güncelleme ve silme işlemleri yapılabilmektedir. Silm" +
                "ek ",
            "veya güncellenecek ürün listeden seçilir sağ taraftaki güncelle veya sil butonuyl" +
                "a ",
            "devam edilir.",
            "",
            "Ürün ekle bölümünde ürün adı, barkod numarası eğer varsa barkodsuz seçeneği ",
            "kaldırılıp girilmelidir, ürün fiyatı ve ürünün kategorisi seçilerek ürün eklenir." +
                "",
            "",
            "Ürün güncelleme bölümünde ürün adına ve barkod numarasınsa göre arama modülü ",
            "bulunmaktadır.Ürün aradıktan sonra bulunan ürünlerin karşısından seçenek ",
            "kutusundan güncellenecek ürün seçilir, ürün bilgileri ürün güncelleme kısmında ",
            "gelmektedir. Buradan güncelleme işlemi yapılır.",
            "",
            "Ürün Silme bölümünde ürün adına göre arama modülü bulunmaktadır. Buradan ",
            "arama yapıldıktan sonra ürünü seçin kısmında bulunan ürünler listelenir. ",
            "Güncellenecek ürün seçilir. Ürün sil kısmında seçilen ürün için silinme işlemini " +
                "",
            "onaylamak gerekmektedir.",
            "",
            "Ürün Kategorileri; Kategoriler kısmında sistemde ekli kategoriler gelecektir. ",
            "Formda arama modülü mevcuttur. Listeden seçilen ürün kategorosi güncelleme ",
            "veya silme butonları ile işlem yapılabilir.",
            "",
            "Ürün kategori Ekle; ürün kategori ismi yazılır, ekle butonuyla işlem tamamlanır.",
            "",
            "Ürün kategorisi güncelleme; Kategori adına göre arama yapılır, bulunan ",
            "kategoriler seçiniz yazan kısmın karşısında listelenir. Buradan kategori seçilir." +
                " ",
            "Seçilen kategori bilgileri alttaki güncelleme kısmında gelir. Buradan ",
            "güncelleme işlemi yapılır.",
            "",
            "Ürün kategori silme; burada kategori ismine göre arama yapılır. Bulunan kategoril" +
                "er ",
            "listelenir. Listeden seçilen kategori için silme bölümü aktif olur. Buradan silme" +
                "",
            "onaylanır veya iptal edilir."});
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(515, 260);
            this.listBox1.TabIndex = 8;
            // 
            // YardimUrun
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
            this.Name = "YardimUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yardım Ürün";
            this.Load += new System.EventHandler(this.YardimUrun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kodAciklama;
        private System.Windows.Forms.ComboBox kodlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}