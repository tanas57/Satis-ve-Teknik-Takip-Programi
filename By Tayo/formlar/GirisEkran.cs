using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FirebirdSql.Data.FirebirdClient;
namespace By_Tayo
{
    public partial class GirisEkran : Form
    {
        public GirisEkran()
        {
            InitializeComponent();
        }
        Lisanslama ls = new Lisanslama();
        Fonksiyonlar fk = new Fonksiyonlar();
        Form1 AnaForm = (Form1)Application.OpenForms["Form1"];
        private void GirisEkran_Load(object sender, EventArgs e)
        {
            try
            {
                surum.Text = Application.ProductVersion.ToString(); surum.ForeColor = Color.Purple;

                if (File.Exists(Application.StartupPath.ToString() + "\\Data\\DATA.FDB") == true)
                {
                    // vt onay true
                    LisansKontrol();
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
                            // vt onay true
                            LisansKontrol();
                        }
                        else
                        {
                            MessageBox.Show("Yedek veritabanı dosyanız bulunamadı, lütfen sağlayıcınız ile iletişime geçiniz", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // iletişim sayfasına gönderelim.
                            // vt onay false
                            LisansKontrol();
                            iletisim i = new iletisim(); i.ShowDialog();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("İşlem iptal edildi, programınız veritabanı olmadan çalışmayacaktır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LisansKontrol()
        {
            Fonksiyonlar fk = new Fonksiyonlar();
            string baglantiKontrol = fk.BaglantiKontrol();
            bool internet = fk.InternetKontrol();
            if (internet == true)
            {
                lisansla.Enabled = true;
                // lisans kontrol
                byte lisansDurum = ls.LisansKontrol();
                switch (lisansDurum)
                {
                    case 0:
                        MessageBox.Show("Lisans kontrol işleminde bir hata oluştu, program başlatılamamaktadır.", "Lisans Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Text = "Sistem çalışır durumda değil, yetkili ile iletişime geçiniz.";
                        lDurum.Text = "Sistemsel hata oluştu. Kod : " + lisansDurum.ToString();
                        Giris.Enabled = false;
                        iletisim i = new iletisim(); i.ShowDialog();

                        break;

                    case 1:
                        byte Lkontrol = ls.LisansKontrol2();

                        switch (Lkontrol)
                        {
                            case 100:
                                // bilinmeyen bir hata oluştu
                                this.Text = "Sistem çalışır durumda değil, daha sonra tekrar deneyin.";
                                this.Text = "Sistemsel hata oluştu";
                                lDurum.Text = "Sistemsel hata oluştu. Kod : " + lisansDurum.ToString();
                                Giris.Enabled = false;
                                break;

                            case 101:
                                // deneme bitti
                                this.Text = "Deneme kullanım süreniz doldu";
                                lDurum.Text = "Süre doldu.";
                                lDurum.ForeColor = Color.Red;
                                Giris.Enabled = false;
                                break;

                            case 102:
                                // birden fazla lisansta kayıt olundu programlar kapatıldı.
                                this.Text = "Girilen lisans kullanılmaktadır, program devre dışı bırakıldı.";
                                lDurum.Text = "Lisans devre dışı bırakıldı";
                                lDurum.ForeColor = Color.Red;
                                Giris.Enabled = false;
                                break;

                            case 103:
                                // lisans geçerli aç programı
                                this.Text = "Sistem çalışır durumda, giriş yapabilirsiniz";
                                lDurum.Text = "Lisans etkin.";
                                lDurum.ForeColor = Color.DarkGreen;
                                
                                if (baglantiKontrol == "1")
                                {
                                    Giris.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show(baglantiKontrol,"Veritabanı hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                                break;

                            case 104:
                                // lisans bu pc ye ait değil kapat programı.
                                this.Text = "Girilen lisans bu makina için geçerli değildir";
                                lDurum.Text = "Lisans geçersiz.";
                                lDurum.ForeColor = Color.Red;
                                Giris.Enabled = false;
                                break;

                            case 105:
                                // lisans çekilemedi
                                this.Text = "Lisans alınırken hata oluştu";
                                lDurum.Text = "Sistemsel hata oluştu. Kod : " + lisansDurum.ToString();
                                lDurum.ForeColor = Color.Red;
                                Giris.Enabled = false;
                                break;

                            case 106:
                                // geçersiz lisans
                                this.Text = "Girilen lisans geçersizdir";
                                lDurum.Text = "Lisans geçersiz";
                                lDurum.ForeColor = Color.Red;
                                Giris.Enabled = false;
                                break;

                            case 107:
                                // programınız devre dışı kalmıştır
                                this.Text = "Program yetkili tarafından devre dışı bırakılmıştır.";
                                lDurum.Text = "Lisans devre dışı bırakıldı";
                                lDurum.ForeColor = Color.Red;
                                Giris.Enabled = false;
                                break;

                            case 108:
                                // hata seri no kayıtlı değil
                                this.Text = "Seri numaranı kayıtlı değil";
                                lDurum.Text = "Sistemsel hata oluştu. Kod : " + lisansDurum.ToString();
                                lDurum.ForeColor = Color.Red;
                                Giris.Enabled = false;
                                break;

                            default:
                                this.Text = "Sistem çalışır durumda, giriş yapabilirsiniz";
                                if(Lkontrol.ToString() == "0")
                                    lDurum.Text = "1 gün kaldı.";
                                else
                                    lDurum.Text = "" + Lkontrol.ToString() + " gün kaldı.";
                                lDurum.ForeColor = Color.Blue;
                                if (baglantiKontrol == "1")
                                {
                                    Giris.Enabled = true;
                                }
                                else
                                {
                                    MessageBox.Show(baglantiKontrol, "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                        }
                        break;

                    case 3:
                        this.Text = "Sistem çalışır durumda, giriş yapabilirsiniz";
                        lDurum.Text = "10 gün kaldı.";
                        lDurum.ForeColor = Color.Blue;
                        if (baglantiKontrol == "1")
                        {
                            Giris.Enabled = true;
                            
                        }
                        else
                        {
                            MessageBox.Show(baglantiKontrol, "Veritabanı hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MessageBox.Show("Deneme lisansınız etkinleştirilmiştir. Programı 10 gün boyunca kısıtlamasız bir şekilde kullanabilirsiniz.", "Lisans Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                // lisans kontrol
            }
            else
            {
                this.Text = "İnternet Bağlantınızı kontrol ediniz";
                lDurum.Text = "Lisans kontrolü yapılamadı."; lDurum.ForeColor = Color.Black;
                Giris.Enabled = false;
                lisansla.Enabled = false;
                MessageBox.Show("İnternet bağlantınız bulunmamaktadır, lisans kontrolü yapılamadı. Bağlantıyı sağladıktan sonra tekrar deneyin.", "İnternet Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Text += " - " + fk.FirmaAdi;
        }

        private void Giris_Click(object sender, EventArgs e)
        {
            try
            {
                sifre.Text = sifre.Text.Replace("'", "’");
                string sifre2 = "";
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbCommand Cek = new FbCommand("select sifre from Ayar", baglan);
                FbDataReader Oku = Cek.ExecuteReader(); Oku.Read();
                sifre2 = Oku["sifre"].ToString(); Oku.Close();
                baglan.Close();
                if (sifre.Text == sifre2)
                {
                    this.Hide();
                    Form1 f1 = new Form1(); f1.ShowDialog();
                }
                else
                {
                    sifre.BackColor = Color.Red;
                    sifre.ForeColor = Color.White;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lisansla_Click(object sender, EventArgs e)
        {
            Lisans li = new Lisans(); li.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iletisim i = new iletisim(); i.ShowDialog();
        }
    }
}