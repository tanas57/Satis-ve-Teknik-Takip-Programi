using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Management;
using System.Management.Instrumentation;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using Microsoft.Win32;
namespace By_Tayo
{
    class Lisanslama
    {
        string baglanti_kodu = "Server=ayancikhost.com;Database=jzkbrugh_akt;Uid=jzkbrugh_muslu;Pwd='B)tbVbTNKB9N';";

        public int ProgramTuru = 1; // Satış ve Teknik Takip Programı

        public string Baglanti_kodu()
        {
            return baglanti_kodu;
        }

        private string MacAdress()
        {
            try
            {
                string query = "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'";
                ManagementObjectSearcher jobQuery = new ManagementObjectSearcher(query);
                ManagementObjectCollection jobs = jobQuery.Get();
                string serialNo = "";
                foreach (ManagementObject job in jobs)
                {
                    serialNo = job["MACAddress"].ToString().Replace(":", "");
                }
                return serialNo;
            }
            catch
            {
                return "";
            }
        }

        private string Product()
        {
            try
            {
                RegistryKey Rkey = Registry.LocalMachine;
                Rkey = Rkey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS");
                return (string)Rkey.GetValue("SystemProductName").ToString();
            }
            catch
            {
                return "";
            }
        }

        public string SistemSaati()
        {
            try
            {
                
                MySqlConnection baglan = new MySqlConnection(baglanti_kodu);
                
                DateTime dateTime = DateTime.MinValue;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.ayancikhost.com/tarih.php");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    baglan.Open();
                    MySqlCommand guncel = new MySqlCommand("select * from Guncel", baglan);
                    MySqlDataReader cek = guncel.ExecuteReader();
                    cek.Read();
                    string tt = cek["tarihvesaat"].ToString();
                    baglan.Close();
                    string reg = "SOFTWARE\\Muslu\\SatisveTeknik";
                    Registry.CurrentUser.CreateSubKey(reg);
                    Registry.CurrentUser.CreateSubKey(reg).SetValue("Gun_Tarih", tt);
                    return tt;
                }
                else
                {
                    return DateTime.Now.ToString("yyyy-MM-dd h:m:s");
                }
                response.Close();

                //return DateTime.Now.ToString("yyyy-MM-dd h:m:s");
            }
            catch
            {
                return "";
            }
        }

        private string BiosSeri()
        {
            try
            {
                ManagementObjectSearcher bios = new ManagementObjectSearcher("Select * From Win32_BIOS");

                foreach (ManagementObject cek in bios.Get())
                {
                    return cek["SerialNumber"].ToString();
                }
                return "";
            }
            catch
            {
                return "";
            }
        }

        public string CPUSeriNo()
        {
            /*
            try
            {
                String processorID = "";
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * FROM WIN32_Processor");
                ManagementObjectCollection mObject = searcher.Get();

                foreach (ManagementObject obj in mObject)
                {
                    processorID = obj["ProcessorId"].ToString();
                }

                return processorID;
            }
            catch
            {
                return "";
            }*/
            try
            {
                return System.Security.Principal.WindowsIdentity.GetCurrent().User.ToString();
            }
            catch
            {
                return "";
            }
        }

        private string KullaniciAdi()
        {
            try
            {
                return System.Environment.UserName.ToString();
            }
            catch
            {
                return "";
            }
        }

        private string MakineAdi()
        {
            try
            {
                return System.Environment.MachineName.ToString();
            }
            catch
            {
                return "";
            }
        }

        private string OsVersion()
        {
            try
            {
                return System.Environment.OSVersion.ToString();
            }
            catch
            {
                return "";
            }
        }

        private string LisansKodu()
        {
            try
            {
                string reg = "SOFTWARE\\Muslu\\SatisveTeknik";
                Registry.CurrentUser.CreateSubKey(reg);
                return Registry.CurrentUser.CreateSubKey(reg).GetValue("Lisans").ToString();
            }
            catch
            {
                return "";
            }
        }

