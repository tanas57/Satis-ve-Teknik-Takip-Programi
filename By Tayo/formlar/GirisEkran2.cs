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
    public partial class GirisEkran2 : Form
    {
        public GirisEkran2()
        {
            InitializeComponent();
        }
        Lisanslama ls = new Lisanslama();
        Fonksiyonlar fk = new Fonksiyonlar();
        Form1 AnaForm = (Form1)Application.OpenForms["Form1"];
        private void GirisEkran2_Load(object sender, EventArgs e)
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
                            this.Hide();
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
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LisansKontrol()
        {
            string KayitliSerial = fk.PcSerial;
            string BuPcSerial = ls.CPUSeriNo();
            if (BuPcSerial == KayitliSerial)
            {
                Giris.Enabled = true;
                lDurum.Text = "Lisans etkin.";
                lDurum.ForeColor = Color.Green;
                this.Text = "Sistem çalışır durumda, giriş yapabilirsiniz - " + fk.FirmaAdi;
            }
            else
            {
                Giris.Enabled = false;
                lDurum.Text = "Lisans geçersiz.";
                lDurum.ForeColor = Color.Red;
                this.Text = "Lisansınız geçersizdir - " + fk.FirmaAdi;
            }
        }
        private void lisansla_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iletisim i = new iletisim(); i.ShowDialog();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
