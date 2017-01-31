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
    public partial class UrunKategoriGuncelle : Form
    {
        public UrunKategoriGuncelle()
        {
            InitializeComponent();
        }
        public string id,katadi="";
        Fonksiyonlar fk = new Fonksiyonlar();
        private void KategoriGuncelle_Load(object sender, EventArgs e)
        {
            try
            {
                ToolTip Aciklama = new ToolTip();
                Aciklama.SetToolTip(katekle, "Ürün Kategorisi Ekle");
                // Bağlantı //
                FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                // Bağlantı //

                if (id != null)
                {
                    string KategoriAdi = "";
                    FbDataReader KategoriGetir;
                    FbCommand KategoriSorgu = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_id='" + id + "'", baglanti);
                    baglanti.Open();
                    KategoriGetir = KategoriSorgu.ExecuteReader();
                    KategoriGetir.Read();
                    KategoriAdi = KategoriGetir["Kategori_adi"].ToString();
                    this.Text = KategoriAdi + " - Kategori Güncelleme";
                    UrunKategoriAdi.Text = KategoriAdi;
                    katadi = KategoriGetir["Kategori_adi"].ToString();
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Sistemsel bir hata oluştu, lütfen destek sağlayıcınıza başvurunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButonUrunKategoriGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (UrunKategoriAdi.Text.Length > 0)
                {
                    UrunKategoriAdi.Text = UrunKategoriAdi.Text.Replace("'", "’");
                    if (UrunKategoriAdi.Text != katadi)
                    {
                        UrunKategoriAdi.Text = UrunKategoriAdi.Text.Replace("'", "’");
                        FbConnection b1 = new FbConnection(fk.Baglanti_Kodu());
                        b1.Open();
                        FbCommand KatSor = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_adi='" + fk.IlkHarfleriBuyut(UrunKategoriAdi.Text) + "'", b1);
                        object ss = KatSor.ExecuteScalar();
                        if (ss == null)
                        {
                            b1.Close();
                            byte guncelle;
                            guncelle = fk.Guncelle("Urun_kategori", "Kategori_adi='" + fk.IlkHarfleriBuyut(UrunKategoriAdi.Text) + "'", "Kategori_id='" + id + "'");
                            if (guncelle == 1)
                            {
                                MessageBox.Show("Kategori başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UrunKategori uk = (UrunKategori)Application.OpenForms["UrunKategori"];
                                if (uk.Kategori_Adi.Text.Length > 0)
                                {
                                    uk.Kategori_Adi.Text = UrunKategoriAdi.Text;
                                    uk.GridYenile();
                                    uk.Ara();
                                }
                                else
                                {
                                    uk.GridYenile();
                                    uk.FormLoad();
                                }
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

        private void katekle_Click(object sender, EventArgs e)
        {
            UrunKategoriEkle uke = new UrunKategoriEkle();
            uke.Show();
        }
    }
}
