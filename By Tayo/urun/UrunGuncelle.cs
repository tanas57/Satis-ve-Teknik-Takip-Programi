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
    public partial class UrunGuncelle : Form
    {
        public UrunGuncelle()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        public string id;

        private void UrunGuncelle_Load(object sender, EventArgs e)
        {
            try
            {
                ToolTip Aciklama = new ToolTip();
                Aciklama.SetToolTip(katekle, "Ürün Kategorisi Ekle");
                // Bağlantı //
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                // Bağlantı //

                // Kategorileri çek //
                FbDataReader KategoriGetir;
                FbCommand KategoriSorgu = new FbCommand("SELECT * FROM Urun_kategori", baglan);
                baglan.Open();
                object ss = KategoriSorgu.ExecuteScalar();
                if (ss != null)
                {
                    KategoriGetir = KategoriSorgu.ExecuteReader();
                    UrunKategori.Items.Clear();
                    while (KategoriGetir.Read())
                    {
                        UrunKategori.Items.Add(KategoriGetir["Kategori_adi"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Ürün güncelleme için önce ürün kategorisi ekleyin", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    UrunKategoriEkle uke = new UrunKategoriEkle();
                    uke.ShowDialog();
                }
                baglan.Close();

                // Kategorileri çek //

                FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu()); FbConnection baglanti2 = new FbConnection(fk.Baglanti_Kodu());
                baglanti.Open();
                FbCommand UrunBilgi = new FbCommand("SELECT * FROM Urunler WHERE Urun_id='" + id + "'", baglanti);

                FbDataReader oku;
                oku = UrunBilgi.ExecuteReader(); oku.Read();
                this.Text = oku["Urun_adi"].ToString() + " - Ürün Güncelleme";
                UrunAdi.Text = oku["Urun_adi"].ToString();
                double barkodNum = double.Parse(oku["Urun_barkodNo"].ToString());
                if (barkodNum == 0)
                {
                    UrunBarkod.Text = "Barkod Eklenmedi";
                    UrunBarkod.Enabled = false;
                    barkodlu.Checked = true;
                }
                else
                {
                    UrunBarkod.Enabled = true;
                    barkodlu.Checked = false;
                    UrunBarkod.Text = oku["Urun_barkodNo"].ToString();
                }
                UrunFiyat.Text = float.Parse(oku["Urun_fiyat"].ToString()).ToString();
                AlisFiyat.Text = float.Parse(oku["Urun_alisFiyat"].ToString()).ToString();

                baglanti2.Open();
                FbCommand Kategori = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_id='" + oku["Urun_kategori"].ToString() + "'", baglanti2);
                FbDataReader KatOku; KatOku = Kategori.ExecuteReader(); KatOku.Read();
                UrunKategori.Text = KatOku["Kategori_adi"].ToString();
                baglanti2.Close();

                groupBox1.Text = oku["Urun_adi"].ToString();
                baglanti.Close();
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

        private void UrunBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
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

        private void katekle_Click(object sender, EventArgs e)
        {
            UrunKategoriEkle uke = new UrunKategoriEkle();
            uke.Show();
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Urunler Uruns = (Urunler)Application.OpenForms["Urunler"];
                UrunAdi.Text = UrunAdi.Text.Replace("'", "’");
                UrunFiyat.Text = UrunFiyat.Text.Replace(',', '.');
                AlisFiyat.Text = AlisFiyat.Text.Replace(',', '.');
                string ad, barkod, fiyat, kategori; string katId = "";
                ad = UrunAdi.Text; barkod = UrunBarkod.Text; fiyat = UrunFiyat.Text; kategori = UrunKategori.Text;
                if ((ad != "" && ad.Length > 3) && fiyat != "" && kategori != "" && AlisFiyat.Text != "")
                {
                    // urun id yi çıkar //
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu()); FbDataReader KategoriIdCek;
                    baglanti.Open();
                    FbCommand KategoriAdiSorgu = new FbCommand("SELECT Kategori_id FROM Urun_kategori WHERE Kategori_adi='" + kategori + "'", baglanti);
                    KategoriIdCek = KategoriAdiSorgu.ExecuteReader();
                    KategoriIdCek.Read(); katId = KategoriIdCek["Kategori_id"].ToString();
                    baglanti.Close();
                    // urun id yi çıkar //

                    if (barkodlu.Checked == true)
                    {
                        // Ürünü güncelle //
                        byte sonuc;
                        sonuc = fk.Guncelle("Urunler", "Urun_barkodNo='0',Urun_adi='" + fk.IlkHarfleriBuyut(ad) + "',Urun_fiyat='" + fiyat + "',Urun_kategori='" + katId + "',Urun_alisFiyat='" + AlisFiyat.Text + "'", "Urun_id='" + id + "'");
                        if (sonuc == 1)
                        {
                            MessageBox.Show("Ürün başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (Uruns.UrunAdi.Text != "")
                            {
                                Uruns.GridGuncelle();
                                Uruns.UrunAra();
                            }
                            else if (Uruns.BarkodNo.Text != "")
                            {
                                Uruns.GridGuncelle();
                                Uruns.UrunAraBarkod();
                            }
                            else
                            {
                                Uruns.GridGuncelle();
                                Uruns.FormLoad();
                            }
                        }
                        else
                            MessageBox.Show("Ürün güncellenemedi ( Hata kodu: M-03 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Ürünü güncelle //
                    }
                    else
                    {
                        barkod = UrunBarkod.Text;
                        if (barkod.Length > 14)
                        {
                            // Ürünü güncelle //
                            byte sonuc;
                            sonuc = fk.Guncelle("Urunler", "Urun_barkodNo='" + barkod + "',Urun_adi='" + ad + "',Urun_fiyat='" + fiyat + "',Urun_alisFiyat='" + AlisFiyat.Text + "', Urun_kategori='" + katId + "'", "Urun_id='" + id + "'");
                            if (sonuc == 1)
                            {
                                MessageBox.Show("Ürün başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (Uruns.UrunAdi.Text != "")
                                {
                                    Uruns.GridGuncelle();
                                    Uruns.UrunAra();
                                }
                                else if (Uruns.BarkodNo.Text != "")
                                {
                                    Uruns.GridGuncelle();
                                    Uruns.UrunAraBarkod();
                                }
                                else
                                {
                                    Uruns.GridGuncelle();
                                    Uruns.FormLoad();
                                }
                            }
                            else
                                MessageBox.Show("Ürün güncellenemedi ( Hata kodu: M-03 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Ürünü güncelle //
                        }
                        else
                        {
                            MessageBox.Show("Barkod numarasını 15 hane olarak giriş yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                }
                else
                {
                    // BOŞ ALANLAR
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}