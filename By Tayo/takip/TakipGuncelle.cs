using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace By_Tayo
{
    public partial class TakipGuncelle : Form
    {
        public TakipGuncelle()
        {
            InitializeComponent();
        }

        Fonksiyonlar fk = new Fonksiyonlar();
        string id = "";
        private void AraButton_Click(object sender, EventArgs e)
        {
            islemler.Items.Clear();
            FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
            FbConnection baglan2 = new FbConnection(fk.Baglanti_Kodu());
            if (AramaText.Text != "")
            {
                if (TkpNo.Checked)
                {
                    baglan.Open();
                    FbCommand TkpNoSql = new FbCommand("SELECT * FROM Teknik_Takip WHERE Takip_no='"+AramaText.Text+"'",baglan);
                    object sonuc; FbDataReader TkpNoOku;
                    sonuc = TkpNoSql.ExecuteScalar();
                    if (sonuc != null)
                    {
                        TkpNoOku = TkpNoSql.ExecuteReader();
                        TkpNoOku.Read();
                        grup3.Enabled = true;
                        grup2.Enabled = false;
                        id = TkpNoOku["Takip_id"].ToString();
                        if (int.Parse(TkpNoOku["Takip_durum"].ToString()) == 1)
                        {
                            grup5.Enabled = true;
                        }
                        else
                        {
                            grup5.Enabled = false;
                        }
                        cihazbilgi.Text = TkpNoOku["Takip_marka"].ToString() + " " + TkpNoOku["Takip_model"].ToString();
                        this.Text = cihazbilgi.Text;
                        baglan2.Open();
                        FbCommand TakipGunSqlSay = new FbCommand("SELECT COUNT(*) FROM TeknikTakipIslemler WHERE Takip_id='" + id + "'", baglan2);
                        object say = TakipGunSqlSay.ExecuteScalar();
                        baglan2.Close();

                        baglan2.Open();
                        FbCommand TakipGunSql = new FbCommand("SELECT * FROM TeknikTakipIslemler WHERE Takip_id='"+id+"'", baglan2);
                        if (int.Parse(say.ToString()) > 0)
                        {
                            FbDataReader TakipGunOku = TakipGunSql.ExecuteReader();
                            while (TakipGunOku.Read())
                            {
                                islemler.Items.Add(TakipGunOku["Takip_bilgi"].ToString());
                            }
                        }
                        else
                        {
                            islemler.Items.Add("Bu cihazda şuanda işlem yapılmamıştır");
                        }
                        baglan2.Close();

                        if (TkpNoOku["Takip_musteri"].ToString() != "")
                        {
                            baglan2.Open();
                            FbCommand MusSql = new FbCommand("SELECT Musteri_adi,Musteri_soyadi,Musteri_telefon FROM Musteriler WHERE Musteri_id='" + TkpNoOku["Takip_musteri"].ToString() + "'", baglan2);
                            FbDataReader MusOku = MusSql.ExecuteReader();
                            MusOku.Read();
                            musadsoyad.Text = MusOku["Musteri_adi"].ToString() + " " + MusOku["Musteri_soyadi"].ToString();
                            mustel.Text = MusOku["Musteri_telefon"].ToString();
                            baglan2.Close();
                        }
                        else
                        {
                            
                            musadsoyad.Text = TkpNoOku["Takip_kisibilgi"].ToString();
                            mustel.Text = TkpNoOku["Takip_kisiTel"].ToString();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Takip bulunamadı ( Hata kodu: T-04 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        grup3.Enabled = false;
                        grup2.Enabled = false;
                        cihazlar.Items.Clear();
                        islemler.Items.Clear();
                        cihazbilgi.Text = "";
                        musadsoyad.Text = "";
                        mustel.Text = "";
                        guncelleme.Text = "";
                        tkpKapat.Checked = false;
                        this.Text = "Takip Güncelleme";
                    }
                    baglan.Close();
                }
                else if (İmeiNo.Checked)
                {

                    baglan.Open();
                    FbCommand TkpNoSql = new FbCommand("SELECT * FROM Teknik_Takip WHERE Takip_imei='" + AramaText.Text + "'", baglan);
                    object sonuc; FbDataReader TkpNoOku;
                    sonuc = TkpNoSql.ExecuteScalar();
                    if (sonuc != null)
                    {
                        TkpNoOku = TkpNoSql.ExecuteReader();
                        TkpNoOku.Read();
                        grup3.Enabled = true;
                        grup2.Enabled = false;
                        id = TkpNoOku["Takip_id"].ToString();
                        if (int.Parse(TkpNoOku["Takip_durum"].ToString()) == 1)
                        {
                            grup5.Enabled = true;
                        }
                        else
                        {
                            grup5.Enabled = false;
                        }
                        cihazbilgi.Text = TkpNoOku["Takip_marka"].ToString() + " " + TkpNoOku["Takip_model"].ToString();
                        this.Text = cihazbilgi.Text;
                        baglan2.Open();
                        FbCommand TakipGunSqlSay = new FbCommand("SELECT COUNT(*) FROM TeknikTakipIslemler WHERE Takip_id='" + id + "'", baglan2);
                        object say = TakipGunSqlSay.ExecuteScalar();
                        baglan2.Close();

                        baglan2.Open();
                        FbCommand TakipGunSql = new FbCommand("SELECT * FROM TeknikTakipIslemler WHERE Takip_id='" + id + "'", baglan2);
                        if (int.Parse(say.ToString()) > 0)
                        {
                            FbDataReader TakipGunOku = TakipGunSql.ExecuteReader();
                            while (TakipGunOku.Read())
                            {
                                islemler.Items.Add(TakipGunOku["Takip_bilgi"].ToString());
                            }
                        }
                        else
                        {
                            islemler.Items.Add("Bu cihazda şuanda işlem yapılmamıştır");
                        }
                        baglan2.Close();

                        if (TkpNoOku["Takip_musteri"].ToString() != "")
                        {
                            baglan2.Open();
                            FbCommand MusSql = new FbCommand("SELECT Musteri_adi,Musteri_soyadi,Musteri_telefon FROM Musteriler WHERE Musteri_id='" + TkpNoOku["Takip_musteri"].ToString() + "'", baglan2);
                            FbDataReader MusOku = MusSql.ExecuteReader();
                            MusOku.Read();
                            musadsoyad.Text = MusOku["Musteri_adi"].ToString() + " " + MusOku["Musteri_soyadi"].ToString();
                            mustel.Text = MusOku["Musteri_telefon"].ToString();
                            baglan2.Close();
                        }
                        else
                        {

                            musadsoyad.Text = TkpNoOku["Takip_kisibilgi"].ToString();
                            mustel.Text = TkpNoOku["Takip_kisiTel"].ToString();
                        }
                        baglan.Close();
                    }
                    else
                    {
                        MessageBox.Show("Takip bulunamadı ( Hata kodu: T-04 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        grup3.Enabled = false;
                        grup2.Enabled = false;
                        cihazlar.Items.Clear();
                        islemler.Items.Clear();
                        cihazbilgi.Text = "";
                        musadsoyad.Text = "";
                        mustel.Text = "";
                        guncelleme.Text = "";
                        tkpKapat.Checked = false; this.Text = "Takip Güncelleme";
                    }
                    baglan.Close();
                }
                else if (SeriNo.Checked)
                {
                    baglan.Open();
                    FbCommand TkpNoSql = new FbCommand("SELECT * FROM Teknik_Takip WHERE Takip_serino='" + AramaText.Text + "'", baglan);
                    object sonuc; FbDataReader TkpNoOku;
                    sonuc = TkpNoSql.ExecuteScalar();
                    if (sonuc != null)
                    {
                        TkpNoOku = TkpNoSql.ExecuteReader();
                        TkpNoOku.Read();
                        grup2.Enabled = false;
                        id = TkpNoOku["Takip_id"].ToString();
                        if (int.Parse(TkpNoOku["Takip_durum"].ToString()) == 1)
                        {
                            grup5.Enabled = true;
                        }
                        else
                        {
                            grup5.Enabled = false;
                        }
                        cihazbilgi.Text = TkpNoOku["Takip_marka"].ToString() + " " + TkpNoOku["Takip_model"].ToString();
                        this.Text = cihazbilgi.Text;
                        baglan2.Open();
                        FbCommand TakipGunSqlSay = new FbCommand("SELECT COUNT(*) FROM TeknikTakipIslemler WHERE Takip_id='" + id + "'", baglan2);
                        object say = TakipGunSqlSay.ExecuteScalar();
                        baglan2.Close();

                        baglan2.Open();
                        FbCommand TakipGunSql = new FbCommand("SELECT * FROM TeknikTakipIslemler WHERE Takip_id='" + id + "'", baglan2);
                        if (int.Parse(say.ToString()) > 0)
                        {
                            FbDataReader TakipGunOku = TakipGunSql.ExecuteReader();
                            while (TakipGunOku.Read())
                            {
                                islemler.Items.Add(TakipGunOku["Takip_bilgi"].ToString());
                            }
                        }
                        else
                        {
                            islemler.Items.Add("Bu cihazda şuanda işlem yapılmamıştır");
                        }
                        baglan2.Close();

                        if (TkpNoOku["Takip_musteri"].ToString() != "")
                        {
                            baglan2.Open();
                            FbCommand MusSql = new FbCommand("SELECT Musteri_adi,Musteri_soyadi,Musteri_telefon FROM Musteriler WHERE Musteri_id='" + TkpNoOku["Takip_musteri"].ToString() + "'", baglan2);
                            FbDataReader MusOku = MusSql.ExecuteReader();
                            MusOku.Read();
                            musadsoyad.Text = MusOku["Musteri_adi"].ToString() + " " + MusOku["Musteri_soyadi"].ToString();
                            mustel.Text = MusOku["Musteri_telefon"].ToString();
                            baglan2.Close();
                        }
                        else
                        {

                            musadsoyad.Text = TkpNoOku["Takip_kisibilgi"].ToString();
                            mustel.Text = TkpNoOku["Takip_kisiTel"].ToString();
                        }
                        baglan.Close();

                    }
                    else
                    {
                        MessageBox.Show("Takip bulunamadı ( Hata kodu: T-04 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        grup3.Enabled = false;
                        grup2.Enabled = false;
                        cihazlar.Items.Clear();
                        islemler.Items.Clear();
                        cihazbilgi.Text = "";
                        musadsoyad.Text = "";
                        mustel.Text = "";
                        guncelleme.Text = "";
                        tkpKapat.Checked = false; this.Text = "Takip Güncelleme";
                    }
                    baglan.Close();
                }
                else if (AdveSoyad.Checked)
                {
                    baglan.Open();
                    FbCommand TkpNoSql = new FbCommand("SELECT * FROM Teknik_Takip WHERE Takip_kisibilgi like '%" + fk.IlkHarfleriBuyut(AramaText.Text) + "%' or Takip_musteri in ( SELECT Musteri_id FROM Musteriler WHERE Musteri_adi like '%" + fk.IlkHarfleriBuyut(AramaText.Text) + "%' or Musteri_soyadi like '%" + fk.IlkHarfleriBuyut(AramaText.Text) + "%')", baglan);
                    object sonuc; FbDataReader TkpNoOku;
                    sonuc = TkpNoSql.ExecuteScalar();
                    if (sonuc != null)
                    {
                        TkpNoOku = TkpNoSql.ExecuteReader();
                        grup2.Enabled = true;
                        cihazlar.Items.Clear();
                        while (TkpNoOku.Read())
                        {
                            cihazlar.Items.Add( TkpNoOku["Takip_id"].ToString() + " "+TkpNoOku["Takip_marka"].ToString() + " " + TkpNoOku["Takip_model"].ToString() );
                        }
                        cihazlar.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Takip bulunamadı ( Hata kodu: T-04 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        grup3.Enabled = false;
                        islemler.Items.Clear();
                        cihazbilgi.Text = "";
                        musadsoyad.Text = "";
                        mustel.Text = "";
                        guncelleme.Text = "";
                        tkpKapat.Checked = false; this.Text = "Takip Güncelleme";
                    }
                    baglan.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen veri giriniz ( Hata kodu: T-05 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            
            if (guncelleme.Text != "")
            {
                byte sonuc;
                sonuc = fk.Ekle("TeknikTakipIslemler","Takip_id,Takip_bilgi","'"+id+"','"+guncelleme.Text+"'");
                islemler.Items.Add(guncelleme.Text);
                if (sonuc == 1)
                {
                    islemler.SelectedIndex = 0;
                    if (islemler.Text == "Bu cihazda şuanda işlem yapılmamıştır")
                    {
                        islemler.Items.Clear();
                        islemler.Items.Add(guncelleme.Text);
                        islemler.SelectedIndex = -1;
                    }
                    else
                    {
                        islemler.SelectedIndex = -1;
                    }
                    MessageBox.Show("Takip başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guncelleme.Text = "";
                }
                else
                    MessageBox.Show("Takip güncellenemedi ( Hata kodu: T-06 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (tkpKapat.Checked)
                {
                    byte sonuc1;
                    string tarih = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    sonuc1 = fk.Guncelle("Teknik_Takip", "Takip_kapanisTarih='"+tarih+"',Takip_durum='0'","Takip_id='"+id+"'");
                    if (sonuc1 == 1)
                    {
                        MessageBox.Show("Takip başarıyla kapatılmıştır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fk.Ekle("TeknikTakipIslemler", "Takip_id,Takip_bilgi", "'" + id + "','Tüm işlemler tamamlanmıştır.'");
                        islemler.Items.Add("Tüm işlemler tamamlanmıştır.");
                        grup5.Enabled = false;
                    }
                    else
                        MessageBox.Show("Takip kapatılamadı ( Hata kodu: T-07 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (guncelleme.Text == "" && tkpKapat.Checked == true)
            {
                byte sonuc;
                string tarih = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                sonuc = fk.Guncelle("Teknik_Takip", "Takip_kapanisTarih='" + tarih + "',Takip_durum='0'", "Takip_id='" + id + "'");
                if (sonuc == 1)
                {
                    MessageBox.Show("Takip başarıyla kapatılmıştır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fk.Ekle("TeknikTakipIslemler", "Takip_id,Takip_bilgi", "'" + id + "','Tüm işlemler tamamlanmıştır.'");
                    islemler.Items.Add("Tüm işlemler tamamlanmıştır.");
                    grup5.Enabled = false;
                }
                else
                    MessageBox.Show("Takip kapatılamadı ( Hata kodu: T-07 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Güncelleme bilgisini giriniz ( Hata kodu: T-08 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cihazlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cihazlar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string[] ads = cihazlar.Text.Split(' ');
            islemler.Items.Clear();
            FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
            FbConnection baglan2 = new FbConnection(fk.Baglanti_Kodu());
            baglan.Open();
            FbCommand TkpNoSql = new FbCommand("SELECT * FROM Teknik_Takip WHERE Takip_id='" + ads[0] + "'", baglan);
            object sonuc; FbDataReader TkpNoOku;
            sonuc = TkpNoSql.ExecuteScalar();
            if (sonuc != null)
            {
                TkpNoOku = TkpNoSql.ExecuteReader();
                TkpNoOku.Read();
                grup3.Enabled = true;
                id = TkpNoOku["Takip_id"].ToString();
                if (int.Parse(TkpNoOku["Takip_durum"].ToString()) == 1)
                {
                    grup5.Enabled = true;
                }
                else
                {
                    grup5.Enabled = false;
                }
                cihazbilgi.Text = TkpNoOku["Takip_marka"].ToString() + " " + TkpNoOku["Takip_model"].ToString();
                this.Text = cihazbilgi.Text;
                baglan2.Open();
                FbCommand TakipGunSqlSay = new FbCommand("SELECT COUNT(*) FROM TeknikTakipIslemler WHERE Takip_id='" + id + "'", baglan2);
                object say = TakipGunSqlSay.ExecuteScalar();
                baglan2.Close();

                baglan2.Open();
                FbCommand TakipGunSql = new FbCommand("SELECT * FROM TeknikTakipIslemler WHERE Takip_id='" + id + "'", baglan2);
                if (int.Parse(say.ToString()) > 0)
                {
                    FbDataReader TakipGunOku = TakipGunSql.ExecuteReader();
                    while (TakipGunOku.Read())
                    {
                        islemler.Items.Add(TakipGunOku["Takip_bilgi"].ToString());
                    }
                }
                else
                {
                    islemler.Items.Add("Bu cihazda şuanda işlem yapılmamıştır");
                }
                baglan2.Close();

                if (TkpNoOku["Takip_musteri"].ToString() != "")
                {
                    string mmid = TkpNoOku["Takip_musteri"].ToString();
                    baglan2.Open();
                    FbCommand MusSql = new FbCommand("SELECT Musteri_adi,Musteri_soyadi,Musteri_telefon FROM Musteriler WHERE Musteri_id='" + mmid + "'", baglan2);
                    FbDataReader MusOku = MusSql.ExecuteReader();
                    MusOku.Read();
                    musadsoyad.Text = MusOku["Musteri_adi"].ToString() + " " + MusOku["Musteri_soyadi"].ToString();
                    mustel.Text = MusOku["Musteri_telefon"].ToString();
                    baglan2.Close();
                }
                else
                {

                    musadsoyad.Text = TkpNoOku["Takip_kisibilgi"].ToString();
                    mustel.Text = TkpNoOku["Takip_kisiTel"].ToString();
                }

            }
            else
            {
                MessageBox.Show("Takip bulunamadı ( Hata kodu: T-04 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglan.Close();
        }
    }
}
