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
    public partial class MusteriSil : Form
    {
        public MusteriSil()
        {
            InitializeComponent();
        }
        public string id;
        Fonksiyonlar fk = new Fonksiyonlar();
        private void MusteriSil_Load(object sender, EventArgs e)
        {
            // Bağlantı //
            FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
            // Bağlantı //

            baglanti.Open();
            FbCommand KategoriAdiSorgu = new FbCommand("SELECT Musteri_adi,Musteri_soyadi FROM Musteriler WHERE Musteri_id='" + id + "'", baglanti);
            FbDataReader KatAdiOku; KatAdiOku = KategoriAdiSorgu.ExecuteReader(); KatAdiOku.Read();
            this.Text = KatAdiOku["Musteri_adi"].ToString() + " " + KatAdiOku["Musteri_soyadi"].ToString() + " - Müşteri Silinecek";
            baglanti.Close();
            label1.Text = this.Text;
        }

        private void SilEvet_Click(object sender, EventArgs e)
        {
            Musteri FormM = (Musteri)Application.OpenForms["Musteri"];
            byte sonuc;
            FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
            FbConnection baglan1 = new FbConnection(fk.Baglanti_Kodu());
            FbConnection baglan2 = new FbConnection(fk.Baglanti_Kodu());

            // Müşteri sipariş verdiyse bu siparişleri silicez.

            baglan.Open();
            FbCommand MusUrun = new FbCommand("SELECT Satis_urun FROM Satis WHERE Satis_musteri='" + id + "'", baglan);
            string[] urun_id = new string[0];
            FbDataReader UrunidOku = MusUrun.ExecuteReader(); int i = 0;
            while (UrunidOku.Read())
            {
                Array.Resize(ref urun_id, urun_id.Length + 1);
                urun_id[i] = UrunidOku["Satis_urun"].ToString();
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
                FbCommand RaporTab = new FbCommand("SELECT rapor_id,rapor_sayac FROM Rapor WHERE rapor_satisId='" + uid + "'", baglan);
                FbDataReader RaporIdOku = RaporTab.ExecuteReader();
                while (RaporIdOku.Read())
                {
                    if (int.Parse(RaporIdOku["rapor_sayac"].ToString()) > 1)
                        {
                            fk.Guncelle("Rapor", "rapor_sayac=rapor_sayac-1", "rapor_id='"+RaporIdOku["rapor_id"].ToString()+"'");
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
            FbCommand TeknikTab = new FbCommand("SELECT Takip_id FROM Teknik_Takip WHERE Takip_musteri='" + id + "'", baglan);
            FbDataReader Takipid = TeknikTab.ExecuteReader();
            string[] takip_id = new string[0]; int b =0;
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
                fk.Sil("Teknik_Takip", "Takip_id='" + tid + "'");

            }
             
            

            sonuc = fk.Sil("Musteriler", "Musteri_id='" + id + "'");
            if (sonuc == 1)
            {
                MessageBox.Show("Müşteri başarıyla silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FormM.GridYenile();
                FormM.KaraListe.Items.Clear();
                FormM.GridListe();
            }
            else
            {
                MessageBox.Show("Müşteri silinemedi ( Hata kodu: M-08 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SilHayir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Müşteri silme işlemi iptal edilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
