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
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
        }

        Fonksiyonlar fk = new Fonksiyonlar();
        string tarih = "";
        private void Satislar_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = fk.SatisStunOlustur();
            FormLoad();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            SatisIptali();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SatisId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void ara_Click(object sender, EventArgs e)
        {
            SatisAra();
        }

        public void FormLoad()
        {
            DataRow satir;
            label1.Text = DateTime.Now.Day.ToString() + " / " + DateTime.Now.Month.ToString() + " / " + DateTime.Now.Year.ToString() + " - Günü Satışları";
            tarih = DateTime.Now.ToString("yyyy-MM-dd");
            FbConnection b1 = new FbConnection(fk.Baglanti_Kodu());
            FbConnection b2 = new FbConnection(fk.Baglanti_Kodu());

            b1.Open();
            FbCommand SecilenTarihSatis = new FbCommand("SELECT * FROM Satis WHERE Satis_tarih='" + tarih + "'", b1);
            object kontrol = SecilenTarihSatis.ExecuteScalar();
            if (kontrol != null)
            {
                fk.dt.Clear();
                dataGridView1.Refresh();
                FbDataReader SatisOku = SecilenTarihSatis.ExecuteReader();
                while (SatisOku.Read())
                {
                    satir = fk.dt.NewRow();
                    satir["Satış Id"] = "S " + SatisOku["Satis_id"].ToString();
                    b2.Open();
                    FbCommand UrunAdi = new FbCommand("SELECT Urun_adi FROM Urunler WHERE Urun_id='" + SatisOku["Satis_urun"].ToString() + "'", b2);
                    FbDataReader UrunAdiOku = UrunAdi.ExecuteReader();
                    UrunAdiOku.Read();
                    satir["Satış Ürün"] = UrunAdiOku["Urun_adi"].ToString();
                    b2.Close();
                    if (SatisOku["Satis_musteri"].ToString() == "")
                    {
                        satir["Satış Müşteri"] = "Standart Satış";
                    }
                    else
                    {
                        b2.Open();
                        FbCommand MusteriAdi = new FbCommand("SELECT Musteri_adi,Musteri_soyadi FROM Musteriler WHERE Musteri_id='" + SatisOku["Satis_musteri"].ToString() + "'", b2);
                        FbDataReader MusteriAdiOku = MusteriAdi.ExecuteReader();
                        MusteriAdiOku.Read();
                        satir["Satış Müşteri"] = MusteriAdiOku["Musteri_adi"].ToString() + " " + MusteriAdiOku["Musteri_soyadi"].ToString();
                        b2.Close();
                    }
                    satir["Satış Tarihi"] = SatisOku["Satis_tarih"].ToString();
                    if (SatisOku["Satis_not"].ToString() == "")
                    {
                        satir["Satış Notu"] = "Not Eklenmemiş";
                    }
                    else
                    {
                        satir["Satış Notu"] = SatisOku["Satis_not"].ToString();
                    }
                    fk.dt.Rows.Add(satir);
                }
            }
            else
            {
                MessageBox.Show("Seçilen tarihte satış yapılmamıştır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            b1.Close();

            b1.Open();
            FbCommand ManuelSatis = new FbCommand("SELECT * FROM ManuelSatis WHERE satis_tarih='" + tarih + "'", b1);
            object sn = ManuelSatis.ExecuteScalar();
            if (sn != null)
            {
                FbDataReader okuu = ManuelSatis.ExecuteReader();
                while (okuu.Read())
                {
                    satir = fk.dt.NewRow();
                    satir["Satış Id"] = "M " + okuu["satis_id"].ToString();
                    satir["Satış Ürün"] = okuu["satis_urunadi"].ToString();
                    if (okuu["satis_musteri"].ToString() == "")
                    {
                        satir["Satış Müşteri"] = "Standart Satış";
                    }
                    else
                    {
                        b2.Open();
                        FbCommand MusteriAdi = new FbCommand("SELECT Musteri_adi,Musteri_soyadi FROM Musteriler WHERE Musteri_id='" + okuu["satis_musteri"].ToString() + "'", b2);
                        FbDataReader MusteriAdiOku = MusteriAdi.ExecuteReader();
                        MusteriAdiOku.Read();
                        satir["Satış Müşteri"] = MusteriAdiOku["Musteri_adi"].ToString() + " " + MusteriAdiOku["Musteri_soyadi"].ToString();
                        b2.Close();
                    }
                    satir["Satış Tarihi"] = okuu["satis_tarih"].ToString();
                    if (okuu["Satis_not"].ToString() == "")
                    {
                        satir["Satış Notu"] = "Not Eklenmemiş";
                    }
                    else
                    {
                        satir["Satış Notu"] = okuu["satis_not"].ToString();
                    }
                    fk.dt.Rows.Add(satir);
                }
            }
            b1.Close();
        }

        public void SatisAra()
        {
            try
            {
                tarih = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                DataRow satir;
                FbConnection b1 = new FbConnection(fk.Baglanti_Kodu());
                FbConnection b2 = new FbConnection(fk.Baglanti_Kodu());

                b1.Open();
                FbCommand SecilenTarihSatis = new FbCommand("SELECT * FROM Satis WHERE Satis_tarih='" + tarih + "'", b1);
                object kontrol = SecilenTarihSatis.ExecuteScalar();
                if (kontrol != null)
                {
                    fk.dt.Clear();
                    dataGridView1.Refresh();
                    FbDataReader SatisOku = SecilenTarihSatis.ExecuteReader();
                    label1.Text = dateTimePicker1.Value.ToString("dd / MM / yyyy") + " - Günü Satışları";
                    while (SatisOku.Read())
                    {
                        satir = fk.dt.NewRow();
                        satir["Satış Id"] = "S " + SatisOku["Satis_id"].ToString();
                        b2.Open();
                        FbCommand UrunAdi = new FbCommand("SELECT Urun_adi FROM Urunler WHERE Urun_id='" + SatisOku["Satis_urun"].ToString() + "'", b2);
                        FbDataReader UrunAdiOku = UrunAdi.ExecuteReader();
                        UrunAdiOku.Read();
                        satir["Satış Ürün"] = UrunAdiOku["Urun_adi"].ToString();
                        b2.Close();
                        if (SatisOku["Satis_musteri"].ToString() == "")
                        {
                            satir["Satış Müşteri"] = "Standart Satış";
                        }
                        else
                        {
                            b2.Open();
                            FbCommand MusteriAdi = new FbCommand("SELECT Musteri_adi,Musteri_soyadi FROM Musteriler WHERE Musteri_id='" + SatisOku["Satis_musteri"].ToString() + "'", b2);
                            FbDataReader MusteriAdiOku = MusteriAdi.ExecuteReader();
                            MusteriAdiOku.Read();
                            satir["Satış Müşteri"] = MusteriAdiOku["Musteri_adi"].ToString() + " " + MusteriAdiOku["Musteri_soyadi"].ToString();
                            b2.Close();
                        }
                        satir["Satış Tarihi"] = SatisOku["Satis_tarih"].ToString();
                        if (SatisOku["Satis_not"].ToString() == "")
                        {
                            satir["Satış Notu"] = "Not Eklenmemiş";
                        }
                        else
                        {
                            satir["Satış Notu"] = SatisOku["Satis_not"].ToString();
                        }
                        fk.dt.Rows.Add(satir);
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen tarihte satış yapılmamıştır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                b1.Close();

                b1.Open();
                FbCommand ManuelSatis = new FbCommand("SELECT * FROM ManuelSatis WHERE satis_tarih='" + tarih + "'", b1);
                object sn = ManuelSatis.ExecuteScalar();
                if (sn != null)
                {
                    FbDataReader okuu = ManuelSatis.ExecuteReader();
                    while (okuu.Read())
                    {
                        satir = fk.dt.NewRow();
                        satir["Satış Id"] = "M " + okuu["satis_id"].ToString();
                        satir["Satış Ürün"] = okuu["satis_urunadi"].ToString();
                        if (okuu["satis_musteri"].ToString() == "")
                        {
                            satir["Satış Müşteri"] = "Standart Satış";
                        }
                        else
                        {
                            b2.Open();
                            FbCommand MusteriAdi = new FbCommand("SELECT Musteri_adi,Musteri_soyadi FROM Musteriler WHERE Musteri_id='" + okuu["satis_musteri"].ToString() + "'", b2);
                            FbDataReader MusteriAdiOku = MusteriAdi.ExecuteReader();
                            MusteriAdiOku.Read();
                            satir["Satış Müşteri"] = MusteriAdiOku["Musteri_adi"].ToString() + " " + MusteriAdiOku["Musteri_soyadi"].ToString();
                            b2.Close();
                        }
                        satir["Satış Tarihi"] = okuu["satis_tarih"].ToString();
                        if (okuu["Satis_not"].ToString() == "")
                        {
                            satir["Satış Notu"] = "Not Eklenmemiş";
                        }
                        else
                        {
                            satir["Satış Notu"] = okuu["satis_not"].ToString();
                        }
                        fk.dt.Rows.Add(satir);
                    }
                }
                b1.Close();
            }
            catch (Exception h1)
            {
                MessageBox.Show(h1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SatisIptali()
        {
            try
            {
                SatisId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string[] ads = SatisId.Text.Split(' ');
                if (ads[0] == "S")
                {
                    SatisId.Text = ads[1].ToString();
                    FbConnection b1 = new FbConnection(fk.Baglanti_Kodu());

                    b1.Open();
                    FbCommand SatisUrun = new FbCommand("SELECT Satis_urun FROM Satis WHERE Satis_id='" + SatisId.Text + "'", b1);
                    FbDataReader Oku = SatisUrun.ExecuteReader();
                    Oku.Read();
                    string urunid = Oku["Satis_urun"].ToString();
                    Oku.Close();
                    b1.Close();

                    DialogResult m = MessageBox.Show(dataGridView1.CurrentRow.Cells[1].Value.ToString() + " Satışı iptal edilecek. Emin misiniz ? ", "Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == m)
                    {
                        fk.Sil("Satis", "Satis_id='" + SatisId.Text + "' and Satis_tarih='" + tarih + "'");
                        b1.Open();
                        FbCommand RaporSor = new FbCommand("SELECT * FROM Rapor WHERE rapor_satisId='" + urunid + "' and rapor_tarih='" + tarih + "'", b1);
                        FbDataReader cek = RaporSor.ExecuteReader();
                        cek.Read(); int say = int.Parse(cek["rapor_sayac"].ToString()); cek.Close();
                        b1.Close();
                        if (say > 1)
                        {
                            byte sonuc = fk.Guncelle("Rapor", "rapor_sayac=rapor_sayac-1", "rapor_satisId='" + urunid + "' and rapor_tarih='" + tarih + "'");
                            if (sonuc == 1)
                            {
                                MessageBox.Show("Satış başarıyla silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GridGuncelle();
                                FormLoad();
                            }
                            else
                            {
                                MessageBox.Show("Satış silinemedi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            byte sonuc = fk.Sil("Rapor", "rapor_satisId='" + urunid + "' and rapor_tarih='" + tarih + "'");
                            if (sonuc == 1)
                            {
                                MessageBox.Show("Satış başarıyla silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GridGuncelle();
                                FormLoad();
                            }
                            else
                            {
                                MessageBox.Show("Satış silinemedi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    SatisId.Text = ads[1].ToString();
                    DialogResult m = MessageBox.Show(dataGridView1.CurrentRow.Cells[1].Value.ToString() + " Satışı iptal edilecek. Emin misiniz ? ", "Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == m)
                    {
                        byte sonuc = fk.Sil("ManuelSatis", "satis_id='" + SatisId.Text + "'");
                        if (sonuc == 1)
                        {
                            MessageBox.Show("Satış başarıyla silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Satış silinemedi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GridGuncelle()
        {
            fk.dt.Clear();
            dataGridView1.Refresh();
        }
    }
}
