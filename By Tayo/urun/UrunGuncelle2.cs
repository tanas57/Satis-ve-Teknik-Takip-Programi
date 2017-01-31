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
    public partial class UrunGuncelle2 : Form
    {
        public UrunGuncelle2()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar(); string id;

        private void UrunAdi_TextChanged(object sender, EventArgs e)
        {
            if (UrunAdi.Text.Length > 0)
                UrunBarkodaGoreGrup.Enabled = false;
            else
                UrunBarkodaGoreGrup.Enabled = true;
        }

        private void BarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNo.Text.Length > 0)
                UrunAdaGoreGrup.Enabled = false;
            else
                UrunAdaGoreGrup.Enabled = true;
        }

        private void UrunGuncelle2_Load(object sender, EventArgs e)
        {
            try
            {
                ToolTip Aciklama = new ToolTip();
                Aciklama.SetToolTip(katekle, "Ürün Kategorisi Ekle");
                // Bağlantı //
                FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                // Bağlantı //

                // Kategorileri çek //
                FbDataReader KategoriGetir;
                FbCommand KategoriSorgu = new FbCommand("SELECT * FROM Urun_kategori", baglanti);
                baglanti.Open();
                UrunKategori.Items.Clear();
                object sk = KategoriSorgu.ExecuteScalar();
                if (sk != null)
                {
                    KategoriGetir = KategoriSorgu.ExecuteReader();
                    while (KategoriGetir.Read())
                    {
                        UrunKategori.Items.Add(KategoriGetir["Kategori_adi"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Ürün kategorisi ekleyin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    UrunKategoriEkle uke = new UrunKategoriEkle();
                    uke.ShowDialog();
                }
                baglanti.Close();

                // Kategorileri çek //
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AramaButonAd_Click(object sender, EventArgs e)
        {
            UrunAdi.Text = UrunAdi.Text.Replace("'", "’");
            UrunAraisim();
        }

        private void AramaButonBarkod_Click(object sender, EventArgs e)
        {
            BarkodNo.Text = BarkodNo.Text.Replace("'", "’");
            UrunAraBarkod();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Ürün bilgileri //
                string urunadi = comboBox1.Text;
                FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                FbDataReader UrunBilgi;
                FbCommand MusteriSorgu = new FbCommand("SELECT * FROM Urunler WHERE Urun_adi='" + urunadi + "' or Urun_adi='" + fk.IlkHarfleriBuyut(urunadi) + "'", baglanti);
                baglanti.Open();
                UrunBilgi = MusteriSorgu.ExecuteReader(); UrunBilgi.Read();
                id = UrunBilgi["Urun_id"].ToString();
                UrunAd.Text = UrunBilgi["Urun_adi"].ToString();
                this.Text = UrunBilgi["Urun_adi"].ToString() + " - Ürün Güncelleme";
                if (Convert.ToInt64(UrunBilgi["Urun_barkodNo"].ToString()) == 0)
                {
                    barkodlu.Checked = true;
                    UrunBarkod.Text = "Barkod Eklenmedi";
                }
                else
                {
                    barkodlu.Checked = false;
                    UrunBarkod.Text = UrunBilgi["Urun_barkodNo"].ToString();
                }
                UrunFiyat.Text = float.Parse(UrunBilgi["Urun_fiyat"].ToString()).ToString();
                AlisFiyat.Text = float.Parse(UrunBilgi["Urun_alisFiyat"].ToString()).ToString();
                string MusteriKatString = UrunBilgi["Urun_kategori"].ToString();

                baglanti.Close();
                // Ürün bilgileri //

                // Ürün hangi kategoride //
                baglanti.Open();
                FbCommand KategoriAdiSorgu = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_id='" + MusteriKatString + "'", baglanti);
                FbDataReader KatAdiOku; KatAdiOku = KategoriAdiSorgu.ExecuteReader(); KatAdiOku.Read();
                UrunKategori.Text = KatAdiOku["Kategori_adi"].ToString();
                baglanti.Close();
                // Ürün hangi kategoride //
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
                UrunAd.Text = UrunAd.Text.Replace("'", "’");
                UrunFiyat.Text = UrunFiyat.Text.Replace(',', '.');
                AlisFiyat.Text = AlisFiyat.Text.Replace(',', '.');
                string katId = ""; string kategori = UrunKategori.Text;
                if (UrunAd.Text != "" && UrunAd.Text.Length > 3 && UrunFiyat.Text != "" && AlisFiyat.Text != "")
                {

                    // Kategori id yi çıkar //
                    FbConnection bagla = new FbConnection(fk.Baglanti_Kodu()); FbDataReader KategoriIdCek;
                    bagla.Open();
                    FbCommand KategoriAdiSorgu = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_adi='" + kategori + "'", bagla);
                    KategoriIdCek = KategoriAdiSorgu.ExecuteReader();
                    KategoriIdCek.Read(); katId = KategoriIdCek["Kategori_id"].ToString();
                    bagla.Close();
                    // Kategori id yi çıkar //

                    if (barkodlu.Checked == true)
                    {
                        byte sonuc;
                        sonuc = fk.Guncelle("Urunler", "Urun_adi='" + fk.IlkHarfleriBuyut(UrunAd.Text) + "', Urun_fiyat='" + UrunFiyat.Text + "', Urun_alisFiyat='" + AlisFiyat.Text + "', Urun_kategori='" + katId + "'", "Urun_id='" + id + "'");
                        if (sonuc == 1)
                        {
                            MessageBox.Show("Ürün başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (UrunAdi.Text != "")
                            {
                                comboBox1.Items.Clear();
                                UrunAdi.Text = UrunAd.Text;
                                UrunAraisim();
                                comboBox1.Text = UrunAd.Text;
                            }
                            else
                            {
                                comboBox1.Items.Clear();
                                BarkodNo.Text = UrunBarkod.Text;
                                UrunAraBarkod();
                                comboBox1.Text = UrunAd.Text;
                            }
                        }
                        else
                            MessageBox.Show("Ürün güncellenemedi ( Hata kodu: U-07 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (UrunBarkod.Text.Length > 14)
                        {
                            byte sonuc;
                            sonuc = fk.Guncelle("Urunler", "Urun_adi='" + UrunAd.Text + "', Urun_fiyat='" + UrunFiyat.Text + "', Urun_alisFiyat='" + AlisFiyat.Text + "', Urun_kategori='" + katId + "', Urun_barkodNo='" + UrunBarkod.Text + "'", "Urun_id='" + id + "'");
                            if (sonuc == 1)
                            {
                                MessageBox.Show("Ürün başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (UrunAdi.Text != "")
                                {
                                    comboBox1.Items.Clear();
                                    UrunAdi.Text = UrunAd.Text;
                                    UrunAraisim();
                                    comboBox1.Text = UrunAd.Text;
                                }
                                else
                                {
                                    comboBox1.Items.Clear();
                                    BarkodNo.Text = UrunBarkod.Text;
                                    UrunAraBarkod();
                                    comboBox1.Text = UrunAd.Text;
                                }
                            }
                            else
                                MessageBox.Show("Ürün güncellenemedi ( Hata kodu: U-07 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Barkod numarasını 15 hane olarak giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Boş alanları doldurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UrunFiyat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UrunFiyat_Validating(object sender, CancelEventArgs e)
        {
        }

        private void BarkodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void katekle_Click(object sender, EventArgs e)
        {
            UrunKategoriEkle uke = new UrunKategoriEkle();
            uke.Show();
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

        private void UrunBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void UrunAraisim()
        {
            try
            {
                if (UrunAdi.Text != "")
                {
                    // ad soyada göre arattır
                    FbDataReader oku; object urunadi;
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                    FbConnection baglanti2 = new FbConnection(fk.Baglanti_Kodu());
                    FbCommand UrunAdSorgu = new FbCommand("SELECT * FROM Urunler where Urun_adi like '%" + UrunAdi.Text + "%' or Urun_adi like '%" + fk.IlkHarfleriBuyut(UrunAdi.Text) + "%'", baglanti);
                    baglanti.Open();
                    urunadi = UrunAdSorgu.ExecuteScalar();
                    if (urunadi != null)
                    {
                        comboBox1.Items.Clear();
                        oku = UrunAdSorgu.ExecuteReader();
                        label3.Enabled = true; comboBox1.Enabled = true; UrunGuncelleme.Enabled = true;
                        while (oku.Read())
                        {
                            comboBox1.Items.Add(oku["Urun_adi"].ToString());
                            comboBox1.SelectedIndex = 0;
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

        private void UrunAraBarkod()
        {
            try
            {
                // barkoda göre arattır
                if (BarkodNo.Text.Length > 14)
                {
                    FbDataReader oku; object barkod;
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                    FbConnection baglanti2 = new FbConnection(fk.Baglanti_Kodu());
                    FbCommand UrunBarkodSorgu = new FbCommand("SELECT * FROM Urunler where Urun_barkodNo='" + BarkodNo.Text + "'", baglanti);
                    baglanti.Open();
                    barkod = UrunBarkodSorgu.ExecuteScalar();
                    if (barkod != null)
                    {
                        comboBox1.Items.Clear(); label3.Enabled = true; comboBox1.Enabled = true; UrunGuncelleme.Enabled = true;
                        oku = UrunBarkodSorgu.ExecuteReader();
                        while (oku.Read())
                        {
                            comboBox1.Items.Add(oku["Urun_adi"].ToString());
                            comboBox1.SelectedIndex = 0;
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
    }
}
