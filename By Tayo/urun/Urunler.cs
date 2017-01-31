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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();

        private void Urunler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = fk.UrunSutunOlustur();
            FormLoad();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // seçilen satırdan id'yi al
            Urunid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void ButonGuncelle_Click(object sender, EventArgs e)
        {
            // seçilen satırdan id'yi al
            Urunid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            UrunGuncelle ug = new UrunGuncelle();
            ug.id = Urunid.Text;
            ug.ShowDialog();
        }

        private void ButonSil_Click(object sender, EventArgs e)
        {
            // seçilen satırdan id'yi al
            Urunid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            UrunSil us = new UrunSil();
            us.id = Urunid.Text;
            us.ShowDialog();
        }

        private void AramaButonAd_Click(object sender, EventArgs e)
        {
            UrunAdi.Text = UrunAdi.Text.Replace("'", "’");
            UrunAra();
        }

        private void AramaButonBarkod_Click(object sender, EventArgs e)
        {
            BarkodNo.Text = BarkodNo.Text.Replace("'", "’");
            UrunAraBarkod();
        }

        private void UrunAdi_TextChanged(object sender, EventArgs e)
        {
            if (UrunAdi.Text.Length > 0)
                UrunBarkodaGoreGrup.Enabled = false;
            else
            {
                UrunBarkodaGoreGrup.Enabled = true;
                GridGuncelle();
                FormLoad();
            }
        }

        private void BarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNo.Text.Length > 0)
                UrunAdaGoreGrup.Enabled = false;
            else
            {
                UrunAdaGoreGrup.Enabled = true;
                GridGuncelle();
                FormLoad();
            }
        }

        private void BarkodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void FormLoad()
        {
            try
            {
                FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu()); FbConnection baglanti2 = new FbConnection(fk.Baglanti_Kodu());
                FbDataReader oku; object sonuc; DataRow satir;
                FbCommand komut_musteri = new FbCommand("SELECT * FROM Urunler", baglanti);
                komut_musteri.Connection = baglanti;
                baglanti.Open();
                sonuc = komut_musteri.ExecuteScalar();

                if (sonuc != null)
                {
                    oku = komut_musteri.ExecuteReader();
                    while (oku.Read())
                    {
                        satir = fk.dt.NewRow();
                        satir["Ürün Id"] = oku["Urun_id"].ToString();
                        if (oku["Urun_barkodNo"].ToString() == "0") satir["Ürün Barkod"] = "Barkodsuz Ürün";
                        else satir["Ürün Barkod"] = oku["Urun_barkodNo"].ToString();

                        satir["Ürün Adı"] = oku["Urun_adi"].ToString();
                        satir["Satış Fiyatı"] = float.Parse(oku["Urun_fiyat"].ToString()) + " TL";

                        // Kategori Adı çek //
                        FbCommand KategoriAdi = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_id='" + oku["Urun_kategori"].ToString() + "'", baglanti2);
                        baglanti2.Open();
                        FbDataReader oku1;
                        oku1 = KategoriAdi.ExecuteReader(); oku1.Read();
                        satir["Ürün Kategori"] = oku1["Kategori_adi"].ToString();
                        baglanti2.Close();
                        // Kategori Adı çek //

                        satir["Eklenme Tarihi"] = Convert.ToDateTime(oku["Urun_eklenmeTarih"].ToString());

                        //Veri tablomuza kontrolüne ekle
                        fk.dt.Rows.Add(satir);
                    }
                }
                else
                {
                    MessageBox.Show("Ekli ürün bulunamadı, ürün ekleyiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    UrunEkle ue = new UrunEkle();
                    ue.ShowDialog();
                }

                // bağlantı kapatıldı
                baglanti.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UrunAra()
        {
            try
            {
                if (UrunAdi.Text != "")
                {
                    // ad soyada göre arattır
                    FbDataReader oku; object urunadi; DataRow satir;
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                    FbConnection baglanti2 = new FbConnection(fk.Baglanti_Kodu());
                    FbCommand UrunAdSorgu = new FbCommand("SELECT * FROM Urunler where Urun_adi like '%" + UrunAdi.Text + "%' or Urun_adi like '%" + fk.IlkHarfleriBuyut(UrunAdi.Text) + "%'", baglanti);
                    baglanti.Open();
                    urunadi = UrunAdSorgu.ExecuteScalar();
                    if (urunadi != null)
                    {
                        fk.dt.Clear();
                        dataGridView1.Refresh();
                        oku = UrunAdSorgu.ExecuteReader();
                        while (oku.Read())
                        {
                            satir = fk.dt.NewRow();
                            satir["Ürün Id"] = oku["Urun_id"].ToString();
                            if (oku["Urun_barkodNo"].ToString() == "0") satir["Ürün Barkod"] = "Barkodsuz Ürün";
                            else satir["Ürün Barkod"] = oku["Urun_barkodNo"].ToString();

                            satir["Ürün Adı"] = oku["Urun_adi"].ToString();
                            satir["Satış Fiyatı"] = float.Parse(oku["Urun_fiyat"].ToString()) + " TL";

                            // Kategori Adı çek //
                            FbCommand KategoriAdi = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_id='" + oku["Urun_kategori"].ToString() + "'", baglanti2);
                            baglanti2.Open();
                            FbDataReader oku1;
                            oku1 = KategoriAdi.ExecuteReader(); oku1.Read();
                            satir["Ürün Kategori"] = oku1["Kategori_adi"].ToString();
                            baglanti2.Close();
                            // Kategori Adı çek //

                            satir["Eklenme Tarihi"] = Convert.ToDateTime(oku["Urun_eklenmeTarih"].ToString());

                            //Veri tablomuza kontrolüne ekle
                            fk.dt.Rows.Add(satir);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ürün bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Ürün adını girin. ( Hata kodu: U-01 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UrunAraBarkod()
        {
            try
            {
                // barkoda göre arattır
                if (BarkodNo.Text != "")
                {
                    FbDataReader oku; object barkod; DataRow satir;
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                    FbConnection baglanti2 = new FbConnection(fk.Baglanti_Kodu());
                    FbCommand UrunBarkodSorgu = new FbCommand("SELECT * FROM Urunler where Urun_barkodNo='" + BarkodNo.Text + "'", baglanti);
                    baglanti.Open();
                    barkod = UrunBarkodSorgu.ExecuteScalar();
                    if (barkod != null)
                    {
                        fk.dt.Clear();
                        dataGridView1.Refresh();
                        oku = UrunBarkodSorgu.ExecuteReader();
                        while (oku.Read())
                        {
                            satir = fk.dt.NewRow();
                            satir["Ürün Id"] = oku["Urun_id"].ToString();
                            if (oku["Urun_barkodNo"].ToString() == "0") satir["Ürün Barkod"] = "Barkodsuz Ürün";
                            else satir["Ürün Barkod"] = oku["Urun_barkodNo"].ToString();

                            satir["Ürün Adı"] = oku["Urun_adi"].ToString();
                            satir["Satış Fiyatı"] = float.Parse(oku["Urun_fiyat"].ToString()) + " TL";

                            // Kategori Adı çek //
                            FbCommand KategoriAdi = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_id='" + oku["Urun_kategori"].ToString() + "'", baglanti2);
                            baglanti2.Open();
                            FbDataReader oku1;
                            oku1 = KategoriAdi.ExecuteReader(); oku1.Read();
                            satir["Ürün Kategori"] = oku1["Kategori_adi"].ToString();
                            baglanti2.Close();
                            // Kategori Adı çek //

                            satir["Eklenme Tarihi"] = Convert.ToDateTime(oku["Urun_eklenmeTarih"].ToString());

                            //Veri tablomuza kontrolüne ekle
                            fk.dt.Rows.Add(satir);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ürün bulunamadı. Tam barkod numarasını girin veya okutun", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Barkod numarasını girin. ( Hata kodu: U-02 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GridGuncelle()
        {
            fk.dt.Clear();
            dataGridView1.Refresh();
        }
    }
}
