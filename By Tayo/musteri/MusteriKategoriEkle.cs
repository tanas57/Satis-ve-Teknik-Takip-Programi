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
    public partial class MusteriKategoriEkle : Form
    {
        public MusteriKategoriEkle()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();

        private void Ekle_Click(object sender, EventArgs e)
        {
            katAdi.Text = katAdi.Text.Replace("'", "’");
            katAdi.Text = fk.IlkHarfleriBuyut(katAdi.Text);
            FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
            baglan.Open();
            FbCommand Kontrol = new FbCommand("SELECT * FROM Musteri_kategori WHERE Kategori_adi='"+katAdi.Text+"'", baglan);
            object k1 = Kontrol.ExecuteScalar();
            if (k1 == null)
            {
                byte sonuc;
                if (katAdi.Text != "")
                {
                    sonuc = fk.Ekle("Musteri_kategori", "Kategori_adi", "'" + katAdi.Text + "'");
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Müşteri kategorisi başarıyla eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        katAdi.Text = "";
                    }
                    else
                        MessageBox.Show("Müşteri kategorisi eklenemedi ( Hata kodu: M-09 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Kategori adını girin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eklemek istediğiniz müşteri kategorisi sistemde kayıtlı bulunmaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            baglan.Close();
        }
    }
}