        public byte LisansKontrol()
        {
            MySqlConnection LisansBaglan = new MySqlConnection(baglanti_kodu);
            try
            {
                LisansBaglan.Open();
                MySqlCommand GirdiVarmi = new MySqlCommand("select id from Lisans where pc_serial='" + CPUSeriNo() + "' and program_turu='" + ProgramTuru.ToString() + "'", LisansBaglan);
                object varmi = GirdiVarmi.ExecuteScalar();
                LisansBaglan.Close();
                if (varmi != null)
                {
                    LisansBaglan.Open();
                    MySqlCommand SonAktivite = new MySqlCommand("update Lisans set son_aktivite='" + DateTime.Now.ToString("yyyy-MM-dd h:m:s") + "' where pc_serial='" + CPUSeriNo() + "' and program_turu='" + ProgramTuru.ToString() + "'", LisansBaglan);
                    SonAktivite.ExecuteNonQuery();
                    LisansBaglan.Close();
                    return 1;
                }
                else
                {
                    LisansBaglan.Open();
                    MySqlCommand Girdi = new MySqlCommand("insert into Lisans (baslangic_tarihi,bitis_tarihi,pc_serial,pc_bios,pc_model,pc_kullanici,pc_name,lisans,durum,program_turu) values ('" + DateTime.Now.ToString("yyyy-MM-dd h:m:s") + "','" + DateTime.Now.AddDays(10).ToString("yyyy-MM-dd h:m:s") + "','" + CPUSeriNo() + "','" + BiosSeri() + "','" + Product() + "','" + KullaniciAdi() + "','" + MakineAdi() + "','0','1','" + ProgramTuru + "');", LisansBaglan);
                    Girdi.ExecuteNonQuery();
                    LisansBaglan.Close();
                    string reg = "SOFTWARE\\Muslu\\SatisveTeknik";
                    Registry.CurrentUser.CreateSubKey(reg);
                    Registry.CurrentUser.CreateSubKey(reg).SetValue("Bas_Tarih", DateTime.Now.ToString("yyyy-MM-dd h:m:s"));
                    Registry.CurrentUser.CreateSubKey(reg).SetValue("Bit_Tarih", DateTime.Now.AddDays(10).ToString("yyyy-MM-dd h:m:s"));
                    Registry.CurrentUser.CreateSubKey(reg).SetValue("Durum", "1");
                    Registry.CurrentUser.CreateSubKey(reg).SetValue("Gun_Tarih", "0000-00-00 00:00:00");
                    Registry.CurrentUser.CreateSubKey(reg).SetValue("Lisans", "0");
                    return 3;
                }
                
            }
            catch(Exception e)
            {
                e.Message.ToString();
                return 0;
            }
            
        }

