using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Win32;

namespace By_Tayo
{
    public partial class Lisans : Form
    {
        public Lisans()
        {
            InitializeComponent();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                GirisEkran Kf = (GirisEkran)Application.OpenForms["GirisEkran"];
                Kf.LisansKontrol();
                this.Close();
            }
            catch
            {

            }

        }

        private void Kontrol_Click(object sender, EventArgs e)
        {
            Lisanslama ls = new Lisanslama(); string id = ""; string serial = "";
            MySqlConnection baglan = new MySqlConnection(ls.Baglanti_kodu());
            MySqlConnection baglan2 = new MySqlConnection(ls.Baglanti_kodu());
            if (GirilenLisans.Text.Length >= 26)
            {
                baglan.Open();
                MySqlCommand KodKontrol = new MySqlCommand("select * from Lisans_kodlari where Lisans_kodu='" + GirilenLisans.Text + "'", baglan);
                object k1 = KodKontrol.ExecuteScalar();
                if (k1 != null)
                {
                    // var..
                    MySqlDataReader idCek = KodKontrol.ExecuteReader();
                    idCek.Read();
                    id = idCek["id"].ToString();
                    idCek.Close();

                    baglan2.Open();
                    MySqlCommand LisansidSay = new MySqlCommand("select count(*) from Lisans where lisans='"+id+"'", baglan2);
                    int say = int.Parse(LisansidSay.ExecuteScalar().ToString());
                    baglan2.Close();
                    if (say < 1)
                    {
                        baglan2.Open();
                        MySqlCommand LisansAktiflestir = new MySqlCommand("update Lisans set lisans='" + id + "',durum='1' where pc_serial='" + ls.CPUSeriNo() + "' and program_turu='" + ls.ProgramTuru.ToString() + "'", baglan2);
                        LisansAktiflestir.ExecuteNonQuery();
                        string reg = "SOFTWARE\\Muslu\\SatisveTeknik";
                        Registry.CurrentUser.CreateSubKey(reg);
                        Registry.CurrentUser.CreateSubKey(reg).SetValue("Lisans", GirilenLisans.Text);
                        MessageBox.Show("Girdiğiniz lisans başarıyla kayıt edilmiştir.", "Lisans Etkinleştirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        baglan2.Close();
                    }
                    else
                    {
                        baglan2.Open();
                        MySqlCommand LisansAkt = new MySqlCommand("select * from Lisans where lisans='" + id + "'", baglan2);
                        object k3 = LisansAkt.ExecuteScalar();
                        if (k3 != null)
                        {
                            MySqlDataReader SerialCek = LisansAkt.ExecuteReader(); SerialCek.Read();
                            serial = SerialCek["pc_serial"].ToString();
                            SerialCek.Close();
                            if (serial == ls.CPUSeriNo())
                            {
                                MySqlCommand LisansAktiflestir = new MySqlCommand("update Lisans set lisans='" + id + "',durum='1' where pc_serial='" + ls.CPUSeriNo() + "' and program_turu='" + ls.ProgramTuru.ToString() + "'", baglan2);
                                LisansAktiflestir.ExecuteNonQuery();
                                string reg = "SOFTWARE\\Muslu\\SatisveTeknik";
                                Registry.CurrentUser.CreateSubKey(reg);
                                Registry.CurrentUser.CreateSubKey(reg).SetValue("Lisans", GirilenLisans.Text);
                                MessageBox.Show("Girdiğiniz lisans başarıyla kayıt edilmiştir.", "Lisans Etkinleştirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Girdiğiniz lisans daha önce kullanılmıştır.", "Lisans Etkinleştirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        baglan2.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Girdiğiniz lisans kodu geçersizdir.", "Lisans Etkinleştirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    baglan.Close();
            }
            else
            {
                MessageBox.Show("Girdiğiniz lisans kodu geçersizdir.", "Lisans Etkinleştirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
