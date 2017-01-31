namespace By_Tayo
{
    partial class YardimMusteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YardimMusteri));
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
            "Müşteriler modülünde bulunanlar;",
            "\t* Müşteriler",
            "\t* Müşteri Ekle",
            "\t* Müşteri Güncelle",
            "\t* Müşteri Sil",
            "\t",
            "\t- Müşteri Kategorileri",
            "\t* Kategoriler",
            "\t* Yeni Ekle",
            "",
            "Müşteriler modülünde Müşteriler kısmından sistemde ekli bulunan tüm üyeler ",
            "listelenmektedir. İstenildiği taktirde aranan müşteriye kolay ulaşmak için arama " +
                "",
            "modülü bulunmaktadır. Ad ve Soyad\'a göre arama ve Kayıt tarihine göre arama",
            "bulunmaktadır. Ad ve Soyad\'a göre arama sisteminde müşterinin adının veya ",
            "soyadının bir kısmını yazıp listeleme butonuna tıklamanız yeterlidir. ",
            "Girdiğiniz ad / soyada \' a göre benzer isimler listelenecektir. Kayıt tarihine gö" +
                "re",
            "aramada ise öncelikle bu sistemi aktif etmek için Aktif butonuna tıklamanız ",
            "gerekmektedir. Daha sonra kayıt tarihleri aralığı seçilir.  Listeleme butonuyla a" +
                "rama",
            "yapılır. Bulunan müşterilere göre güncelleme veya silme işlemi",
            "yapılabilir.",
            "Aynı zamanda sistemde borcu bulunan müşteriler borçlu müşteriler kısmında ",
            "listelenmektedir. Müşteri seçilip detay butonuyla müşteri bilgilerine ve güncelle" +
                "me ",
            "kısmına ulaşabilir.",
            "",
            "Müşteri Ekle; Bu kısımda sisteme yeni üye eklemek için kullanılmaktadır. Görünen " +
                "",
            "tüm alanlar doldurulup müşteri kategorisi seçildikten sonra Ekle butonuyla sistem" +
                "e ",
            "yeni müşteri eklenir.",
            "",
            "Müşteri Güncelle; Bu kısmı kullanabilmek için sistemde arama yaparak müşteri ",
            "bulmanız gerekmektedir. Müşterinin adı / soyadına göre arama yapılır, bulunan ",
            "müşteriler sağ tarafta müşteriyi seçin kısmında listelenir. Buradan seçilen müşte" +
                "rinin ",
            "bilgileri alt kısımda gelecektir. Buradan istenilen güncelleme yapılıp, güncellem" +
                "e ",
            "butonuyla kaydedilir.",
            "",
            "Müşteri Sil; Bu kısmı kullanabilmek için sistemde arama yaparak müşteri bulmanız " +
                "",
            "gerekmektedir. Müşterinin adı / soyadına göre arama yapılır, bulunan müşteriler ",
            "sağ tarafta müşteriyi seçin kısmında listelenir. Buradan seçilen müşteriyi silmek" +
                " için ",
            "onaylama kısmı aşağıdaki Müşteri Sil bölümünde açılır. Silme işlemini onaylamak ",
            "için Evet, iptal için Hayır Tıklanır.  Not: Silinecek müşterinin tüm siparişleri " +
                "ve ",
            "teknik takipleri silinecektir.",
            "",
            "Müşteri Kategorileri",
            "",
            "Kategoriler; Bu kısımda sistemde ekli tüm müşteri kategorileri listelenecektir. ",
            "Güncelleme veya silme işlemi yapılmak isteniyorsa, işlem yapılacak kategori ",
            "seçilip Güncelle veya Sil butonuyla devam edilir. Not: Müşteri kategorisi silinir" +
                "se; ",
            "bu kategoride ekli tüm ürünler, silinen ürünlerle satış yapılmışsa bu satışlar si" +
                "linecektir.",
            "",
            "Yeni Ekle; sisteme yeni müşteri kategorisi eklemek için burası kullanılır."});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(515, 260);
            this.listBox1.TabIndex = 12;
            // 
            // kodAciklama
            // 
            this.kodAciklama.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kodAciklama.Location = new System.Drawing.Point(533, 66);
            this.kodAciklama.Multiline = true;
            this.kodAciklama.Name = "kodAciklama";
            this.kodAciklama.Size = new System.Drawing.Size(220, 198);
            this.kodAciklama.TabIndex = 11;
            this.kodAciklama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kodlar
            // 
            this.kodlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kodlar.FormattingEnabled = true;
            this.kodlar.Items.AddRange(new object[] {
            "M-01",
            "M-02",
            "M-03",
            "M-04",
            "M-05",
            "M-06",
            "M-07",
            "M-08",
            "M-09",
            "M-10",
            "M-11"});
            this.kodlar.Location = new System.Drawing.Point(584, 39);
            this.kodlar.Name = "kodlar";
            this.kodlar.Size = new System.Drawing.Size(121, 21);
            this.kodlar.TabIndex = 10;
            this.kodlar.SelectedIndexChanged += new System.EventHandler(this.kodlar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(602, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hata Kodu";
            // 
            // YardimMusteri
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
            this.Name = "YardimMusteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yardım Müşteri";
            this.Load += new System.EventHandler(this.YardimMusteri_Load);
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