        public byte LisansKontrol2()
        {
            MySqlConnection LisansBaglan = new MySqlConnection(baglanti_kodu);
            MySqlConnection LisansBaglan2 = new MySqlConnection(baglanti_kodu);
            try
            {
                LisansBaglan.Open();
                MySqlCommand GirdiVarmi = new MySqlCommand("select lisans,durum,baslangic_tarihi,bitis_tarihi from Lisans where pc_serial='" + CPUSeriNo() + "' and program_turu='" + ProgramTuru.ToString() + "'", LisansBaglan);
                object varmi = GirdiVarmi.ExecuteScalar();
                LisansBaglan.Close();

                string lisans = "";
                char Durum = '2';
                if (varmi != null)
                {
                    LisansBaglan.Open();
                    MySqlDataReader LisansOku = GirdiVarmi.ExecuteReader();
                    LisansOku.Read();
                    lisans = LisansOku["lisans"].ToString();
                    Durum = char.Parse(LisansOku["durum"].ToString());
                    DateTime BaslangicTarih = DateTime.Parse(LisansOku["baslangic_tarihi"].ToString());
                    DateTime BitisTarih = DateTime.Parse(LisansOku["bitis_tarihi"].ToString());
                    DateTime GuncelTarih = DateTime.Parse(SistemSaati());
                    LisansOku.Close();
                    LisansBaglan.Close();

                    string reg = "SOFTWARE\\Muslu\\SatisveTeknik";
                    Registry.CurrentUser.CreateSubKey(reg);
                    Registry.CurrentUser.CreateSubKey(reg).SetValue("Bas_Tarih", BaslangicTarih.ToString());
                    Registry.CurrentUser.CreateSubKey(reg).SetValue("Bit_Tarih", BitisTarih.ToString());
                    Registry.CurrentUser.CreateSubKey(reg).SetValue("Durum", Durum);
                    if (Durum == '1')
                    {
                        // program açık
                        if (lisans == "0")
                        {
                            // lisanssız deneme süresini kontrol et
                            TimeSpan aralik = BitisTarih - GuncelTarih;
                            if (int.Parse(Math.Round(aralik.TotalDays).ToString()) < 0)
                            {
                                return 101; // deneme süresi bitti.. lisans girme sayfasına aktar.
                            }
                            else
                            {
                                return byte.Parse(Math.Round(aralik.TotalDays).ToString());
                                // default ayarı bu olsun kaç gün denem kaldıgını göstersin
                            }
                        }
                        else
                        {
                            string Lisans = LisansKodu();
                            LisansBaglan.Open();
                            MySqlCommand LisansSor = new MySqlCommand("select id from Lisans_kodlari where Lisans_kodu='" + LisansKodu() + "'", LisansBaglan);
                            object kk1 = LisansSor.ExecuteScalar();
                            // girilen lisansı kontrol et veritabanında varmı
                            if (kk1 != null)
                            {
                                // var
                                MySqlDataReader LisansCek = LisansSor.ExecuteReader();
                                LisansCek.Read();
                                string Lisansid = LisansCek["id"].ToString();
                                // lisans idsini aldık bu lisans birden fazla pc de varsa programı devre dışı bırakacaz.

                                LisansBaglan2.Open();
                                MySqlCommand TabloLisansidKontrol = new MySqlCommand("select count(id) from Lisans where lisans='" + Lisansid + "'", LisansBaglan2);
                                int SaySonuc = 0;
                                SaySonuc = int.Parse(TabloLisansidKontrol.ExecuteScalar().ToString());
                                LisansBaglan2.Close();

                                if (SaySonuc > 1)
                                {
                                    LisansBaglan2.Open();
                                    MySqlCommand KullanimaKapat = new MySqlCommand("update Lisans set durum='0' where lisans='" + Lisansid + "'", LisansBaglan2);
                                    KullanimaKapat.ExecuteNonQuery();
                                    LisansBaglan2.Close();
                                    return 102; // bu lisansı birden fazla kullanıcı kullanıyor.. program durumu hepsini 0 yap... giremesinler 
                                }
                                else
                                {
                                    // bir kullanıcısı var bu kullanıcı bu pc ise aç programı..
                                    LisansBaglan2.Open();
                                    MySqlCommand LisansBilgi = new MySqlCommand("select pc_serial from Lisans where lisans='" + Lisansid + "'", LisansBaglan2);
                                    object kk2 = LisansBilgi.ExecuteScalar();
                                    if (kk2 != null)
                                    {
                                        MySqlDataReader BilgiCek = LisansBilgi.ExecuteReader();
                                        BilgiCek.Read();

                                        string seri = BilgiCek["pc_serial"].ToString();

                                        LisansBaglan2.Close();

                                        if (seri == CPUSeriNo())
                                        {
                                            return 103; // programı aç lisans geçerli
                                        }
                                        else
                                        {
                                            return 104; // bu lisans bu pc için değil haa
                                        }
                                    }
                                    else
                                    {
                                        return 105; // lisans bilgi çekerken hata böyle satır yok 
                                    }
                                    LisansBaglan2.Close();
                                }


                            }
                            else
                            {
                                // yok.. geçersiz lisans
                                return 106;
                            }
                            LisansBaglan.Close();
                        }

                    }
                    else
                    {
                        // programınız devre dışı bırakılmıştır.
                        return 107;
                    }

                }
                else
                {
                    // hata: seri kaydolmamış
                    return 108;
                }
            }
            catch
            {
                return 100;
            }
        }
    }
}
