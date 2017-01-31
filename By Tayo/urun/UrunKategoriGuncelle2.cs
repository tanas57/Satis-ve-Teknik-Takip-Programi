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
    public partial class UrunKategoriGuncelle2 : Form
    {
        public UrunKategoriGuncelle2()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        string id, katadi = "";
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
                            id = KategoriOku["Kategori_id"].ToString();
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
                    MessageBox.Show("Ürün kategori adı girin ( Hata kodu: K-06 )", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (GuncellemeKategoriAdi.Text.Length > 0)
                {
                    if (GuncellemeKategoriAdi.Text != katadi)
                    {
                        GuncellemeKategoriAdi.Text = GuncellemeKategoriAdi.Text.Replace("'", "’");
                        FbConnection b1 = new FbConnection(fk.Baglanti_Kodu());
                        b1.Open();
                        FbCommand KatSor = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_adi='" + fk.IlkHarfleriBuyut(GuncellemeKategoriAdi.Text) + "'", b1);
                        object ss = KatSor.ExecuteScalar();
                        if (ss == null)
                        {
                            b1.Close();
                            byte guncelle;
                            guncelle = fk.Guncelle("Urun_kategori", "Kategori_adi='" + fk.IlkHarfleriBuyut(GuncellemeKategoriAdi.Text) + "'", "Kategori_id='" + id + "'");
                            if (guncelle == 1)
                            {
                                MessageBox.Show("Kategori başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UrunKategoriCombo.Items.Clear();
                                UrunKategoriCombo.Items.Add(fk.IlkHarfleriBuyut(GuncellemeKategoriAdi.Text));
                                UrunKategoriCombo.Text = fk.IlkHarfleriBuyut(GuncellemeKategoriAdi.Text);
                            }
                            else
                                MessageBox.Show("Kategori güncellenemedi ( Hata kodu: K-02 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Yeni kategori sistemde kayıtlı, güncelleme iptal edildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        b1.Close();
                    }
                    else
                    {
                        // kategori adları aynı..
                        MessageBox.Show("Kategori başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Yeni kategori adını giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                string kategori_adi = UrunKategoriCombo.Text;
                FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                FbDataReader KategoriBilgi;
                FbCommand MusteriSorgu = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_adi='" + kategori_adi + "'", baglanti);
                baglanti.Open();
                object ss2 = MusteriSorgu.ExecuteScalar();
                if (ss2 != null)
                {
                    KategoriBilgi = MusteriSorgu.ExecuteReader(); KategoriBilgi.Read();
                    id = KategoriBilgi["Kategori_id"].ToString();
                    GuncellemeKategoriAdi.Text = KategoriBilgi["Kategori_adi"].ToString();
                    katadi = KategoriBilgi["Kategori_adi"].ToString();
                    GuncellemeGrup.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Sistemsel bir hata oluştu, lütfen destek sağlayıcınıza başvurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                baglanti.Close();
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

        private void UrunKategoriGuncelle2_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(katekle, "Ürün Kategorisi Ekle");
        }
    }
}
