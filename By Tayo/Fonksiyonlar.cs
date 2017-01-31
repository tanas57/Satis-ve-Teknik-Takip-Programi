using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Services;
using System.IO;
using Microsoft.Win32;
using System.Security.AccessControl;
using MySql.Data.MySqlClient;

namespace By_Tayo
{
    class Fonksiyonlar
    {
        string baglanti_cumlesi = "User=SYSDBA;Password=masterkey;Database=" + Application.StartupPath.ToString() + "\\Data\\DATA.FDB;DataSource=localhost;Port=3050;Dialect=3;Charset=WIN1254;Role=;Connection lifetime=0.01;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=1;";
        public DataTable dt = new DataTable();
        public string FirmaAdi = "Muslu Yazılım";
        public string ProAdi = "Satış ve Teknik Takip Programı";
        public string Versiyon = Application.ProductVersion;
        public string Ekleme = "";
        public bool SerialKontrol = false;
        public string PcSerial = "";

        // İnternet veya Serial Doğrulama
        public void LisansDogrula()
        {
            try
            {
                if (SerialKontrol == false)
                {
                    Application.Run(new GirisEkran());
                }
                else
                {
                    Application.Run(new GirisEkran2());
                }
            }
            catch (Exception e11)
            {
                MessageBox.Show(e11.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static List<string> izinler = new List<string>();

        // Yazma izni ver **** SORUN !!!
        public void izinVer(string Kullanici,string KlasorYolu)
        {
            try
            {
                if (Directory.Exists(KlasorYolu))
                {
                    var klasor = new DirectoryInfo(KlasorYolu);
                    var klasorGuvenligi = klasor.GetAccessControl();

                    var rule = new FileSystemAccessRule(Kullanici, FileSystemRights.FullControl, InheritanceFlags.None | InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow);

                    izinler.Add(rule.IdentityReference.Value.ToString());
                    klasorGuvenligi.SetAccessRule(rule);
                    klasor.SetAccessControl(klasorGuvenligi);
                }
                else
                {
                    MessageBox.Show("Klasör bulunamadı.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // registrye ekleme silme **** ÇALIŞMIYOR !!!
        public void OtomatikBaslangic(bool gelen)
        {
            try
            {
                string yol = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
                if (gelen == true)
                {
                    Registry.CurrentUser.CreateSubKey(yol);
                    Registry.CurrentUser.CreateSubKey(yol).SetValue("Muslu - Satış ve Teknik", Application.StartupPath.ToString() + "\\SatisveTeknik1.0.exe");
                }
                else
                {
                    Registry.CurrentUser.CreateSubKey(yol).DeleteValue("Muslu - Satış ve Teknik");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Son alma yedek tarihi
        public string SonYedekAlma()
        {
            FbConnection baglan = new FbConnection(Baglanti_Kodu());
            baglan.Open();
            string tarih = "";
            try
            {
                FbCommand Sor = new FbCommand("SELECT SON_YEDEK_TARIH FROM AYAR", baglan);
                FbDataReader Cek = Sor.ExecuteReader();
                Cek.Read();
                tarih = Cek["SON_YEDEK_TARIH"].ToString();
                if (tarih.Length > 0)
                {
                    DateTime tarih1 = DateTime.Parse(tarih.ToString());
                    tarih = tarih1.ToString("dd.MM.yyyy");
                }
                else
                {
                    tarih = "";
                }
                Cek.Close();
            }
            catch (Exception q1)
            {
                MessageBox.Show(q1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tarih = "";
            }
            baglan.Close();
            return tarih;
        }

        // Son alma yedek tarihi
        public string SonYedekYukleme()
        {
            FbConnection baglan = new FbConnection(Baglanti_Kodu());
            string tarih = "";
            baglan.Open();
            try
            {
                FbCommand Sor = new FbCommand("SELECT YEDEK_YUKLENME_TARIH FROM AYAR", baglan);
                FbDataReader Cek = Sor.ExecuteReader();
                Cek.Read();
                tarih = Cek["YEDEK_YUKLENME_TARIH"].ToString();
                if (tarih.Length > 0)
                {
                    DateTime tarih1 = DateTime.Parse(tarih.ToString());
                    tarih = tarih1.ToString("dd.MM.yyyy");
                }
                else
                {
                    tarih = "";
                }
                Cek.Close();
            }
            catch (Exception q1)
            {
                MessageBox.Show(q1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tarih = "";
            }
            baglan.Close();
            return tarih;
        }

        // Yedek Dizin
        public void DizinAyar()
        {
            try
            {
                FbConnection baglan = new FbConnection(Baglanti_Kodu());
                baglan.Open();
                FbCommand Sor = new FbCommand("select yedek_dizin from Ayar", baglan);
                FbDataReader Cek = Sor.ExecuteReader();
                Cek.Read();
                if (Cek["yedek_dizin"].ToString() == "0")
                {
                    if (File.Exists(Application.StartupPath + "\\Yedekler") == false)
                    {
                        Directory.CreateDirectory(Application.StartupPath + "\\Yedekler");
                    }
                    FbCommand Guncelle = new FbCommand("update Ayar set yedek_dizin='" + Application.StartupPath.ToString() + "\\Yedekler\\" + "'", baglan);
                    Guncelle.ExecuteNonQuery();
                }
                baglan.Close();
            }
            catch (Exception q1)
            {
                MessageBox.Show(q1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string YedekDizin()
        {
            try
            {
                FbConnection baglan = new FbConnection(Baglanti_Kodu());
                baglan.Open();
                FbCommand Sor = new FbCommand("select yedek_dizin from Ayar", baglan);
                FbDataReader Cek = Sor.ExecuteReader();
                Cek.Read();
                string dd = Cek["yedek_dizin"].ToString();
                baglan.Close();
                return dd;
            }
            catch (Exception q2)
            {
                MessageBox.Show(q2.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        // Yedek yüklenme tarih güncelle
        private void YedekYuklenmeTarihGuncelle()
        {
            FbConnection baglan = new FbConnection(baglanti_cumlesi);
            try
            {
                baglan.Open();
                FbCommand Guncelle = new FbCommand("update ayar set YEDEK_YUKLENME_TARIH='" + DateTime.Now.ToString("yyyy-MM-dd") + "'", baglan);
                Guncelle.ExecuteNonQuery();
                baglan.Close();
            }
            catch (Exception ea1)
            {
                MessageBox.Show(ea1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Yedek yüklenme tarih güncelle
        private void YedekAlmaTarihGuncelle()
        {
            FbConnection baglan = new FbConnection(baglanti_cumlesi);
            try
            {
                baglan.Open();
                FbCommand Guncelle = new FbCommand("update ayar set SON_YEDEK_TARIH='" + DateTime.Now.ToString("yyyy-MM-dd") + "'", baglan);
                Guncelle.ExecuteNonQuery();
                baglan.Close();
            }
            catch (Exception ea1)
            {
                MessageBox.Show(ea1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Yedek yükleme
        public void YedekYukle(string GelenDizin)
        {
            try
            {
                FbRestore yedekYukle = new FbRestore();

                yedekYukle.ConnectionString = baglanti_cumlesi;
                yedekYukle.BackupFiles.Add(new FbBackupFile(GelenDizin, 2048));
                yedekYukle.Verbose = true;
                yedekYukle.PageSize = 8192;
                yedekYukle.Options = FbRestoreFlags.Create | FbRestoreFlags.Replace;

                yedekYukle.Execute();
                YedekYuklenmeTarihGuncelle();
                MessageBox.Show("Seçilen yedek başarıyla yüklenmiştir.", "Yedekleme Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception h2)
            {
                MessageBox.Show(h2.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Yedek alma
        public void YedekAl(string GelenDizin)
        {
            try
            {
                if (GelenDizin == "Standart")
                {
                    FbConnection baglan = new FbConnection(Baglanti_Kodu());
                    // klasör varmı
                    baglan.Open();
                    FbCommand Cek = new FbCommand("select yedek_dizin from Ayar", baglan);
                    FbDataReader Oku = Cek.ExecuteReader(); Oku.Read();
                    string dizin = Oku["yedek_dizin"].ToString();
                    Oku.Close();
                    baglan.Close();
                    if (dizin == "0" || dizin == "")
                    {
                        dizin = Application.StartupPath + "\\Yedekler";
                        baglan.Open();
                        FbCommand Guncelle = new FbCommand("update Ayar set yedek_dizin='" + dizin + "'", baglan);
                        Guncelle.ExecuteNonQuery();
                        baglan.Close();
                    }

                    if (File.Exists(dizin) == false)
                    {
                        Directory.CreateDirectory(dizin);
                    }
                    izinVer(Environment.UserName, dizin);
                    string Yil = DateTime.Now.Year.ToString();

                    string Ay = DateTime.Now.Month.ToString();

                    string tamTarih = DateTime.Now.ToString("dd-MM-yyyy-h-m-s");
                    if (File.Exists(dizin + "\\" + Yil) == false)
                    {
                        Directory.CreateDirectory(dizin + "\\" + Yil);
                    }
                    izinVer(Environment.UserName, dizin + "\\" + Yil);
                    if (File.Exists(dizin + "\\" + Yil + "\\" + Aylar(byte.Parse(Ay.ToString()))) == false)
                    {
                        Directory.CreateDirectory(dizin + "\\" + Yil + "\\" + Aylar(byte.Parse(Ay.ToString())));
                    }
                    izinVer(Environment.UserName, dizin + "\\" + Yil + "\\" + Aylar(byte.Parse(Ay.ToString())));
                    FbBackup yedekAl = new FbBackup();

                    yedekAl.ConnectionString = baglanti_cumlesi;
                    yedekAl.BackupFiles.Add(new FbBackupFile(dizin + "\\" + Yil + "\\" + Aylar(byte.Parse(Ay.ToString())) + "\\" + tamTarih + ".fbk", 2048));
                    yedekAl.Verbose = true;

                    yedekAl.Options = FbBackupFlags.IgnoreLimbo;

                    yedekAl.Execute();

                    YedekAlmaTarihGuncelle();

                    MessageBox.Show("Yedekleme işlemi yapılmıştır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string dizin = GelenDizin;

                    if (File.Exists(dizin) == false)
                    {
                        Directory.CreateDirectory(dizin);
                    }

                    string tamTarih = DateTime.Now.ToString("dd-MM-yyyy-h-m-s");

                    FbBackup yedekAl = new FbBackup();

                    yedekAl.ConnectionString = baglanti_cumlesi;
                    yedekAl.BackupFiles.Add(new FbBackupFile(dizin + "\\" + tamTarih + ".fbk", 2048));
                    yedekAl.Verbose = true;

                    yedekAl.Options = FbBackupFlags.IgnoreLimbo;

                    yedekAl.Execute();
                }
            }
            catch (Exception h1)
            {
                MessageBox.Show(h1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Ayları yazdır
        private string Aylar(byte ayDegeri)
        {
            string ay = "";
            switch (ayDegeri)
            {
                case 1: ay = "Ocak"; break;
                case 2: ay = "Şubat"; break;
                case 3: ay = "Mart"; break;
                case 4: ay = "Nisan"; break;
                case 5: ay = "Mayıs"; break;
                case 6: ay = "Haziran"; break;
                case 7: ay = "Temmuz"; break;
                case 8: ay = "Ağustos"; break;
                case 9: ay = "Eylül"; break;
                case 10: ay = "Ekim"; break;
                case 11: ay = "Kasım"; break;
                case 12: ay = "Aralık"; break;
            }
            return ay;
        }
        // Takipler için datagride stün oluşturma
        public object TakipSutunOlustur()
        {
            //Yeni veri tablosu oluştur

            DataColumn sutun;

            sutun = new DataColumn("Takip Id");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Takip No");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Cihaz Marka");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Cihaz Model");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Cihaz İmei");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Cihaz SeriNo");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Müşteri Ad Soyad");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Müşteri Telefon");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Cihaz Giriş Tarihi");
            sutun.DataType = Type.GetType("System.DateTime");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Cihaz Çıkış Tarihi");
            sutun.DataType = Type.GetType("System.DateTime");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Takip Durum");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);
            return dt;
        }

        // Satışlar stün oluştur
        public object SatisStunOlustur()
        {
            //Yeni veri tablosu oluştur

            DataColumn sutun;

            sutun = new DataColumn("Satış Id");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Satış Ürün");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Satış Müşteri");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Satış Tarihi");
            sutun.DataType = Type.GetType("System.DateTime");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Satış Notu");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            return dt;
        }

        // Müşteriler için datagride stün oluşturma
        public object SutunOlustur()
        {
            //Yeni veri tablosu oluştur
            
            DataColumn sutun;

            sutun = new DataColumn("Müşteri Id");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Adı Soyadı");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Telefon");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Bakiye");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Kayıt Tarihi");
            sutun.DataType = Type.GetType("System.DateTime");
            dt.Columns.Add(sutun);

            return dt;
        }

        // Müşteriler için datagride stün oluşturma
        public object UrunSutunOlustur()
        {
            //Yeni veri tablosu oluştur

            DataColumn sutun;

            sutun = new DataColumn("Ürün Id");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Ürün Barkod");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Ürün Adı");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Satış Fiyatı");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Ürün Kategori");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Eklenme Tarihi");
            sutun.DataType = Type.GetType("System.DateTime");
            dt.Columns.Add(sutun);

            return dt;
        }
        // Kategoriler için datagride stün oluşturma
        public object KategoriStunOlustur()
        {
            DataColumn sutun;

            sutun = new DataColumn("Kategori Id");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            sutun = new DataColumn("Kategori Adı");
            sutun.DataType = Type.GetType("System.String");
            dt.Columns.Add(sutun);

            return dt;
        }
        // Bağlantı kodu
        public string Baglanti_Kodu()
        {
            return baglanti_cumlesi;
        }
        // Bağlantı açma || kapatma
        public string BaglantiKontrol()
        {
            try
            {
                FbConnection komut_baglan = new FbConnection(baglanti_cumlesi);
                komut_baglan.Open();
                komut_baglan.Close();
                return "1";
            }
            catch(Exception e)
            {
                return e.Message;
            }
            
        }
        // Veritabanına veri ekleme sorgusu
        public byte Ekle(string tabloadi,string sql1,string sql2)
        {
            try
            {
                int etkilenme = 0;
                FbConnection baglan = new FbConnection(baglanti_cumlesi);
                FbCommand komutinsert = new FbCommand();


                komutinsert.CommandText = "INSERT INTO " + tabloadi + " (" + sql1 + ") VALUES (" + sql2 + ")";
                komutinsert.Connection = baglan;
                baglan.Open();
                etkilenme = komutinsert.ExecuteNonQuery();
                baglan.Close();
                if (etkilenme > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        // Veritabanından veri silme sorgusu
        public byte Sil(string tabloadi, string sql1)
        {
            try
            {
                int etkilenme = 0;
                FbConnection baglan = new FbConnection(baglanti_cumlesi);
                FbCommand komutdelete = new FbCommand();


                komutdelete.CommandText = "DELETE FROM " + tabloadi + " WHERE " + sql1 + "";
                komutdelete.Connection = baglan;
                baglan.Open();
                etkilenme = komutdelete.ExecuteNonQuery();
                baglan.Close();
                if (etkilenme > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        // Veritabanında güncelleme yapma sorgusu
        public byte Guncelle(string tabloadi, string sql1, string sql2)
        {
            try
            {
                int etkilenme = 0;
                FbConnection baglan = new FbConnection(baglanti_cumlesi);
                FbCommand komutupdate = new FbCommand();


                komutupdate.CommandText = "UPDATE " + tabloadi + " SET " + sql1 + " WHERE " + sql2 + "";
                komutupdate.Connection = baglan;
                baglan.Open();
                etkilenme = komutupdate.ExecuteNonQuery();
                baglan.Close();
                if (etkilenme > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        // İlk harfkeri büyütme fonksiyonu
        public string IlkHarfleriBuyut(string metin)
        {
            try
            {
                System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
                System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
                return textInfo.ToTitleCase(metin);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public bool InternetKontrol()
        {
                try
                {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com", 80);
                kontrol_client.Close();
                return true;
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                }
        }
    }
}
