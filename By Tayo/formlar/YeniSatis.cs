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
    public partial class YeniSatis : Form
    {
        public YeniSatis()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        string satis_urun = "", satis_kategori = ""; float sFiyat = 0,ssFiyat = 0;
        private void YeniSatis_Load(object sender, EventArgs e)
        {
            try
            {
                SatisUrunKategorisi.Items.Clear();
                byte i = 0;
                string ilkid = "";
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbDataReader oku;
                FbCommand katlist = new FbCommand("SELECT * FROM Urun_kategori", baglan);
                object sonuc = katlist.ExecuteScalar();
                if (sonuc != null)
                {
                    oku = katlist.ExecuteReader();
                    while (oku.Read())
                    {
                        SatisUrunKategorisi.Items.Add(oku["Kategori_adi"].ToString());
                        if (i == 0)
                        {
                            ilkid = oku["Kategori_id"].ToString();
                            i = 1;
                        }
                    }
                    SatisUrunKategorisi.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Ürün kategorisi ekleyin", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    UrunKategoriEkle uke = new UrunKategoriEkle();
                    uke.ShowDialog();
                }
                baglan.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SatisUrunKategorisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string id = "";
                SatisUrun.Items.Clear();
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbCommand KatidAl = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_adi='" + SatisUrunKategorisi.Text + "'", baglan);
                object e1 = KatidAl.ExecuteScalar();
                if (e1 != null)
                {
                    FbDataReader Katidoku = KatidAl.ExecuteReader();
                    Katidoku.Read();
                    id = Katidoku["Kategori_id"].ToString(); Katidoku.Close();
                }
                else
                {
                    MessageBox.Show("Sistemsel bir sorun oluştu, lütfen sağlayıcınıza başvurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglan.Close();

                baglan.Open();
                FbCommand urunList = new FbCommand("SELECT * FROM Urunler WHERE Urun_kategori='" + id + "' order by Urun_adi asc", baglan);
                object sonuc = urunList.ExecuteScalar();
                if (sonuc != null)
                {
                    FbDataReader oku2 = urunList.ExecuteReader();
                    SatisUrun.Enabled = true;
                    YeniSatisBtn.Enabled = true;
                    while (oku2.Read())
                    {
                        SatisUrun.Items.Add(oku2["Urun_adi"].ToString());
                    }
                    //if(SatisUrun.Text != "")
                    SatisUrun.SelectedIndex = 0;
                }
                else
                {
                    SatisUrun.Enabled = false;
                    YeniSatisBtn.Enabled = false;
                    MessageBox.Show("Bu kategoride henüz ürün eklenmemiş", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                baglan.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SatisUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbCommand UrunBilgi = new FbCommand("SELECT Urun_fiyat FROM Urunler WHERE Urun_adi='" + SatisUrun.Text + "'", baglan);
                object e2 = UrunBilgi.ExecuteScalar();
                if (e2 != null)
                {
                    FbDataReader UrunOku = UrunBilgi.ExecuteReader();
                    UrunOku.Read(); sFiyat = float.Parse(UrunOku["Urun_fiyat"].ToString()); UrunOku.Close();
                    SatisTutar.Text = (sFiyat * float.Parse((SatisAdet.Value.ToString()))).ToString();
                }
                else
                {
                    MessageBox.Show("Sistemsel bir sorun oluştu, lütfen sağlayıcınıza başvurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglan.Close();
            }
            catch (Exception e3)
            {
                MessageBox.Show(e3.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KayitliMi1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SatisMusteri.Items.Clear();
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbCommand MustList = new FbCommand("SELECT * FROM Musteriler", baglan);
                object sonuc = MustList.ExecuteScalar();
                if (sonuc != null)
                {
                    FbDataReader oku = MustList.ExecuteReader();
                    SatisMusteri.Enabled = true;
                    checkBox1.Enabled = true;
                    while (oku.Read())
                    {
                        SatisMusteri.Items.Add(oku["Musteri_adi"].ToString() + " " + oku["Musteri_soyadi"].ToString());
                    }
                    SatisMusteri.SelectedIndex = 0;
                }
                else
                {
                    SatisMusteri.Enabled = false;
                    checkBox1.Enabled = false;
                    MessageBox.Show("Kayıtlı müşteri bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SatisMusteriG.Enabled = false;
                    musara.Text = "";
                    SatisMusteri.SelectedIndex = -1;
                    checkBox1.Checked = false;
                }
                baglan.Close();
                musara.Text = "";
                checkBox1.Checked = false;

                if (KayitliMi1.Checked)
                {
                    SatisMusteriG.Enabled = true;
                }
                else
                {
                    SatisMusteriG.Enabled = false;
                    SatisMusteri.SelectedIndex = -1;
                    SatisMusteri.Text = "";
                }
            }
            catch (Exception e4)
            {
                MessageBox.Show(e4.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void YeniSatisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string satis_urun = "", satis_musteri = "", satis_kategori = ""; byte sonuc, sonuc1;
                float bakiye = 0, tutar = 0;
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());

                baglan.Open();
                FbCommand UrunBilgi = new FbCommand("SELECT Urun_id FROM Urunler WHERE Urun_adi='" + SatisUrun.Text + "'", baglan);
                object s1 = UrunBilgi.ExecuteScalar();
                if (s1 != null)
                {
                    FbDataReader UrunOku = UrunBilgi.ExecuteReader();
                    UrunOku.Read(); satis_urun = UrunOku["Urun_id"].ToString(); UrunOku.Close();
                }
                else
                {
                    MessageBox.Show("Sistemsel bir sorun oluştu, lütfen sağlayıcınıza başvurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglan.Close();

                baglan.Open();
                FbCommand KategoriBilgi = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_adi='" + SatisUrunKategorisi.Text + "'", baglan);
                object s2 = KategoriBilgi.ExecuteScalar();
                if (s2 != null)
                {
                    FbDataReader KategoriOku = KategoriBilgi.ExecuteReader();
                    KategoriOku.Read(); satis_kategori = KategoriOku["Kategori_id"].ToString(); KategoriOku.Close();
                }
                else
                {
                    MessageBox.Show("Sistemsel bir sorun oluştu, lütfen sağlayıcınıza başvurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglan.Close();

                int satisadet = int.Parse(SatisAdet.Value.ToString());
                int satisSay = 0;
                for (int i = 1; i <= satisadet; i++)
                {
                    if (KayitliMi1.Checked)
                    {
                        string[] ads = SatisMusteri.Text.Split(' ');
                        baglan.Open();
                        FbCommand MusBilgi = new FbCommand("SELECT Musteri_id,Musteri_bakiye FROM Musteriler WHERE Musteri_adi='" + ads[0] + "' and Musteri_soyadi='" + ads[1] + "'", baglan);
                        object s3 = MusBilgi.ExecuteScalar();
                        if (s3 != null)
                        {
                            FbDataReader MusOku = MusBilgi.ExecuteReader();
                            MusOku.Read(); satis_musteri = MusOku["Musteri_id"].ToString(); bakiye = float.Parse(MusOku["Musteri_bakiye"].ToString()); MusOku.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sistemsel bir sorun oluştu, lütfen sağlayıcınıza başvurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        baglan.Close();
                    }
                    string tarih = DateTime.Now.Year.ToString(); tarih += '-' + DateTime.Now.Month.ToString(); tarih += '-' + DateTime.Now.Day.ToString();
                    if (satis_musteri == "")
                    {
                        sonuc = fk.Ekle("Satis", "Satis_urun,Satis_tarih,Satis_not", "'" + satis_urun + "','" + tarih + "','" + SatisNot.Text + "'");
                        baglan.Open();
                        FbCommand UrunVarMi = new FbCommand("SELECT rapor_satisId,rapor_tarih FROM Rapor WHERE rapor_satisId='" + satis_urun + "' and rapor_tarih='" + tarih + "'", baglan);
                        object varmi = UrunVarMi.ExecuteScalar();
                        if (varmi != null)
                        {
                            sonuc1 = fk.Guncelle("Rapor", "rapor_sayac=rapor_sayac+1", "rapor_satisId='" + satis_urun + "' and rapor_tarih='" + tarih + "'");
                        }
                        else
                        {
                            sonuc1 = fk.Ekle("Rapor", "rapor_satisId,rapor_satisKt,rapor_sayac,rapor_tarih", "'" + satis_urun + "','" + satis_kategori + "','1','" + tarih + "'");
                        }
                        baglan.Close();
                        if (sonuc == 1 && sonuc1 == 1)
                        {
                            satisSay++;
                        }
                        else
                            satisSay = satisSay + 0;
                    }
                    else
                    {
                        sonuc = fk.Ekle("Satis", "Satis_urun,Satis_musteri,Satis_tarih,Satis_not", "'" + satis_urun + "','" + satis_musteri + "','" + tarih + "','" + SatisNot.Text + "'");
                        baglan.Open();
                        FbCommand UrunVarMi = new FbCommand("SELECT rapor_satisId,rapor_tarih FROM Rapor WHERE rapor_satisId='" + satis_urun + "' and rapor_tarih='" + tarih + "'", baglan);
                        object varmi = UrunVarMi.ExecuteScalar();
                        if (varmi != null)
                        {
                            sonuc1 = fk.Guncelle("Rapor", "rapor_sayac=rapor_sayac+1", "rapor_satisId='" + satis_urun + "' and rapor_tarih='" + tarih + "'");
                        }
                        else
                        {
                            sonuc1 = fk.Ekle("Rapor", "rapor_satisId,rapor_satisKt,rapor_sayac,rapor_tarih", "'" + satis_urun + "','" + satis_kategori + "','1','" + tarih + "'");
                        }
                        baglan.Close();
                        if (sonuc == 1 && sonuc1 == 1)
                        {
                            satisSay++;
                            if (checkBox1.Checked)
                            {
                                tutar = float.Parse(SatisTutar.Text);
                                bakiye = bakiye - tutar;
                                ybakiye.Text = bakiye.ToString();
                                ybakiye.Text = ybakiye.Text.Replace(',', '.');
                                fk.Guncelle("Musteriler", "Musteri_bakiye='" + ybakiye.Text + "'", "Musteri_id='" + satis_musteri + "'");
                            }
                        }
                        else
                            satisSay = satisSay + 0;

                    }
                }
                if (satisSay > 0)
                {
                    MessageBox.Show("Satış başarıyla eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SatisAdet.Value = 1;
                    SatisNot.Text = "";
                }
                else
                {
                    MessageBox.Show("Satış eklenemedi ( Hata kodu: S-01 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e4)
            {
                MessageBox.Show(e4.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BarkodAra_Click(object sender, EventArgs e)
        {
        }

        private void YeniSatisBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                string satis_musteri = ""; byte sonuc; byte sonuc1; float tutar = 0, bakiye = 0;
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());

                int satisadet = int.Parse(SatisAdetBarkod.Value.ToString());
                int eklesay = 0;
                for (int i = 1; i <= satisadet; i++)
                {
                    if (KayitliMi2.Checked)
                    {
                        string[] ads = SatisMusteriCb.Text.Split(' ');
                        baglan.Open();
                        FbCommand MusBilgi = new FbCommand("SELECT Musteri_id,Musteri_bakiye FROM Musteriler WHERE Musteri_adi='" + ads[0] + "' and Musteri_soyadi='" + ads[1] + "'", baglan);
                        FbDataReader MusOku = MusBilgi.ExecuteReader();
                        MusOku.Read(); satis_musteri = MusOku["Musteri_id"].ToString(); bakiye = float.Parse(MusOku["Musteri_bakiye"].ToString()); MusOku.Close(); baglan.Close();
                    }
                    string tarih = DateTime.Now.Year.ToString(); tarih += '-' + DateTime.Now.Month.ToString(); tarih += '-' + DateTime.Now.Day.ToString();
                    if (satis_musteri == "")
                    {
                        sonuc = fk.Ekle("Satis", "Satis_urun,Satis_tarih,Satis_not", "'" + satis_urun + "','" + tarih + "','" + SatisNot.Text + "'");
                        if (sonuc == 1)
                        {
                            baglan.Open();
                            FbCommand UrunVarMi = new FbCommand("SELECT rapor_satisId,rapor_tarih FROM Rapor WHERE rapor_satisId='" + satis_urun + "' and rapor_tarih='" + tarih + "'", baglan);
                            object varmi = UrunVarMi.ExecuteScalar();
                            if (varmi != null)
                            {
                                sonuc1 = fk.Guncelle("Rapor", "rapor_sayac=rapor_sayac+1", "rapor_satisId='" + satis_urun + "' and rapor_tarih='" + tarih + "'");
                            }
                            else
                            {
                                sonuc1 = fk.Ekle("Rapor", "rapor_satisId,rapor_satisKt,rapor_sayac,rapor_tarih", "'" + satis_urun + "','" + satis_kategori + "','1','" + tarih + "'");
                            }
                            baglan.Close();
                            eklesay++;
                        }
                        else
                            eklesay = eklesay + 0;
                    }
                    else
                    {
                        sonuc = fk.Ekle("Satis", "Satis_urun,Satis_musteri,Satis_tarih,Satis_not", "'" + satis_urun + "','" + satis_musteri + "','" + tarih + "','" + SatisNot.Text + "'");
                        if (sonuc == 1)
                        {
                            baglan.Open();
                            FbCommand UrunVarMi = new FbCommand("SELECT rapor_satisId,rapor_tarih FROM Rapor WHERE rapor_satisId='" + satis_urun + "' and rapor_tarih='" + tarih + "'", baglan);
                            object varmi = UrunVarMi.ExecuteScalar();
                            if (varmi != null)
                            {
                                sonuc1 = fk.Guncelle("Rapor", "rapor_sayac=rapor_sayac+1", "rapor_satisId='" + satis_urun + "' and rapor_tarih='" + tarih + "'");
                            }
                            else
                            {
                                sonuc1 = fk.Ekle("Rapor", "rapor_satisId,rapor_satisKt,rapor_sayac,rapor_tarih", "'" + satis_urun + "','" + satis_kategori + "','1','" + tarih + "'");
                            }
                            baglan.Close();
                            eklesay++;
                            if (checkBox3.Checked)
                            {
                                tutar = float.Parse(SatisTutar.Text);
                                bakiye = bakiye - tutar;
                                ybakiye.Text = bakiye.ToString();
                                ybakiye.Text = ybakiye.Text.Replace(',', '.');
                                fk.Guncelle("Musteriler", "Musteri_bakiye='" + ybakiye.Text + "'", "Musteri_id='" + satis_musteri + "'");
                            }
                        }
                        else
                            eklesay = eklesay + 0;
                    }
                }
                if (eklesay > 0)
                {
                    MessageBox.Show("Satış başarıyla eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Satış eklenemedi ( Hata kodu: S-01 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                eklesay = 0;
                BarkodNo.Text = "";
            }
            catch (Exception e5)
            {
                MessageBox.Show(e5.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KayitliMi2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SatisMusteriCb.Items.Clear();
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbCommand MustList = new FbCommand("SELECT * FROM Musteriler", baglan);
                object sonuc = MustList.ExecuteScalar();
                if (sonuc != null)
                {
                    FbDataReader oku = MustList.ExecuteReader();
                    SatisMusteri.Enabled = true;
                    checkBox3.Enabled = true;
                    while (oku.Read())
                    {
                        SatisMusteriCb.Items.Add(oku["Musteri_adi"].ToString() + " " + oku["Musteri_soyadi"].ToString());
                    }
                    SatisMusteriCb.SelectedIndex = 0;
                }
                else
                {
                    SatisMusteri.Enabled = false;
                    checkBox3.Enabled = false;
                    MessageBox.Show("Kayıtlı müşteri bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SatisMusteriB.Enabled = false;
                }
                baglan.Close();
                textBox1.Text = "";
                checkBox3.Checked = false;
                if (KayitliMi2.Checked)
                {
                    SatisMusteriB.Enabled = true;
                }
                else
                {
                    SatisMusteriB.Enabled = false;

                    SatisMusteriCb.SelectedIndex = -1;
                }
            }
            catch (Exception e6)
            {
                MessageBox.Show(e6.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SatisAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SatisAdetBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BarkodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void musara_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (musara.Text != "")
                {
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                    FbDataReader MusteriOku; object sonuc;
                    string adsD = fk.IlkHarfleriBuyut(musara.Text);
                    baglanti.Open();
                    FbCommand MusteriAraSorgu = new FbCommand("SELECT * FROM Musteriler WHERE Musteri_adi like '%" + musara.Text + "%' or Musteri_soyadi like '%" + musara.Text + "%' or Musteri_adi like '%" + adsD + "%' or Musteri_soyadi like '%" + adsD + "%'", baglanti);
                    sonuc = MusteriAraSorgu.ExecuteScalar();
                    SatisMusteri.Items.Clear();
                    if (sonuc != null)
                    {
                        MusteriOku = MusteriAraSorgu.ExecuteReader();
                        while (MusteriOku.Read())
                        {
                            SatisMusteri.Items.Add(MusteriOku["Musteri_adi"].ToString() + " " + MusteriOku["Musteri_soyadi"].ToString());
                        }
                        SatisMusteri.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Aranan isme / soyisme göre müşteri bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        musara.Text = "";
                        FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                        baglan.Open();
                        FbCommand MustList = new FbCommand("SELECT * FROM Musteriler", baglan);
                        object sonuc1 = MustList.ExecuteScalar();
                        if (sonuc1 != null)
                        {
                            FbDataReader oku = MustList.ExecuteReader();
                            SatisMusteri.Enabled = true;
                            checkBox1.Enabled = true;
                            while (oku.Read())
                            {
                                SatisMusteri.Items.Add(oku["Musteri_adi"].ToString() + " " + oku["Musteri_soyadi"].ToString());
                            }
                            SatisMusteri.SelectedIndex = 0;
                        }
                        else
                        {
                            SatisMusteri.Enabled = false;
                            checkBox1.Enabled = false;
                            MessageBox.Show("Kayıtlı müşteri bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        baglan.Close();
                    }
                    baglanti.Close();
                }
            }
            catch (Exception e11)
            {
                MessageBox.Show(e11.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                    FbDataReader MusteriOku; object sonuc;
                    string adsD = fk.IlkHarfleriBuyut(textBox1.Text);
                    baglanti.Open();
                    FbCommand MusteriAraSorgu = new FbCommand("SELECT * FROM Musteriler WHERE Musteri_adi like '%" + textBox1.Text + "%' or Musteri_soyadi like '%" + textBox1.Text + "%' or Musteri_adi like '%" + adsD + "%' or Musteri_soyadi like '%" + adsD + "%'", baglanti);
                    sonuc = MusteriAraSorgu.ExecuteScalar();
                    SatisMusteriCb.Items.Clear();
                    if (sonuc != null)
                    {
                        MusteriOku = MusteriAraSorgu.ExecuteReader();
                        while (MusteriOku.Read())
                        {
                            SatisMusteriCb.Items.Add(MusteriOku["Musteri_adi"].ToString() + " " + MusteriOku["Musteri_soyadi"].ToString());
                        }
                        SatisMusteriCb.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Aranan isme / soyisme göre müşteri bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox1.Text = "";
                        FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                        baglan.Open();
                        FbCommand MustList = new FbCommand("SELECT * FROM Musteriler", baglan);
                        object sonuc1 = MustList.ExecuteScalar();
                        if (sonuc1 != null)
                        {
                            FbDataReader oku = MustList.ExecuteReader();
                            SatisMusteriCb.Enabled = true;
                            checkBox3.Enabled = true;
                            while (oku.Read())
                            {
                                SatisMusteriCb.Items.Add(oku["Musteri_adi"].ToString() + " " + oku["Musteri_soyadi"].ToString());
                            }
                            SatisMusteriCb.SelectedIndex = 0;
                        }
                        else
                        {
                            SatisMusteriCb.Enabled = false;
                            checkBox3.Enabled = false;
                            MessageBox.Show("Kayıtlı müşteri bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        baglan.Close();
                    }
                    baglanti.Close();
                }
            }
            catch (Exception e12)
            {
                MessageBox.Show(e12.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BarkodNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (BarkodNo.Text.Length > 14 && BarkodNo.Text != "000000000000000")
                {
                    // barkoda göre arattır
                    if (BarkodNo.Text != "")
                    {
                        FbDataReader oku; object barkod;
                        FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                        FbConnection baglanti2 = new FbConnection(fk.Baglanti_Kodu());
                        FbCommand UrunBarkodSorgu = new FbCommand("SELECT * FROM Urunler where Urun_barkodNo='" + BarkodNo.Text + "'", baglanti);
                        baglanti.Open();
                        barkod = UrunBarkodSorgu.ExecuteScalar();
                        if (barkod != null)
                        {
                            groupBox3.Enabled = true;
                            oku = UrunBarkodSorgu.ExecuteReader();
                            oku.Read();
                            UrunAdiBarkod.Text = oku["Urun_adi"].ToString();
                            ssFiyat = float.Parse(oku["Urun_fiyat"].ToString());
                            ssFiyat = (ssFiyat * float.Parse((SatisAdetBarkod.Value).ToString()));
                            SatisTutarBarkod.Text = (ssFiyat * float.Parse((SatisAdetBarkod.Value).ToString())).ToString();
                            satis_urun = oku["Urun_id"].ToString();
                            satis_kategori = oku["Urun_kategori"].ToString();
                            SatisAdetBarkod.Value = 1;
                            oku.Close();
                        }
                        else
                        {
                            groupBox3.Enabled = false;
                            MessageBox.Show("Ürün bulunamadı. Tam barkod numarasını girin veya okutun", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            UrunAdiBarkod.Text = "";
                            SatisAdetBarkod.Value = 1;
                            SatisTutarBarkod.Text = "00.00";
                            SatisNotB.Text = "";
                        }
                        baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("Barkod numarasını girin. ( Hata kodu: S-02 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (BarkodNo.Text == "")
                    {
                        groupBox3.Enabled = false;
                        UrunAdiBarkod.Text = "";
                        SatisAdetBarkod.Value = 1;
                        SatisTutarBarkod.Text = "00.00";
                        SatisNotB.Text = "";
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void urunAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (urunAra.Text.Length > 0)
                {
                    FbConnection b1 = new FbConnection(fk.Baglanti_Kodu());
                    b1.Open();
                    FbCommand KatidAl = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_adi='" + SatisUrunKategorisi.Text + "'", b1);
                    object ss1 = KatidAl.ExecuteScalar();
                    if (ss1 != null)
                    {
                        FbDataReader Katidoku = KatidAl.ExecuteReader();
                        Katidoku.Read();
                        string id = Katidoku["Kategori_id"].ToString(); Katidoku.Close();

                        FbConnection b2 = new FbConnection(fk.Baglanti_Kodu());
                        b2.Open();
                        FbCommand UrunAra = new FbCommand("SELECT Urun_adi FROM Urunler WHERE Urun_kategori='" + id + "' and Urun_adi like '%" + urunAra.Text + "%'", b2);
                        object aSor = UrunAra.ExecuteScalar();
                        if (aSor != null)
                        {
                            SatisUrun.Items.Clear();
                            FbDataReader UrunOku = UrunAra.ExecuteReader();
                            while (UrunOku.Read())
                            {
                                SatisUrun.Items.Add(UrunOku["Urun_adi"].ToString());
                            }
                            SatisUrun.SelectedIndex = 0;
                        }
                        else
                        {
                            MessageBox.Show("Girilen kelimeye göre sistemde ekli ürün bulunamadı, tüm ürünler listelenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        b2.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sistemsel bir sorun oluştu, lütfen sağlayıcınıza başvurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    b1.Close();
                }
                else
                {
                    string id = "";
                    SatisUrun.Items.Clear();
                    FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                    baglan.Open();
                    FbCommand KatidAl = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_adi='" + SatisUrunKategorisi.Text + "'", baglan);
                    object e1 = KatidAl.ExecuteScalar();
                    if (e1 != null)
                    {
                        FbDataReader Katidoku = KatidAl.ExecuteReader();
                        Katidoku.Read();
                        id = Katidoku["Kategori_id"].ToString(); Katidoku.Close();
                    }
                    else
                    {
                        MessageBox.Show("Sistemsel bir sorun oluştu, lütfen sağlayıcınıza başvurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    baglan.Close();

                    baglan.Open();
                    FbCommand urunList = new FbCommand("SELECT * FROM Urunler WHERE Urun_kategori='" + id + "' order by Urun_adi asc", baglan);
                    object sonuc = urunList.ExecuteScalar();
                    if (sonuc != null)
                    {
                        FbDataReader oku2 = urunList.ExecuteReader();
                        SatisUrun.Enabled = true;
                        YeniSatisBtn.Enabled = true;
                        while (oku2.Read())
                        {
                            SatisUrun.Items.Add(oku2["Urun_adi"].ToString());
                        }
                        //if(SatisUrun.Text != "")
                        SatisUrun.SelectedIndex = 0;
                    }
                    else
                    {
                        SatisUrun.Enabled = false;
                        YeniSatisBtn.Enabled = false;
                        MessageBox.Show("Bu kategoride henüz ürün eklenmemiş", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    baglan.Close();
                }
            }
            catch (Exception ee1)
            {
                MessageBox.Show(ee1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SatisAdet_ValueChanged(object sender, EventArgs e)
        {
            SatisTutar.Text = (sFiyat * float.Parse((SatisAdet.Value.ToString()))).ToString();
        }

        private void SatisAdetBarkod_ValueChanged(object sender, EventArgs e)
        {
            SatisTutarBarkod.Text = (ssFiyat * float.Parse((SatisAdetBarkod.Value).ToString())).ToString();
        }
    }
}