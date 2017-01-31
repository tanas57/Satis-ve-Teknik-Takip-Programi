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
    public partial class UrunKategoriEkle : Form
    {
        public UrunKategoriEkle()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        private void UrunKategoriEkleButon_Click(object sender, EventArgs e)
        {
            try
            {
                if (KategoriAdi.Text != "")
                {
                    KategoriAdi.Text = KategoriAdi.Text.Replace("'", "’");
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                    baglanti.Open();
                    FbCommand KatSor = new FbCommand("SELECT * FROM URUN_KATEGORI WHERE KATEGORI_ADI='" + fk.IlkHarfleriBuyut(KategoriAdi.Text) + "'", baglanti);
                    object sor = KatSor.ExecuteScalar();
                    if (sor == null)
                    {

                        byte sonuc;
                        sonuc = fk.Ekle("Urun_kategori", "Kategori_adi", "'" + fk.IlkHarfleriBuyut(KategoriAdi.Text) + "'");
                        if (sonuc == 1)
                        {
                            MessageBox.Show("Ürün kategorisi başarıyla eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            KategoriAdi.Text = "";
                        }
                        else
                            MessageBox.Show("Ürün kategorisi eklenemedi ( Hata kodu: K-04 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Eklemek istediğiniz kategori sistemde kayıtlıdır, kategori eklenme iptal edildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Ürün kategorisi ismini girin ( Hata kodu: K-05 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void UrunKategoriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
