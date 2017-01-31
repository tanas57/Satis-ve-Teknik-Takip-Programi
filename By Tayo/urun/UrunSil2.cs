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
    public partial class UrunSil2 : Form
    {
        public UrunSil2()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        string id;
        private void UrunSil2_Load(object sender, EventArgs e)
        {

        }

        private void urunAdi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (urunAdi.Text.Length > 0)
                {
                    urunAdi.Text = urunAdi.Text.Replace("'", "’");
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                    FbDataReader UrunOku; object sonuc;
                    baglanti.Open();
                    FbCommand UrunAraSorgu = new FbCommand("SELECT * FROM Urunler WHERE Urun_adi like '%" + urunAdi.Text + "%' or Urun_adi like '%" + fk.IlkHarfleriBuyut(urunAdi.Text) + "%'", baglanti);
                    sonuc = UrunAraSorgu.ExecuteScalar();
                    urunler.Items.Clear();
                    if (sonuc != null)
                    {
                        UrunOku = UrunAraSorgu.ExecuteReader();
                        while (UrunOku.Read())
                        {
                            urunler.Items.Add(UrunOku["Urun_adi"].ToString());
                        }
                        urunler.SelectedIndex = 0;
                        urunler.Enabled = true;
                        UrunSil.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Aranan isme / soyisme göre müşteri bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        urunler.Enabled = false;
                        UrunSil.Enabled = false;
                    }
                    baglanti.Close();
                }
                else
                {
                    urunler.Enabled = false;
                    urunler.SelectedIndex = -1;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void urunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (urunler.Text.Length > 0)
                {
                    // Müşteri bilgileri //
                    string adsoyad = urunler.Text;
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                    FbDataReader UrunBilgi;
                    FbCommand MusteriSorgu = new FbCommand("SELECT * FROM Urunler WHERE Urun_adi='" + urunler.Text + "'", baglanti);
                    baglanti.Open();
                    object s1 = MusteriSorgu.ExecuteScalar();
                    if (s1 != null)
                    {
                        UrunBilgi = MusteriSorgu.ExecuteReader(); UrunBilgi.Read();
                        id = UrunBilgi["Urun_id"].ToString();
                        this.Text = UrunBilgi["Urun_adi"] + " - Müşteri Silinecek";
                        label1.Text = this.Text;

                        // Müşteri bilgileri //
                    }
                    else
                    {
                        MessageBox.Show("Sistemsel bir hata oluştu, lütfen sağlayıcınıza başvurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    baglanti.Close();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SilEvet_Click(object sender, EventArgs e)
        {
            try
            {
                byte sonuc;

                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbCommand SatisTab = new FbCommand("SELECT Satis_id FROM Satis WHERE Satis_urun='" + id + "'", baglan);
                FbDataReader SatisIdOku = SatisTab.ExecuteReader();
                while (SatisIdOku.Read())
                {
                    fk.Sil("Satis", "Satis_id='" + SatisIdOku["Satis_id"].ToString() + "'");
                }
                baglan.Close();

                baglan.Open();
                FbCommand RaporTab = new FbCommand("SELECT rapor_id FROM Rapor WHERE rapor_satisId='" + id + "'", baglan);
                FbDataReader RaporIdOku = RaporTab.ExecuteReader();
                while (RaporIdOku.Read())
                {
                    fk.Sil("Rapor", "rapor_id='" + RaporIdOku["rapor_id"].ToString() + "'");
                }
                baglan.Close();

                sonuc = fk.Sil("Urunler", "Urun_id='" + id + "'");
                if (sonuc == 1)
                {
                    MessageBox.Show("Ürün başarıyla silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ürün silinemedi ( Hata kodu: U-09 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SilHayir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Müşteri silme işlemi iptal edilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
