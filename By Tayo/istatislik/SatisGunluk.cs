using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms.DataVisualization.Charting;
namespace By_Tayo
{
    public partial class SatisGunluk : Form
    {
        public SatisGunluk()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        public string[] urunler;
        private void SatisGunluk_Load(object sender, EventArgs e)
        {
                label1.Text = DateTime.Now.Day.ToString() + " / " + DateTime.Now.Month.ToString() + " / " + DateTime.Now.Year.ToString() + " - Günü Raporları";
                string tarih = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                float top = 0; int i = 0; float top2 = 0;

                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                FbConnection baglan2 = new FbConnection(fk.Baglanti_Kodu());
                FbConnection baglan3 = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();

                //FbCommand BugunkuSatis = new FbCommand("SELECT Satis_urun FROM Satis WHERE Satis_tarih='" + tarih + "'", baglan);
                FbCommand BugunkuSatis = new FbCommand("SELECT Satis_urun FROM Satis WHERE Satis_tarih='" + tarih + "'", baglan);
                //FbCommand KacAdet = new FbCommand("SELECT COUNT(*) FROM Satis WHERE Satis_tarih='" + tarih + "'", baglan); object SatirSayisi = KacAdet.ExecuteScalar();
                FbCommand KacAdet = new FbCommand("SELECT COUNT(*) FROM Satis WHERE Satis_tarih='" + tarih + "'", baglan); object SatirSayisi = KacAdet.ExecuteScalar();
                FbDataReader oku1; object SatisSonuc;

                SatisSonuc = BugunkuSatis.ExecuteScalar();
                if (SatisSonuc != null)
                {
                    urunler = new string[int.Parse(SatirSayisi.ToString())];
                    oku1 = BugunkuSatis.ExecuteReader();

                    while (oku1.Read())
                    {
                        urunler[i] = oku1["Satis_urun"].ToString();
                        i++;
                    }
                    oku1.Close();
                    baglan.Close();

                    baglan2.Open();
                    FbDataReader oku2;
                    for (int j = 0; j <= int.Parse(SatirSayisi.ToString()) - 1; j++)
                    {
                        FbCommand UrunFiyat = new FbCommand("SELECT Urun_fiyat FROM Urunler WHERE Urun_id='" + urunler[j] + "'", baglan2);

                        oku2 = UrunFiyat.ExecuteReader();
                        oku2.Read();

                        top += float.Parse(oku2["Urun_fiyat"].ToString());

                        label5.Text = top.ToString();
                        oku2.Close();
                    }
                    baglan2.Close();
                    label5.Text += "  TL";

                    // alış fiyatlarını topla

                    baglan2.Open();
                    FbDataReader say;
                    for (int d = 0; d <= int.Parse(SatirSayisi.ToString()) - 1; d++)
                    {
                        FbCommand UrunFiyat = new FbCommand("SELECT Urun_alisFiyat FROM Urunler WHERE Urun_id='" + urunler[d] + "'", baglan2);

                        say = UrunFiyat.ExecuteReader();
                        say.Read();

                        top2 += float.Parse(say["Urun_AlisFiyat"].ToString());

                        say.Close();
                    }
                    baglan2.Close();
                    // alış fiyatlarını topla

                    // net Kar
                    label9.Text = (top - top2).ToString() + "  TL";
                    // net Kar

                    baglan.Open();
                    FbCommand EncokSatilan = new FbCommand("SELECT Urun_adi FROM Urunler WHERE Urun_id = ( SELECT first 1 rapor_satisId FROM Rapor WHERE rapor_tarih='" + tarih + "' and rapor_sayac = ( SELECT MAX(rapor_sayac) FROM Rapor WHERE rapor_tarih='" + tarih + "'))", baglan);
                    FbDataReader EncokStOku = EncokSatilan.ExecuteReader();
                    EncokStOku.Read();
                    label6.Text = EncokStOku["Urun_adi"].ToString();

                    baglan.Close();

                    baglan.Open();
                    FbCommand EncokKategori = new FbCommand("SELECT Kategori_adi FROM Urun_kategori WHERE Kategori_id = (SELECT first 10 Urun_kategori FROM Urunler WHERE Urun_id = ( SELECT first 1 rapor_satisId FROM Rapor WHERE rapor_tarih='" + tarih + "' and rapor_sayac = ( SELECT MAX(rapor_sayac) FROM Rapor WHERE rapor_tarih='" + tarih + "')))", baglan);
                    FbDataReader EncokKtOku = EncokKategori.ExecuteReader();
                    EncokKtOku.Read();
                    label7.Text = EncokKtOku["Kategori_adi"].ToString();
                    baglan.Close();

                    baglan.Open();
                    FbCommand UrunSayi = new FbCommand("SELECT SUM(rapor_sayac) FROM Rapor WHERE rapor_tarih='" + tarih + "' GROUP BY rapor_satisKt", baglan);
                    object SatisAdet = UrunSayi.ExecuteScalar();
                    baglan.Close();



                    // Buraya kadar tamamlanmıştır.. amk

                    // Buraya kadar tamamlanmıştır..

                    int[] SeriesPoint = new int[0];

                    FbCommand UrunKategori = new FbCommand("SELECT rapor_satisKt FROM Rapor WHERE rapor_tarih='" + tarih + "' GROUP BY rapor_satisKt", baglan);
                    FbCommand UrunKategoriSatisSys = new FbCommand("SELECT SUM(rapor_sayac) FROM Rapor WHERE rapor_tarih='" + tarih + "' GROUP BY rapor_satisKt", baglan3);

                    // Grafik için sayısal değerler
                    baglan3.Open();
                    int sa = 0;
                    FbDataReader OkuUKSS = UrunKategoriSatisSys.ExecuteReader();
                    while (OkuUKSS.Read())
                    {
                        Array.Resize(ref SeriesPoint, SeriesPoint.Length + 1);
                        SeriesPoint[sa] = int.Parse(OkuUKSS[0].ToString());
                        sa++;
                    }
                    // kategori satış sayıları diziye atıldı
                    baglan3.Close();

                    baglan.Open();

                    FbDataReader ktOku = UrunKategori.ExecuteReader();
                    istatislik.Titles.Add("Günlük Satış Raporu Grafik");
                    for (int k = 0; k < SeriesPoint.Length; k++)
                    {
                        ktOku.Read();
                        baglan2.Open();
                        FbCommand Kategori = new FbCommand("SELECT Kategori_adi FROM Urun_kategori WHERE Kategori_id='" + ktOku["rapor_satisKt"].ToString() + "'", baglan2);
                        FbDataReader Ktad = Kategori.ExecuteReader();
                        Ktad.Read();
                        Series series = istatislik.Series.Add(Ktad["Kategori_adi"].ToString());
                        series.Points.Add(SeriesPoint[k]);
                        baglan2.Close();
                    }

                    baglan.Close();

                    // Manuelsatışlar
                    baglan.Open();
                    FbCommand ManuelSatislar = new FbCommand("SELECT * FROM ManuelSatis WHERE satis_tarih='" + tarih + "'", baglan);
                    object sn = ManuelSatislar.ExecuteScalar();
                    int msay = 0;
                    if (sn != null)
                    {
                        FbDataReader moku = ManuelSatislar.ExecuteReader();
                        while (moku.Read())
                        {
                            top += float.Parse(moku["satis_fiyat"].ToString());
                            top2 += float.Parse(moku["satis_alisFiyat"].ToString());
                            msay++;
                        }
                        label5.Text = top.ToString();
                        label9.Text = (top - top2).ToString();
                        Series series = istatislik.Series.Add("Manuel Satış");
                        series.Points.Add(msay);
                    }
                    baglan.Close();
                    // Manuelsatışlar
                }
                else
                {
                    MessageBox.Show("Bugün satış yapılmamıştır. (R-01)", "Bilgilendirme");
                    this.Close();
                }
            }
        }
    }
