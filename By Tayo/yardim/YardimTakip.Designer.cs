namespace By_Tayo
{
    partial class YardimTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YardimTakip));
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
            "Teknik Takip modülünde bulunanlar;",
            "\t* Takipler",
            "\t* Yeni Ekle",
            "\t* Takip Durum",
            "",
            "Takipler; Bu kısımda sistemde kayıtlı olan teknik takipler listelenmektedir. İste" +
                "nilen ",
            "takip üzerinde güncelleme veya silme işlemleri yapılabilinmektedir. Aradığınız ta" +
                "kibe ",
            "hızlı ulaşabilmek için arama modülü mevcuttur. Arama modülü, takip numarasına ",
            "göre arama yapmaktadır. Girilen arama numarasına göre takip sistemde mevcut ise ",
            "listeye düşecektir. Seçilip işlem yapılabilir.",
            "",
            "Yeni Ekle; Sisteme yeni bir takip girdisi eklemek için kullanılmaktadır. Müşteri " +
                "bilgileri",
            "ve Cihaz bilgileri olmak üzere iki girdi istenmektedir. Eğer müşteri sisteminizde" +
                " kayıtlı",
            "ise \"Müşteri üye mi ?\" seçeneği seçilir. Buradan listeden müşterı adı seçilir. Eğ" +
                "er ",
            "listede arama yapmak istiyorsanız müşteri arama kutusuna ad veya soyadın bir",
            "kısmını yazarak arama yaptırabilirsiniz.",
            "Eğer müşteri üye değilse Müşteri bilgi girişi kısmından müşteri ad soyad ve telef" +
                "on ",
            "numarası bilgileri istenmektedir.",
            "Cihaz bilgileri kısmında ise sisteme girilecek cihazın; marka, model, imei veya s" +
                "eri",
            "numarası istenmektedir. Bu teknip takipin takip numarası \"TKP\" ile başlayan ",
            "kırmızı koddur. Bunu kopyalamayı ve müşteriye vermeyi unutmayınız."});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(515, 260);
            this.listBox1.TabIndex = 16;
            // 
            // kodAciklama
            // 
            this.kodAciklama.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kodAciklama.Location = new System.Drawing.Point(533, 66);
            this.kodAciklama.Multiline = true;
            this.kodAciklama.Name = "kodAciklama";
            this.kodAciklama.Size = new System.Drawing.Size(220, 198);
            this.kodAciklama.TabIndex = 15;
            this.kodAciklama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kodlar
            // 
            this.kodlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kodlar.FormattingEnabled = true;
            this.kodlar.Items.AddRange(new object[] {
            "T-01",
            "T-02",
            "T-03",
            "T-04",
            "T-05",
            "T-06",
            "T-07",
            "T-08",
            "T-09",
            "T-10",
            "T-11",
            "T-12",
            "T-13",
            "T-14"});
            this.kodlar.Location = new System.Drawing.Point(584, 39);
            this.kodlar.Name = "kodlar";
            this.kodlar.Size = new System.Drawing.Size(121, 21);
            this.kodlar.TabIndex = 14;
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
            this.label2.TabIndex = 13;
            this.label2.Text = "Hata Kodu";
            // 
            // YardimTakip
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
            this.Name = "YardimTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yardım Takip";
            this.Load += new System.EventHandler(this.YardimTakip_Load);
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