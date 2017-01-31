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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            try
            {
                ToolTip Aciklama = new ToolTip();
                Aciklama.SetToolTip(katekle, "Ürün Kategorisi Ekle");

                FbConnection komut_baglan = new FbConnection(fk.Baglanti_Kodu());
                FbDataReader oku;
                FbCommand cmd = new FbCommand();

                object sonuc;

                komut_baglan.Open();
                cmd.Connection = komut_baglan;
                cmd.CommandText = "SELECT * FROM Urun_kategori";
                sonuc = cmd.ExecuteScalar();
                if (sonuc != null)
                {
                    oku = cmd.ExecuteReader();

                    while (oku.Read())
                    {
                        UrunKategori.Items.Add(oku[1].ToString());
                    }

                    UrunKategori.SelectedIndex = 0;
                    oku.Close();
                }
                else
                {
                    MessageBox.Show("Ürün ekleyebilmek için önce ürün kategorisi ekleyin", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    UrunKategoriEkle uke = new UrunKategoriEkle();
                    uke.ShowDialog();
                }
                komut_baglan.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barkodlu_CheckedChanged(object sender, EventArgs e)
        {
            if (barkodlu.Checked == true)
            {
                UrunBarkod.Text = "Barkod Eklenmedi";
                UrunBarkod.Enabled = false;
            }
            else
            {
                UrunBarkod.Text = "";
                UrunBarkod.Enabled = true;
            }
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                UrunAdi.Text = UrunAdi.Text.Replace("'", "’");
                UrunFiyat.Text = UrunFiyat.Text.Replace(',', '.');
                AlisFiyat.Text = AlisFiyat.Text.Replace(',', '.');
                byte kayit; string ad, barkod, fiyat, afiyat, kategori, tarih;
                if (UrunAdi.Text != "" && UrunFiyat.Text != "" && AlisFiyat.Text != "" && UrunKategori.Text != "")
                {
                    ad = UrunAdi.Text; barkod = UrunBarkod.Text;
                    fiyat = UrunFiyat.Text;
                    afiyat = AlisFiyat.Text;
                    int kategori_id = 0;
                    kategori = UrunKategori.SelectedItem.ToString();
                    tarih = DateTime.Now.Year.ToString(); tarih += '-' + DateTime.Now.Month.ToString(); tarih += '-' + DateTime.Now.Day.ToString();
                    // kategori id çekme
                    FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                    FbDataReader oku;
                    object sonuc;
                    FbCommand kategori_cek = new FbCommand("SELECT Kategori_id FROM Urun_kategori where Kategori_adi='" + kategori + "'");
                    kategori_cek.Connection = baglan;
                    baglan.Open();
                    sonuc = kategori_cek.ExecuteScalar();
                    if (sonuc != null)
                    {
                        oku = kategori_cek.ExecuteReader();
                        while (oku.Read())
                        {
                            kategori_id = int.Parse(oku[0].ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Teknik bir hata oluştu, lütfen destek sağlayıcınıza başvurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    baglan.Close();
                    // kategori id çekme
                    if (barkod != "Barkod Eklenmedi")
                    {
                        kayit = fk.Ekle("Urunler", "Urun_barkodNo,Urun_adi,Urun_fiyat,Urun_kategori,Urun_eklenmeTarih,Urun_alisFiyat", "'" + barkod + "','" + fk.IlkHarfleriBuyut(ad) + "','" + fiyat + "','" + kategori_id + "','" + tarih + "','" + afiyat + "'");
                        if (kayit == 1)
                        {
                            MessageBox.Show("Ürün başarıyla eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UrunFiyat.Text = ""; UrunAdi.Text = ""; UrunBarkod.Text = "Barkod Eklenmedi"; barkodlu.Checked = true; AlisFiyat.Text = "";
                        }
                        else
                            MessageBox.Show("Ürün eklenemedi ( Hata kodu: U-05 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        kayit = fk.Ekle("Urunler", "Urun_barkodNo,Urun_adi,Urun_fiyat,Urun_kategori,Urun_eklenmeTarih,Urun_alisFiyat", "'0','" + fk.IlkHarfleriBuyut(ad) + "','" + fiyat + "','" + kategori_id + "','" + tarih + "','" + afiyat + "'");
                        if (kayit == 1)
                        {
                            MessageBox.Show("Ürün başarıyla eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UrunFiyat.Text = ""; UrunAdi.Text = ""; UrunBarkod.Text = "Barkod Eklenmedi"; barkodlu.Checked = true; AlisFiyat.Text = "";
                        }
                        else
                            MessageBox.Show("Ürün eklenemedi ( Hata kodu: U-05 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Boş alanları doldurun! ( Hata kodu: U-06 )", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void katekle_Click(object sender, EventArgs e)
        {
            UrunKategoriEkle uke = new UrunKategoriEkle();
            uke.Show();
        }

        private void UrunBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
    }
}
