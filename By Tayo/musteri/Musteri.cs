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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

        MusteriGuncelle musg = new MusteriGuncelle();
        MusteriSil muss = new MusteriSil();
        Fonksiyonlar fk = new Fonksiyonlar();

        public string Musteriid = "";
        private void Musteri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = fk.SutunOlustur();
            GridListe();
        }

        private void Musteri_adsoyad_TextChanged(object sender, EventArgs e)
        {
            if (Musteri_adsoyad != null)
            {
                Tarih1.Enabled = false; Tarih2.Enabled = false;
                if (Musteri_adsoyad.Text.Length > 0)
                {
                    Tarih1.Enabled = false; Tarih2.Enabled = false;
                }
                else
                {
                    Tarih1.Enabled = true; Tarih2.Enabled = true;
                }
            }
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            Musteri_adsoyad.Text = Musteri_adsoyad.Text.Replace("'", "’");
            if (checkBox1.Checked == true)
            {
                // tarihe göre ara
                ButonListe("", Tarih1.Value.ToString("yyyy-MM-dd"), Tarih2.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                // ada göre ara
                ButonListe(Musteri_adsoyad.Text, "", "");
            }
        }

        private void Tarih1_ValueChanged(object sender, EventArgs e)
        {
            if (Tarih1.Text != null)
            {
                if (Tarih1.Text.Length > 0)
                {
                    Musteri_adsoyad.Enabled = false; Musteri_adsoyad.Enabled = false;
                }
                else
                {
                    Musteri_adsoyad.Enabled = true; Musteri_adsoyad.Enabled = true;
                }
            }
        }

        private void Tarih2_ValueChanged(object sender, EventArgs e)
        {
            if (Tarih2.Text != null)
            {
                if (Tarih2.Text.Length > 0)
                {
                    Musteri_adsoyad.Enabled = false; Musteri_adsoyad.Enabled = false;
                }
                else
                {
                    Musteri_adsoyad.Enabled = true; Musteri_adsoyad.Enabled = true;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Tarih1.Enabled = true; Tarih2.Enabled = true; Musteri_adsoyad.Enabled = false;
            }
            else
            {
                Tarih1.Enabled = false; Tarih2.Enabled = false; Musteri_adsoyad.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // seçilen satırdan id'yi al
            DataId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void MusteriGuncelle_Click(object sender, EventArgs e)
        {
            // seçilen satırdan id'yi al
            DataId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //this.Hide();
            musg.id = DataId.Text;
            musg.ShowDialog();
        }

        private void MusteriSil_Click(object sender, EventArgs e)
        {
            // seçilen satırdan id'yi al
            DataId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            musg.id = DataId.Text;
            muss.id = DataId.Text;
            muss.ShowDialog();
        }

        private void DataId_TextChanged(object sender, EventArgs e)
        {
            Musteriid = DataId.Text;
        }

        private void Detay_Click(object sender, EventArgs e)
        {
            KaraListe.SelectedIndex = 0;
            string birinci = KaraListe.SelectedItem.ToString();
            if (birinci != "Borçlu müşteri bulunmamaktadır.")
            {
                MusteriGuncelle mg = new MusteriGuncelle();
                // Müşteri bilgileri //
                string adsoyad = KaraListe.SelectedItem.ToString();
                string[] ads = adsoyad.Split(' ');
                FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                FbDataReader MusteriBilgi;
                FbCommand MusteriSorgu = new FbCommand("SELECT * FROM Musteriler WHERE Musteri_adi='" + ads[0] + "' and Musteri_soyadi='" + ads[1] + "'", baglanti);
                baglanti.Open();
                MusteriBilgi = MusteriSorgu.ExecuteReader(); MusteriBilgi.Read();
                mg.id = MusteriBilgi["Musteri_id"].ToString();
                baglanti.Close();
                mg.ShowDialog();
                // Müşteri bilgileri //
            }
            else
            {
                MessageBox.Show("Borçlu müşteri bulunmamaktadır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GridListe()
        {
            Tarih1.Enabled = false; Tarih2.Enabled = false; checkBox1.Checked = false;
            // bağlantı kodumuz //
            FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
            baglanti.Open();
            // bağlantı kodumuz //

            // karaliste //
            FbDataReader KaraListeOku; object KaraListeSonuc;
            FbCommand KaraListeSor = new FbCommand("SELECT Musteri_adi,Musteri_soyadi FROM Musteriler where Musteri_bakiye < 0", baglanti);
            KaraListeSor.Connection = baglanti;
            KaraListeSonuc = KaraListeSor.ExecuteScalar();
            if (KaraListeSonuc != null)
            {
                KaraListeOku = KaraListeSor.ExecuteReader();
                while (KaraListeOku.Read())
                {
                    KaraListe.Items.Add(KaraListeOku["Musteri_adi"] + " " + KaraListeOku["Musteri_soyadi"]);
                }
            }
            else
            {
                KaraListe.Items.Add("Borçlu müşteri bulunmamaktadır.");
            }
            // karaliste //
            baglanti.Close();

            // tarihe göre arama //

            // tarihe göre arama //

            // GridView Stünları oluştur //
            FbDataReader oku; object sonuc; DataRow satir;
            // GridView Stünları oluştur //

            // Müşteri sql kodu //
            FbCommand komut_musteri = new FbCommand("SELECT * FROM Musteriler", baglanti);
            baglanti.Open();

            sonuc = komut_musteri.ExecuteScalar();

            if (sonuc != null)
            {
                oku = komut_musteri.ExecuteReader();
                while (oku.Read())
                {
                    satir = fk.dt.NewRow();
                    satir["Müşteri Id"] = oku["Musteri_id"].ToString();
                    satir["Adı Soyadı"] = oku["Musteri_adi"].ToString() + " " + oku["Musteri_soyadi"].ToString();
                    satir["Telefon"] = oku["Musteri_telefon"].ToString();
                    satir["Bakiye"] = float.Parse(oku["Musteri_bakiye"].ToString()) + " TL";
                    satir["Kayıt Tarihi"] = Convert.ToDateTime(oku["Musteri_kayitTarihi"].ToString());

                    //Veri tablomuza kontrolüne ekle
                    fk.dt.Rows.Add(satir);
                }
            }
            else
            {
                MessageBox.Show("Sistemde müşteri bulunamadı, müşteri ekleyiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                MusteriEkle me = new MusteriEkle();
                me.ShowDialog();
            }

            // bağlantı kapatıldı
            baglanti.Close();
        }

        public void ButonListe(string ad,string t1,string t2)
        {
            Musteri_adsoyad.Text = fk.IlkHarfleriBuyut(ad);
            if (checkBox1.Checked == true)
            {
                string suankitarih = DateTime.Now.ToString("yyyy-MM-dd");
                if ((Tarih1.Value > Tarih2.Value))
                {
                    MessageBox.Show("Tarihler aralığında hata ( Hata kodu: M-01 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string tarih1, tarih2;
                    //tarih1 = Tarih1.Value.ToString("yyyy-MM-dd");
                    //tarih2 = Tarih2.Value.ToString("yyyy-MM-dd");
                    tarih1 = t1;
                    tarih2 = t2;
                    DateTime tarih = DateTime.Parse(tarih1);
                    // GridView Stünları oluştur //
                    FbDataReader oku; object sonuc; DataRow satir;
                    // GridView Stünları oluştur //

                    // Müşteri sql kodu //
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                    FbCommand komut_musteri = new FbCommand("SELECT * FROM Musteriler WHERE Musteri_kayitTarihi BETWEEN '" + tarih1 + "' and '" + tarih2 + "'", baglanti);
                    baglanti.Open();
                    sonuc = komut_musteri.ExecuteScalar();

                    if (sonuc != null)
                    {
                        fk.dt.Clear();
                        dataGridView1.Refresh();
                        oku = komut_musteri.ExecuteReader();
                        while (oku.Read())
                        {
                            satir = fk.dt.NewRow();
                            satir["Müşteri Id"] = oku["Musteri_id"].ToString();
                            satir["Adı Soyadı"] = oku["Musteri_adi"].ToString() + " " + oku["Musteri_soyadi"].ToString();
                            satir["Telefon"] = oku["Musteri_telefon"].ToString();
                            satir["Bakiye"] = float.Parse(oku["Musteri_bakiye"].ToString()) + " TL";
                            satir["Kayıt Tarihi"] = oku["Musteri_kayitTarihi"].ToString();

                            //Veri tablomuza kontrolüne ekle
                            fk.dt.Rows.Add(satir);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tarihlere göre aramada müşteri bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //GridListe();
                    }

                    // bağlantı kapatıldı
                    baglanti.Close();
                }
            }
            else
            {
                if (Musteri_adsoyad.Text != "")
                {
                    string adsoyad2 = fk.IlkHarfleriBuyut(Musteri_adsoyad.Text);
                    // ad soyada göre arattır
                    FbDataReader oku; object adsoyad; DataRow satir;
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                    FbCommand komut_adsoyad = new FbCommand("SELECT * FROM Musteriler where Musteri_adi like '%" + Musteri_adsoyad.Text + "%' or Musteri_soyadi like '%" + Musteri_adsoyad.Text + "%' or Musteri_adi like '%" + adsoyad2 + "%' or Musteri_soyadi like '%" + adsoyad2 + "%'", baglanti);
                    baglanti.Open();
                    adsoyad = komut_adsoyad.ExecuteScalar();
                    if (adsoyad != null)
                    {
                        fk.dt.Clear();
                        dataGridView1.Refresh();
                        oku = komut_adsoyad.ExecuteReader();
                        while (oku.Read())
                        {
                            satir = fk.dt.NewRow();
                            satir["Müşteri Id"] = oku["Musteri_id"].ToString();
                            satir["Adı Soyadı"] = oku["Musteri_adi"].ToString() + " " + oku["Musteri_soyadi"].ToString();
                            satir["Telefon"] = oku["Musteri_telefon"].ToString();
                            satir["Bakiye"] = float.Parse(oku["Musteri_bakiye"].ToString()) + " TL";
                            satir["Kayıt Tarihi"] = oku["Musteri_kayitTarihi"].ToString();

                            //Veri tablomuza kontrolüne ekle
                            fk.dt.Rows.Add(satir);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Müşteri bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen bir isim / soyisim bilgisini doldurun. ( Hata kodu: M-02 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void GridYenile()
        {
            fk.dt.Clear();
            dataGridView1.Refresh();
        }

        public void BorcListe()
        {
            // bağlantı kodumuz //
            FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
            baglanti.Open();
            // bağlantı kodumuz //

            // karaliste //
            FbDataReader KaraListeOku; object KaraListeSonuc;
            FbCommand KaraListeSor = new FbCommand("SELECT Musteri_adi,Musteri_soyadi FROM Musteriler where Musteri_bakiye < 0", baglanti);
            KaraListeSor.Connection = baglanti;
            KaraListeSonuc = KaraListeSor.ExecuteScalar();
            if (KaraListeSonuc != null)
            {
                KaraListeOku = KaraListeSor.ExecuteReader();
                while (KaraListeOku.Read())
                {
                    KaraListe.Items.Add(KaraListeOku["Musteri_adi"] + " " + KaraListeOku["Musteri_soyadi"]);
                }
            }
            else
            {
                KaraListe.Items.Add("Borçlu müşteri bulunmamaktadır.");
            }
            // karaliste //
            baglanti.Close();
        }
    }
}