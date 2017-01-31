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
    public partial class MusteriSil2 : Form
    {
        public MusteriSil2()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        string id;
        private void AramaMusteriAdi_TextChanged(object sender, EventArgs e)
        {
            if (AramaMusteriAdi.Text.Length > 0)
            {
                AramaMusteriAdi.Text = AramaMusteriAdi.Text.Replace("'", "’");
                string adsoyad2 = fk.IlkHarfleriBuyut(AramaMusteriAdi.Text);
                FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                FbDataReader MusteriOku; object sonuc;
                baglanti.Open();
                FbCommand MusteriAraSorgu = new FbCommand("SELECT * FROM Musteriler WHERE Musteri_adi like '%" + AramaMusteriAdi.Text + "%' or Musteri_soyadi like '%" + AramaMusteriAdi.Text + "%' or Musteri_adi like '%" + adsoyad2 + "%' or Musteri_soyadi like '%" + adsoyad2 + "%'", baglanti);
                sonuc = MusteriAraSorgu.ExecuteScalar();
                Musteri_adi_combo.Items.Clear();
                if (sonuc != null)
                {
                    MusteriOku = MusteriAraSorgu.ExecuteReader();
                    while (MusteriOku.Read())
                    {
                        Musteri_adi_combo.Items.Add(MusteriOku["Musteri_adi"].ToString() + " " + MusteriOku["Musteri_soyadi"].ToString());
                    }
                    Musteri_adi_combo.Enabled = true;
                    Musteri_adi_combo.SelectedIndex = 0;
                    MusteriSil.Enabled = true;
                    label1.Show();
                }
                else
                {
                    MessageBox.Show("Aranan isme / soyisme göre müşteri bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                baglanti.Close();
            }
            else
            {
                Musteri_adi_combo.Enabled = false;
                Musteri_adi_combo.SelectedIndex = -1;
                MusteriSil.Enabled = false;
                MusteriSil.Enabled = false;
                label1.Hide();
            }
        }

        private void Musteri_adi_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Musteri_adi_combo.Text.Length > 0)
            {
                // Müşteri bilgileri //
                string adsoyad = Musteri_adi_combo.Text;
                string[] ads = adsoyad.Split(' ');
                FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                FbDataReader MusteriBilgi;
                FbCommand MusteriSorgu = new FbCommand("SELECT * FROM Musteriler WHERE Musteri_adi='" + ads[0] + "' and Musteri_soyadi='" + ads[1] + "'", baglanti);
                baglanti.Open();
                object mK = MusteriSorgu.ExecuteScalar();
                if (mK != null)
                {
                    MusteriBilgi = MusteriSorgu.ExecuteReader(); MusteriBilgi.Read();
                    id = MusteriBilgi["Musteri_id"].ToString();
                    this.Text = MusteriBilgi["Musteri_adi"] + " " + MusteriBilgi["Musteri_soyadi"] + " - Müşteri Silinecek";
                    label1.Text = this.Text;
                    label1.Show();
                }
                else
                {
                    MessageBox.Show("Sistemsel bir hata oluştu, lütfen sağlayıcınızla iletişime geçiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                baglanti.Close();
                // Müşteri bilgileri //
            }
            else
            {
                MusteriSil.Enabled = false;
                label1.Hide();
            }
        }

        private void SilEvet_Click(object sender, EventArgs e)
        {
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
            FbCommand TeknikTab = new FbCommand("SELECT Takip_id FROM Teknik_Takip WHERE Takip_musteri='" + id + "'", baglan);
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

                fk.Sil("Teknik_TakipIslemler", "Takip_id='" + tid + "'");
                fk.Sil("Teknik_Takip", "Takip_id='" + tid + "'");

            }
             
            

            sonuc = fk.Sil("Musteriler", "Musteri_id='" + id + "'");
            if (sonuc == 1)
            {
                MessageBox.Show("Müşteri başarıyla silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Müşteri silinemedi ( Hata kodu: M-09 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SilHayir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Müşteri silme işlemi iptal edilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void MusteriSil2_Load(object sender, EventArgs e)
        {

        }
    }
}