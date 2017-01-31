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
    public partial class UrunKategoriSil : Form
    {
        public UrunKategoriSil()
        {
            InitializeComponent();
        }
        public string id;
        Fonksiyonlar fk = new Fonksiyonlar();
        string katadi;
        private void UrunKategoriSil_Load(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı //
                FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                // Bağlantı //

                // Müşter hangi kategoride //
                baglanti.Open();
                FbCommand KategoriAdiSorgu = new FbCommand("SELECT Kategori_adi FROM Urun_kategori WHERE Kategori_id='" + id + "'", baglanti);
                FbDataReader KatAdiOku; KatAdiOku = KategoriAdiSorgu.ExecuteReader(); KatAdiOku.Read();
                this.Text = KatAdiOku["Kategori_adi"].ToString() + " - Kategori Silinecek";
                katadi = KatAdiOku["Kategori_adi"].ToString();
                baglanti.Close();
                label1.Text = this.Text;
                // Müşter hangi kategoride //
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SilEvet_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult SilSor = MessageBox.Show("Seçmiş olduğunuz " + katadi + " kategorisi ve bu kategoride eklenmiş tüm ürünler silinecektir. Onaylıyor musunuz ? ", "Kategori Silinecek Onaylıyor Musunuz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (SilSor == DialogResult.Yes)
                {
                    byte sonuc;

                    FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                    FbConnection baglan2 = new FbConnection(fk.Baglanti_Kodu());
                    baglan.Open();
                    FbCommand UrunKategori = new FbCommand("SELECT Urun_id FROM Urunler WHERE Urun_kategori='" + id + "'", baglan);
                    object sor = UrunKategori.ExecuteScalar();
                    if (sor != null)
                    {
                        FbDataReader UrunKategoriId = UrunKategori.ExecuteReader();
                        string[] urun_id = new string[0]; int i = 0;
                        while (UrunKategoriId.Read())
                        {
                            Array.Resize(ref urun_id, urun_id.Length + 1);
                            urun_id[i] = UrunKategoriId["Urun_id"].ToString();
                            i++;

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
                            FbCommand RaporTab = new FbCommand("SELECT rapor_id FROM Rapor WHERE rapor_satisId='" + uid + "'", baglan);
                            FbDataReader RaporIdOku = RaporTab.ExecuteReader();
                            while (RaporIdOku.Read())
                            {
                                fk.Sil("Rapor", "rapor_id='" + RaporIdOku["rapor_id"].ToString() + "'");
                            }
                            baglan.Close();
                            fk.Sil("Urunler", "Urun_id='" + uid + "'");
                        }

                        sonuc = fk.Sil("Urun_kategori", "Kategori_id='" + id + "'");
                        if (sonuc == 1)
                        {
                            MessageBox.Show("Ürün kategorisi başarıyla silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            UrunKategori uk = (UrunKategori)Application.OpenForms["UrunKategori"];
                            uk.GridYenile();
                            uk.FormLoad();
                        }
                        else
                        {
                            MessageBox.Show("Ürün kategorisi silinemedi ( Hata kodu: K-07 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        byte sonuc2;
                        sonuc2 = fk.Sil("Urun_kategori", "Kategori_id='" + id + "'");
                        if (sonuc2 == 1)
                        {
                            MessageBox.Show("Ürün kategorisi başarıyla silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            UrunKategori uk = (UrunKategori)Application.OpenForms["UrunKategori"];
                            uk.GridYenile();
                            uk.FormLoad();
                        }
                        else
                        {
                            MessageBox.Show("Ürün kategorisi silinemedi ( Hata kodu: K-07 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    baglan.Close();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SilHayir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün kategorisi silme işlemi iptal edilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
