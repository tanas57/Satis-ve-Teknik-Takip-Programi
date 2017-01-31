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
    public partial class UrunKategoriSil2 : Form
    {
        public UrunKategoriSil2()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        string id;
        private void AramaKategoriAdi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (AramaKategoriAdi.Text.Length > 0)
                {
                    AramaKategoriAdi.Text = AramaKategoriAdi.Text.Replace("'", "’");
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                    FbDataReader KategoriOku; object sonuc;
                    baglanti.Open();
                    FbCommand KategoriAraSorgu = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_adi like '%" + AramaKategoriAdi.Text + "%' or Kategori_adi like '%" + fk.IlkHarfleriBuyut(AramaKategoriAdi.Text) + "%'", baglanti);
                    sonuc = KategoriAraSorgu.ExecuteScalar();
                    UrunKategoriCombo.Items.Clear();
                    if (sonuc != null)
                    {
                        KategoriOku = KategoriAraSorgu.ExecuteReader(); UrunKategoriCombo.Enabled = true;

                        while (KategoriOku.Read())
                        {
                            UrunKategoriCombo.Items.Add(KategoriOku["Kategori_adi"].ToString());
                        }
                        UrunKategoriCombo.SelectedIndex = 0; GuncellemeGrup.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Aramada ürün kategorisi bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GuncellemeGrup.Enabled = false; UrunKategoriCombo.Enabled = false;
                    }
                    baglanti.Close();
                }
                else
                {
                    GuncellemeGrup.Enabled = false; UrunKategoriCombo.Enabled = false; UrunKategoriCombo.Text = "";
                    UrunKategoriCombo.SelectedIndex = -1;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UrunKategoriCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (UrunKategoriCombo.Text.Length > 0)
                {
                    string kategori_adi = UrunKategoriCombo.Text;
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                    FbDataReader KategoriBilgi;
                    FbCommand MusteriSorgu = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_adi='" + kategori_adi + "'", baglanti);
                    baglanti.Open();
                    object Msor = MusteriSorgu.ExecuteScalar();
                    if (Msor != null)
                    {
                        KategoriBilgi = MusteriSorgu.ExecuteReader(); KategoriBilgi.Read();
                        id = KategoriBilgi["Kategori_id"].ToString();
                        label2.Text = KategoriBilgi["Kategori_adi"].ToString() + "\nÜrün kategorisi silinecek onaylıyor musunuz?";
                        GuncellemeGrup.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Sistemsel bir hata oluştu, lütfen sağlayınıza başvurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    baglanti.Close();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SilEvet_Click_1(object sender, EventArgs e)
        {
            try
            {
                byte sonuc;
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                FbConnection baglan2 = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbCommand UrunKategori = new FbCommand("SELECT Urun_id FROM Urunler WHERE Urun_kategori='" + id + "'", baglan);
                object Usor = UrunKategori.ExecuteScalar();
                if (Usor != null)
                {
                    FbDataReader UrunKategoriId = UrunKategori.ExecuteReader();
                    string[] urun_id = new string[0]; int i = 0;
                    while (UrunKategoriId.Read())
                    {
                        Array.Resize(ref urun_id, urun_id.Length + 1);
                        urun_id[i] = UrunKategoriId["Urun_id"].ToString();
                        i++;

                    }


                    foreach (string uid in urun_id)
                    {
                        baglan2.Open();
                        FbCommand SatisTab = new FbCommand("SELECT Satis_id FROM Satis WHERE Satis_urun='" + uid + "'", baglan2);
                        FbDataReader SatisIdOku = SatisTab.ExecuteReader();
                        while (SatisIdOku.Read())
                        {
                            fk.Sil("Satis", "Satis_id='" + SatisIdOku["Satis_id"].ToString() + "'");
                        }
                        baglan2.Close();

                        baglan2.Open();
                        FbCommand RaporTab = new FbCommand("SELECT rapor_id FROM Rapor WHERE rapor_satisId='" + uid + "'", baglan2);
                        FbDataReader RaporIdOku = RaporTab.ExecuteReader();
                        while (RaporIdOku.Read())
                        {
                            fk.Sil("Rapor", "rapor_id='" + RaporIdOku["rapor_id"].ToString() + "'");
                        }

                        baglan2.Close();
                        fk.Sil("Urunler", "Urun_id='" + uid + "'");
                    }


                    sonuc = fk.Sil("Urun_kategori", "Kategori_id='" + id + "'");
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Ürün kategorisi başarıyla silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ürün kategorisi silinemedi ( Hata kodu: K-07 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sistemsel bir hata oluştu, lütfen destek sağlayıcınıza başvurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                baglan.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SilHayir_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün kategorisi silme işlemi iptal edilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void katekle_Click(object sender, EventArgs e)
        {
            UrunKategoriEkle uke = new UrunKategoriEkle();
            uke.Show();
        }

        private void UrunKategoriSil2_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(katekle, "Ürün Kategorisi Ekle");
        }
    }
}
