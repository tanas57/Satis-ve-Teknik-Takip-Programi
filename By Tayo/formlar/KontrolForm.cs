using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace By_Tayo
{
    public partial class KontrolForm : Form
    {
        public KontrolForm()
        {
            InitializeComponent();
        }
        Lisanslama ls = new Lisanslama();
        private void FormaGec_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
        private void say_Tick(object sender, EventArgs e)
        {
            //TimerKod();
        }

        private void KontrolForm_Load(object sender, EventArgs e)
        {
            //FormLoad();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void veriKontrol_Tick(object sender, EventArgs e)
        {

        }

        private void yenile_Click(object sender, EventArgs e)
        {
            Yenile();
        }

        private void grup2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ayancikhost.com");
        }
        /*
        public void TimerKod()
        {
            this.Text = "Kontrol ediliyor...";
            ldurum.Text = "Kontrol ediliyor...";
            ldurum.ForeColor = Color.Black;
            Fonksiyonlar fk = new Fonksiyonlar();
            ilerleme.Value = ilerleme.Value + 1;
            if (ilerleme.Value > 99)
            {
                say.Stop();
                if (ilerleme.Value > 30)
                {
                    bool internet = fk.InternetKontrol();
                    if (internet == true)
                    {
                        // lisans kontrol
                        byte lisansDurum = ls.LisansKontrol();
                        switch (lisansDurum)
                        {
                            case 0:
                                MessageBox.Show("Lisans kontrol işleminde bir hata oluştu, program başlatılamamaktadır.", "Lisans Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                resim.ImageLocation = "Resources\\carpi32.png";
                                this.Text = "Sistem çalışır durumda değil, yetkili ile iletişime geçiniz.";
                                iletisim i = new iletisim(); i.ShowDialog();
                                ldurum.Text = "Sistemsel hata oluştu. Kod : "+lisansDurum.ToString();
                                Giris.Enabled = false;
                                break;
                            case 1:
                                byte Lkontrol = ls.LisansKontrol2();

                                switch (Lkontrol)
                                {
                                    case 100:
                                        // bilinmeyen bir hata oluştu
                                        resim.ImageLocation = "Resources\\carpi32.png";
                                        this.Text = "Sistem çalışır durumda değil, daha sonra tekrar deneyin.";
                                        ldurum.Text = "Sistemsel hata oluştu.";
                                        ldurum.Text = "Sistemsel hata oluştu. Kod : " + lisansDurum.ToString();
                                        Giris.Enabled = false;
                                        break;

                                    case 101:
                                        // deneme bitti
                                        resim.ImageLocation = "Resources\\carpi32.png";
                                        this.Text = "Deneme kullanım süreniz doldu.";
                                        ldurum.Text = "Deneme kullanım süreniz doldu.";
                                        ldurum.ForeColor = Color.Red;
                                        Giris.Enabled = false;
                                        ligir.Visible = true;
                                        break;

                                    case 102:
                                        // birden fazla lisansta kayıt olundu programlar kapatıldı.
                                        resim.ImageLocation = "Resources\\carpi32.png";
                                        this.Text = "Girilen lisans kullanılmaktadır, program devre dışı bırakıldı.";
                                        ldurum.Text = "Lisans devre dışı bırakıldı.";
                                        ldurum.ForeColor = Color.Red;
                                        Giris.Enabled = false;
                                        ligir.Visible = true;
                                        break;

                                    case 103:
                                        // lisans geçerli aç programı
                                        resim.ImageLocation = "Resources\\tik32.png";
                                        this.Text = "Sistem çalışır durumda, giriş yapabilirsiniz.";
                                        ldurum.Text = "Lisans etkin.";
                                        ldurum.ForeColor = Color.DarkGreen;
                                        ligir.Visible = false;
                                        Giris.Enabled = true;
                                        break;

                                    case 104:
                                        // lisans bu pc ye ait değil kapat programı.
                                        resim.ImageLocation = "Resources\\carpi32.png";
                                        this.Text = "Girilen lisans bu makina için geçerli değildir.";
                                        ldurum.Text = "Lisans kabul edilmedi.";
                                        ldurum.ForeColor = Color.Red;
                                        ligir.Visible = true;
                                        Giris.Enabled = false;
                                        break;

                                    case 105:
                                        // lisans çekilemedi
                                        resim.ImageLocation = "Resources\\carpi32.png";
                                        this.Text = "Lisans alınırken hata oluştu.";
                                        ldurum.Text = "Sistemsel hata oluştu. Kod : " + lisansDurum.ToString();
                                        ldurum.ForeColor = Color.Red;
                                        Giris.Enabled = false;
                                        ligir.Visible = true;
                                        break;

                                    case 106:
                                        // geçersiz lisans
                                        resim.ImageLocation = "Resources\\carpi32.png";
                                        this.Text = "Girilen lisans geçersizdir.";
                                        ldurum.Text = "Lisans geçersiz";
                                        ldurum.ForeColor = Color.Red;
                                        ligir.Visible = true;
                                        Giris.Enabled = false;
                                        break;

                                    case 107:
                                        // programınız devre dışı kalmıştır
                                        resim.ImageLocation = "Resources\\carpi32.png";
                                        this.Text = "Program yetkili tarafından devre dışı bırakılmıştır.";
                                        ldurum.Text = "Lisans devre dışı bırakıldı.";
                                        ldurum.ForeColor = Color.Red;
                                        Giris.Enabled = false;
                                        ligir.Visible = true;
                                        break;

                                    case 108:
                                        // hata seri no kayıtlı değil
                                        resim.ImageLocation = "Resources\\carpi32.png";
                                        this.Text = "Seri numaranı kayıtlı değil.";
                                        ldurum.Text = "Sistemsel hata oluştu. Kod : " + lisansDurum.ToString();
                                        ldurum.ForeColor = Color.Red;
                                        Giris.Enabled = false;
                                        ligir.Visible = true;
                                        break;

                                    default:
                                        resim.ImageLocation = "Resources\\tik32.png";
                                        this.Text = "Sistem çalışır durumda, giriş yapabilirsiniz.";
                                        ldurum.Text = "Kalan deneme süresi ->  " + Lkontrol.ToString() + " gün";
                                        ldurum.ForeColor = Color.Blue;
                                        ligir.Visible = true;
                                        Giris.Enabled = true;
                                        break;

                                }

                                byte sonuc = fk.BaglantiKontrol();
                                if (sonuc == 1)
                                {
                                    server.ImageLocation = "Resources\\tik32.png";
                                    //this.Text = "Sistem çalışır durumda, giriş yapabilirsiniz.";

                                }
                                else
                                {
                                    server.ImageLocation = "Resources\\carpi32.png";
                                    //this.Text = "Sistem çalışır durumda değil, yetkili ile iletişime geçiniz.";

                                    iletisim il = new iletisim();
                                    il.ShowDialog();
                                }

                                break;

                            case 3:
                                resim.ImageLocation = "Resources\\tik32.png";
                                this.Text = "Sistem çalışır durumda, giriş yapabilirsiniz.";
                                ldurum.Text= "Deneme lisansınız etkinleştirilmiştir.";
                                ldurum.ForeColor = Color.Blue;
                                byte sonuc2 = fk.BaglantiKontrol();
                                if (sonuc2 == 1)
                                {
                                    server.ImageLocation = "Resources\\tik32.png";
                                    //this.Text = "Sistem çalışır durumda, giriş yapabilirsiniz.";
                                }
                                else
                                {
                                    server.ImageLocation = "Resources\\carpi32.png";
                                    //this.Text = "Sistem çalışır durumda değil, yetkili ile iletişime geçiniz.";
                                    iletisim kk = new iletisim();
                                    kk.ShowDialog();
                                }
                                Giris.Enabled = true;
                                MessageBox.Show("Deneme lisansınız etkinleştirilmiştir. Programı 10 gün boyunca kısıtlamasız bir şekilde kullanabilirsiniz.", "Lisans Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                        // lisans kontrol

                        byte sonuc3 = fk.BaglantiKontrol();
                        if (sonuc3 == 1)
                        {
                            server.ImageLocation = "Resources\\tik32.png";
                            //this.Text = "Sistem çalışır durumda, giriş yapabilirsiniz.";
                        }
                        else
                        {
                            server.ImageLocation = "Resources\\carpi32.png";
                            //this.Text = "Sistem çalışır durumda değil, yetkili ile iletişime geçiniz.";
                            iletisim i = new iletisim();
                            i.ShowDialog();
                        }
                    }
                    else
                    {
                        byte sonuc2 = fk.BaglantiKontrol();
                        if (sonuc2 == 1)
                        {
                            server.ImageLocation = "Resources\\tik32.png";
                            this.Text = "Sistem çalışır durumda, giriş yapabilirsiniz.";
                        }
                        else
                        {
                            server.ImageLocation = "Resources\\carpi32.png";
                            this.Text = "Sistem çalışır durumda değil, yetkili ile iletişime geçiniz.";
                            iletisim i = new iletisim();
                            i.ShowDialog();
                        }
                        resim.ImageLocation = "Resources\\carpi32.png";
                        this.Text = "İnternet Bağlantınızı kontrol ediniz";
                        ldurum.Text = "Sunucuya bağlanılamadı.";
                        MessageBox.Show("İnternet bağlantınız bulunmamaktadır, lisans kontrolü yapılamadı. Bağlantıyı sağladıktan sonra tekrar deneyin.", "İnternet Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void FormLoad()
        {
            ilerleme.Value = 0;
            ToolTip tt = new ToolTip();
            tt.SetToolTip(yenile, "Bağlantıyı tekrar kontrol etmek için tıklayın");
            if (File.Exists(Application.StartupPath.ToString() + "\\Data\\DATA.FDB") == true)
            {
                say.Start();
            }
            else // veritabanı yoksa.
            {
                DialogResult VtYeniOnay = MessageBox.Show("Veritabanı dosyanız bulunamadı, sıfır veritabanı ile değiştirilecektir. Onaylıyor musunuz?", "Veritabanı Bulunamadı", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (VtYeniOnay == DialogResult.Yes)
                {
                    if (File.Exists(Application.StartupPath.ToString() + "\\Data\\Empty Data\\Data.fdb") == true)
                    {
                        File.Copy(Application.StartupPath.ToString() + "\\Data\\Empty Data\\DATA.FDB", Application.StartupPath.ToString() + "\\Data\\DATA.FDB");
                        MessageBox.Show("Veritabanınız yenilenmiştir, programa geçiliyor..", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        say.Start();
                    }
                    else
                    {
                        MessageBox.Show("Yedek veritabanı dosyanız bulunamadı, lütfen sağlayıcınız ile iletişime geçiniz", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // iletişim sayfasına gönderelim.
                        resim.ImageLocation = "Resources\\carpi32.png";
                        iletisim i = new iletisim(); i.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi, programınız veritabanı olmadan çalışmayacaktır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
        }
        */
        private void ligir_Click(object sender, EventArgs e)
        {
            say.Stop();
            Lisans li = new Lisans();
            li.ShowDialog();
        }

        public void Yenile()
        {
            resim.ImageLocation = "Resources\\bekle1.gif";
            server.ImageLocation = "Resources\\bekle1.gif";
            ilerleme.Value = 0;
            say.Start();
        }

        private void Giris_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();

        }

        private void iletisim_Click(object sender, EventArgs e)
        {
            iletisim i = new iletisim();
            i.ShowDialog();
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
