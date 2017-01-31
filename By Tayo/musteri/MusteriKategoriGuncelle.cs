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
    public partial class MusteriKategoriGuncelle : Form
    {
        public MusteriKategoriGuncelle()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        public string id;
        private void MusteriKategoriGuncelle_Load(object sender, EventArgs e)
        {
            FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
            baglan.Open();
            FbCommand katBilgi = new FbCommand("SELECT * FROM Musteri_kategori WHERE Kategori_id='" + id + "'", baglan);
            FbDataReader katOku = katBilgi.ExecuteReader();
            katOku.Read();
            string kategori_adi = katOku[1].ToString();
            this.Text = kategori_adi + " - Kategorisi güncelleniyor";
            katAdi.Text = kategori_adi;
            baglan.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            katAdi.Text = katAdi.Text.Replace("'", "’");
            katAdi.Text = fk.IlkHarfleriBuyut(katAdi.Text);
            FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
            baglan.Open();
            FbCommand Kontrol = new FbCommand("SELECT * FROM Musteri_kategori WHERE Kategori_adi='"+katAdi.Text+"'", baglan);
            object k1 = Kontrol.ExecuteScalar();
            if (k1 == null)
            {
                byte sonuc = fk.Guncelle("Musteri_kategori", "Kategori_adi='" + katAdi.Text + "'", "Kategori_id='" + id + "'");
                if (sonuc == 1)
                {
                    MessageBox.Show("Müşteri kategorisi başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Müşteri kategorisi güncellenemedi ( Hata kodu: M-11 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Güncellenmek istenen kategori sistemde kayıtlı bulunduğundan güncellenmemiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            baglan.Close();
        }
    }
}
