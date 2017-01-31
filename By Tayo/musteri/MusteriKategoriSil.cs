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
    public partial class MusteriKategoriSil : Form
    {
        public MusteriKategoriSil()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        public string id;

        private void MusteriKategoriSil_Load(object sender, EventArgs e)
        {
            FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
            baglan.Open();
            FbCommand katBilgi = new FbCommand("SELECT * FROM Musteri_kategori WHERE Kategori_id='" + id + "'", baglan);
            FbDataReader katOku = katBilgi.ExecuteReader();
            katOku.Read();
            string kategori_adi = katOku[1].ToString();
            this.Text = kategori_adi + " - Kategorisi siliniyor";
            label1.Text = this.Text;
            baglan.Close();
        }

        private void Sil_Click(object sender, EventArgs e)
        {

            FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
            FbConnection baglan1 = new FbConnection(fk.Baglanti_Kodu());
            FbConnection baglan2 = new FbConnection(fk.Baglanti_Kodu());
			
			// Müşteri kategorisine göre
			
			baglan.Open();
            FbCommand MusKat = new FbCommand("SELECT Musteri_id FROM Musteriler WHERE Musteri_kategori='" + id + "'", baglan);
            string[] musteri_id = new string[0];
            FbDataReader MusKatOku = MusKat.ExecuteReader(); int i = 0;
            while (MusKatOku.Read())
            {
                Array.Resize(ref musteri_id, musteri_id.Length + 1);
                musteri_id[i] = MusKatOku["Musteri_id"].ToString();
                i++;
            }
            baglan.Close();

            foreach (string mid in musteri_id)
            {

                // Müşteri sipariş verdiyse bu siparişleri silicez.

                baglan.Open();
                FbCommand MusUrun = new FbCommand("SELECT Satis_urun FROM Satis WHERE Satis_musteri='" + mid + "'", baglan);
                string[] urun_id = new string[0];
                FbDataReader UrunidOku = MusUrun.ExecuteReader(); int k = 0;
                while (UrunidOku.Read())
                {
                    Array.Resize(ref urun_id, urun_id.Length + 1);
                    urun_id[k] = UrunidOku["Satis_urun"].ToString();
                    k++;
                }
                baglan.Close();

                foreach (string uid in urun_id)
                {
                    baglan.Open();
                    FbCommand SatisTab = new FbCommand("SELECT Satis_id FROM Satis WHERE Satis_urun='" + uid + "'", baglan);
                    FbDataReader SatisIdOku = SatisTab.ExecuteReader();
                    while (SatisIdOku.Read())
                    {
                        fk.Sil("Satis", "Satis_id='" + SatisIdOku["Satis_id"].ToString() + "'");
                    }
                    baglan.Close();

                    baglan.Open();
                    FbCommand RaporTab = new FbCommand("SELECT rapor_id,rapor_sayac FROM Rapor WHERE rapor_satisId='" + uid + "'", baglan);
                    FbDataReader RaporIdOku = RaporTab.ExecuteReader();
                    while (RaporIdOku.Read())
                    {
                        if (int.Parse(RaporIdOku["rapor_sayac"].ToString()) > 1)
                        {
                            fk.Guncelle("Rapor", "rapor_sayac=rapor_sayac-1", "rapor_id='" + RaporIdOku["rapor_id"].ToString() + "'");
                        }
                        else
                        {
                            fk.Sil("Rapor", "rapor_id='" + RaporIdOku["rapor_id"].ToString() + "'");
                        }
                    }
                    baglan.Close();
                }

                // Teknik takipleri sil
                baglan.Open();
                FbCommand TeknikTab = new FbCommand("SELECT Takip_id FROM TeknikTakip WHERE Takip_musteri='" + mid + "'", baglan);
                FbDataReader Takipid = TeknikTab.ExecuteReader();
                string[] takip_id = new string[0]; int b = 0;
                while (Takipid.Read())
                {
                    Array.Resize(ref takip_id, takip_id.Length + 1);
                    takip_id[b] = Takipid["Takip_id"].ToString();
                    b++;
                }
                baglan.Close();

                foreach (string tid in takip_id)
                {

                    fk.Sil("TeknikTakipIslemler", "Takip_id='" + tid + "'");
                    fk.Sil("TeknikTakip", "Takip_id='" + tid + "'");

                }
                fk.Sil("Musteriler", "Musteri_id='" + mid + "'");
            }

            byte sonuc = fk.Sil("Musteri_kategori", "Kategori_id='"+id+"'");
            if (sonuc == 1)
            {
                MessageBox.Show("Müşteri kategorisi başarıyla silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Müşteri kategorisi silinemedi ( Hata kodu: M-10 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
        }

        private void Silme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silme işlemi iptal edilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
