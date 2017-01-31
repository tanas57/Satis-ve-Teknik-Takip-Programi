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
    public partial class ManuelSatis : Form
    {
        public ManuelSatis()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();

        private void KayitliMi1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (KayitliMi1.Checked)
                {
                    groupBox3.Enabled = true;
                }
                else
                {
                    groupBox3.Enabled = false;
                    musara.Text = "";
                    SatisMusteri.SelectedIndex = -1;
                    checkBox1.Checked = false;
                }
                SatisMusteri.Items.Clear();
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbCommand MustList = new FbCommand("SELECT * FROM Musteriler", baglan);
                object sonuc = MustList.ExecuteScalar();
                if (sonuc != null)
                {
                    FbDataReader oku = MustList.ExecuteReader();
                    while (oku.Read())
                    {
                        SatisMusteri.Items.Add(oku["Musteri_adi"].ToString() + " " + oku["Musteri_soyadi"].ToString());
                    }
                    SatisMusteri.SelectedIndex = -1;
                }
                else
                {
                    SatisMusteri.Enabled = false;
                    checkBox1.Enabled = false;
                    groupBox3.Enabled = false;
                    MessageBox.Show("Kayıtlı müşteri bulunmamaktadır, müşteri ekleyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    MusteriEkle me = new MusteriEkle();
                    me.ShowDialog();
                }
                baglan.Close();
            }
            catch (Exception h1)
            {
                MessageBox.Show(h1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void musara_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (musara.Text.Length > 0)
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
                else
                {
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
            }
            catch (Exception h2)
            {
                MessageBox.Show(h2.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (UrunAdi.Text != "" && UrunFiyat.Text != "" && AlisFiyat.Text != "")
                {
                    UrunAdi.Text = UrunAdi.Text.Replace("'", "’");
                    not.Text = not.Text.Replace("'", "’");
                    musara.Text = musara.Text.Replace("'", "’");
                    UrunFiyat.Text = UrunFiyat.Text.Replace(',', '.');
                    AlisFiyat.Text = AlisFiyat.Text.Replace(',', '.');
                    string tarih = DateTime.Now.ToString("yyyy-MM-dd");
                    if (KayitliMi1.Checked == true)
                    {
                        string adsoyad = SatisMusteri.Text;
                        string[] ads = adsoyad.Split(' ');
                        FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                        FbDataReader MusteriBilgi;
                        FbCommand MusteriSorgu = new FbCommand("SELECT * FROM Musteriler WHERE Musteri_adi='" + ads[0] + "' and Musteri_soyadi='" + ads[1] + "'", baglanti);
                        baglanti.Open();
                        MusteriBilgi = MusteriSorgu.ExecuteReader(); MusteriBilgi.Read();
                        string id = MusteriBilgi["Musteri_id"].ToString();
                        baglanti.Close();
                        byte sonuc = fk.Ekle("ManuelSatis", "satis_urunadi,satis_alisFiyat,satis_fiyat,satis_tarih,satis_musteri,satis_not", "'" + UrunAdi.Text + "','" + AlisFiyat.Text + "','" + UrunFiyat.Text + "','" + tarih + "','" + id + "','" + not.Text + "'");
                        if (sonuc == 1)
                        {
                            MessageBox.Show("Satış başarıyla eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Satış eklenemedi ( Hata kodu: S-01 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        byte sonuc = fk.Ekle("ManuelSatis", "satis_urunadi,satis_alisFiyat,satis_fiyat,satis_tarih,satis_not", "'" + UrunAdi.Text + "','" + AlisFiyat.Text + "','" + UrunFiyat.Text + "','" + tarih + "','" + not.Text + "'");
                        if (sonuc == 1)
                        {
                            MessageBox.Show("Satış başarıyla eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Satış eklenemedi ( Hata kodu: S-01 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Boş alanları doldurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception h3)
            {
                MessageBox.Show(h3.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlisFiyat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AlisFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void UrunFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;

            }
        }

        private void formukapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
