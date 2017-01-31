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
    public partial class UrunSil : Form
    {
        public UrunSil()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        public string id;
        private void UrunSil_Load(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı //
                FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                // Bağlantı //

                baglanti.Open();
                FbCommand KategoriAdiSorgu = new FbCommand("SELECT Urun_adi FROM Urunler WHERE Urun_id='" + id + "'", baglanti);
                FbDataReader KatAdiOku; KatAdiOku = KategoriAdiSorgu.ExecuteReader(); KatAdiOku.Read();
                this.Text = KatAdiOku["Urun_adi"].ToString() + " - Ürün Silinecek";
                baglanti.Close();
                label1.Text = this.Text;
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
                byte sonuc;
                Urunler Uruns = (Urunler)Application.OpenForms["Urunler"];
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbCommand SatisTab = new FbCommand("SELECT Satis_id FROM Satis WHERE Satis_urun='" + id + "'", baglan);
                FbDataReader SatisIdOku = SatisTab.ExecuteReader();
                while (SatisIdOku.Read())
                {
                    fk.Sil("Satis", "Satis_id='" + SatisIdOku["Satis_id"].ToString() + "'");
                }
                baglan.Close();

                baglan.Open();
                FbCommand RaporTab = new FbCommand("SELECT rapor_id FROM Rapor WHERE rapor_satisId='" + id + "'", baglan);
                FbDataReader RaporIdOku = RaporTab.ExecuteReader();
                while (RaporIdOku.Read())
                {
                    fk.Sil("Rapor", "rapor_id='" + RaporIdOku["rapor_id"].ToString() + "'");
                }
                baglan.Close();

                sonuc = fk.Sil("Urunler", "Urun_id='" + id + "'");
                if (sonuc == 1)
                {
                    MessageBox.Show("Ürün başarıyla silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Uruns.GridGuncelle();
                    Uruns.FormLoad();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ürün silinemedi ( Hata kodu: U-04 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SilHayir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Müşteri silme işlemi iptal edilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
