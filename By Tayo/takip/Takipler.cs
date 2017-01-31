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
    public partial class Takipler : Form
    {
        public Takipler()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();

        private void Takipler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = fk.TakipSutunOlustur();
            FormLoad();
        }

        private void ButonGuncelle_Click(object sender, EventArgs e)
        {
            TkpGuncelle tg = new TkpGuncelle();
            tg.label8.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tg.marka.Text   = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tg.model.Text   = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tg.imei.Text    = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tg.serino.Text  = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tg.adsoyad.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tg.telefon.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tg.ShowDialog();
        }

        private void ButonSil_Click(object sender, EventArgs e)
        {
            TakipSil ts = new TakipSil();
            ts.label8.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ts.ShowDialog();
        }

        private void TakipAra_Click(object sender, EventArgs e)
        {
            TakipArama();
        }

        public void FormLoad()
        {
            FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
            FbConnection baglan2 = new FbConnection(fk.Baglanti_Kodu());
            baglan.Open();
            FbDataReader oku; object sonuc; DataRow satir;
            FbCommand komut_takip = new FbCommand("SELECT * FROM Teknik_Takip", baglan);

            sonuc = komut_takip.ExecuteScalar();

            if (sonuc != null)
            {
                oku = komut_takip.ExecuteReader();
                while (oku.Read())
                {
                    satir = fk.dt.NewRow();
                    satir["Takip Id"] = oku["Takip_id"].ToString();
                    satir["Takip No"] = oku["Takip_no"].ToString();
                    satir["Cihaz Marka"] = oku["Takip_marka"].ToString();
                    satir["Cihaz Model"] = oku["Takip_model"].ToString();
                    satir["Cihaz İmei"] = oku["Takip_imei"].ToString();
                    satir["Cihaz SeriNo"] = oku["Takip_serino"].ToString();
                    if (oku["Takip_musteri"].ToString() == "")
                    {
                        satir["Müşteri Ad Soyad"] = oku["Takip_kisibilgi"].ToString();
                        satir["Müşteri Telefon"] = oku["Takip_kisiTel"].ToString();
                    }
                    else if (oku["Takip_musteri"].ToString() != "" && oku["Takip_kisibilgi"].ToString() != "")
                    {
                        satir["Müşteri Ad Soyad"] = oku["Takip_kisibilgi"].ToString();
                        satir["Müşteri Telefon"] = oku["Takip_kisiTel"].ToString();
                    }
                    else
                    {
                        baglan2.Open();
                        FbCommand TakipMus = new FbCommand("SELECT Musteri_adi,Musteri_soyadi,Musteri_telefon FROM Musteriler WHERE Musteri_id='" + oku["Takip_musteri"].ToString() + "'", baglan2);
                        FbDataReader TmOku = TakipMus.ExecuteReader();
                        TmOku.Read();
                        satir["Müşteri Ad Soyad"] = TmOku["Musteri_adi"].ToString() + " " + TmOku["Musteri_soyadi"].ToString();
                        satir["Müşteri Telefon"] = TmOku["Musteri_telefon"].ToString();
                        baglan2.Close();
                    }

                    satir["Cihaz Giriş Tarihi"] = Convert.ToDateTime(oku["Takip_girisTarih"].ToString());

                    if (oku["Takip_kapanisTarih"].ToString() != "")
                        satir["Cihaz Çıkış Tarihi"] = Convert.ToDateTime(oku["Takip_kapanisTarih"].ToString());

                    if (oku["Takip_durum"].ToString() == "0") satir["Takip Durum"] = "Kapalı";
                    else satir["Takip Durum"] = "Açık";

                    fk.dt.Rows.Add(satir);
                }
            }
            else
            {
                MessageBox.Show("Ekli takip bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            // bağlantı kapatıldı
            baglan.Close();
        }

        public void TakipArama()
        {
            FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
            FbConnection baglan2 = new FbConnection(fk.Baglanti_Kodu());
            if (takipno.Text != "")
            {

                baglan.Open();

                FbCommand TkpAra = new FbCommand("SELECT * FROM Teknik_Takip WHERE Takip_no='" + takipno.Text + "'", baglan);
                object sonuc = TkpAra.ExecuteScalar();
                if (sonuc != null)
                {
                    fk.dt.Clear();
                    dataGridView1.Refresh();
                    FbDataReader oku = TkpAra.ExecuteReader(); DataRow satir;
                    oku.Read();
                    satir = fk.dt.NewRow();
                    satir["Takip Id"] = oku["Takip_id"].ToString();
                    satir["Takip No"] = oku["Takip_no"].ToString();
                    satir["Cihaz Marka"] = oku["Takip_marka"].ToString();
                    satir["Cihaz Model"] = oku["Takip_model"].ToString();
                    satir["Cihaz İmei"] = oku["Takip_imei"].ToString();
                    satir["Cihaz SeriNo"] = oku["Takip_serino"].ToString();
                    if (oku["Takip_musteri"].ToString() == "")
                    {
                        satir["Müşteri Ad Soyad"] = oku["Takip_kisibilgi"].ToString();
                        satir["Müşteri Telefon"] = oku["Takip_kisiTel"].ToString();
                    }
                    else if (oku["Takip_musteri"].ToString() != "" && oku["Takip_kisibilgi"].ToString() != "")
                    {
                        satir["Müşteri Ad Soyad"] = oku["Takip_kisibilgi"].ToString();
                        satir["Müşteri Telefon"] = oku["Takip_kisiTel"].ToString();
                    }
                    else
                    {
                        baglan2.Open();
                        FbCommand TakipMus = new FbCommand("SELECT Musteri_adi,Musteri_soyadi,Musteri_telefon FROM Musteriler WHERE Musteri_id='" + oku["Takip_musteri"].ToString() + "'", baglan2);
                        FbDataReader TmOku = TakipMus.ExecuteReader();
                        TmOku.Read();
                        satir["Müşteri Ad Soyad"] = TmOku["Musteri_adi"].ToString() + " " + TmOku["Musteri_soyadi"].ToString();
                        satir["Müşteri Telefon"] = TmOku["Musteri_telefon"].ToString();
                        baglan2.Close();
                    }

                    satir["Cihaz Giriş Tarihi"] = Convert.ToDateTime(oku["Takip_girisTarih"].ToString());

                    if (oku["Takip_kapanisTarih"].ToString() != "")
                        satir["Cihaz Çıkış Tarihi"] = Convert.ToDateTime(oku["Takip_kapanisTarih"].ToString());

                    if (oku["Takip_durum"].ToString() == "0") satir["Takip Durum"] = "Kapalı";
                    else satir["Takip Durum"] = "Açık";

                    fk.dt.Rows.Add(satir);
                }
                else
                {
                    MessageBox.Show("Aranan takip bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                baglan.Close();
            }
            else
            {
                MessageBox.Show("Lütfen takip numarasını girin. Hata kodu (T-014)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GridGuncelle()
        {
            fk.dt.Clear();
            dataGridView1.Refresh();
        }
    }
}
