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
    public partial class MusteriGuncelle : Form
    {
        public MusteriGuncelle()
        {
            InitializeComponent();
            
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        public string id;
        string Mad = "", Msoyad = "";
        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(katekle, "Müşteri Kategorisi Ekle");
            // Bağlantı //
            FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
            // Bağlantı //

            // Kategorileri çek //
            FbDataReader KategoriGetir;
            FbCommand KategoriSorgu = new FbCommand("SELECT * FROM Musteri_kategori", baglanti);
            baglanti.Open();
            KategoriGetir = KategoriSorgu.ExecuteReader();
            Musteri_kategori.Items.Clear();
            while (KategoriGetir.Read())
            {
                Musteri_kategori.Items.Add(KategoriGetir["Kategori_adi"].ToString());
            }
            baglanti.Close();

            // Kategorileri çek //

            // Müşteri bilgilerini çek //
            if (id != null)
            {
                string MusteriKatString="";
                FbDataReader MusteriBilgiGetir;
                FbCommand MusteriSorgu = new FbCommand("SELECT * FROM Musteriler WHERE Musteri_id='" + id + "'", baglanti);
                baglanti.Open();
                MusteriBilgiGetir = MusteriSorgu.ExecuteReader();
                MusteriBilgiGetir.Read();
                    this.Text           =   MusteriBilgiGetir["Musteri_adi"] + " " + MusteriBilgiGetir["Musteri_soyadi"] + " - Müşteri Güncelleme";
                    MusAdi.Text         =   MusteriBilgiGetir["Musteri_adi"].ToString();
                    MusSoyadi.Text      =   MusteriBilgiGetir["Musteri_soyadi"].ToString();
                    Mad                  =   MusteriBilgiGetir["Musteri_adi"].ToString();
                    Msoyad               =   MusteriBilgiGetir["Musteri_soyadi"].ToString();
                    MusTelefonu.Text    =   MusteriBilgiGetir["Musteri_telefon"].ToString();
                    MusAdresi.Text      =   MusteriBilgiGetir["Musteri_adres"].ToString();
                    MusteriKatString    =   MusteriBilgiGetir["Musteri_kategori"].ToString();
                    Musteri_bakiye.Text = float.Parse(MusteriBilgiGetir["Musteri_bakiye"].ToString()).ToString();
                    if (double.Parse(MusteriBilgiGetir["Musteri_bakiye"].ToString()) < -1) label7.Visible = true;
                    baglanti.Close();
            // Müşteri bilgilerini çek //

                // Müşter hangi kategoride //
                baglanti.Open();
                FbCommand KategoriAdiSorgu = new FbCommand("SELECT * FROM Musteri_kategori WHERE Kategori_id='" + MusteriKatString + "'", baglanti);
                FbDataReader KatAdiOku; KatAdiOku = KategoriAdiSorgu.ExecuteReader(); KatAdiOku.Read();
                Musteri_kategori.Text = KatAdiOku["Kategori_adi"].ToString();
                baglanti.Close();
                // Müşter hangi kategoride //
            }
            // Müşteri bilgilerini çek //
        }

        private void MusteriGuncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Musteri mus = new Musteri();
           // mus.Show();
        }

        private void ButonidyeGoreGuncelleme_Click(object sender, EventArgs e)
        {
            MusAdi.Text = MusAdi.Text.Replace("'", "’");
            MusSoyadi.Text = MusSoyadi.Text.Replace("'", "’");
            MusAdresi.Text = MusAdresi.Text.Replace("'", "’");
            Musteri FormM = (Musteri)Application.OpenForms["Musteri"];
            MusAdi.Text = fk.IlkHarfleriBuyut(MusAdi.Text);
            MusSoyadi.Text = fk.IlkHarfleriBuyut(MusSoyadi.Text);
            string ad, soyad, telefon, adres, kategori; string katId="";
            ad = MusAdi.Text; soyad = MusSoyadi.Text; telefon = MusTelefonu.Text; kategori = Musteri_kategori.Text; adres = MusAdresi.Text;
            kategori = Musteri_kategori.Text;
            if ((ad != "" && ad.Length >= 3) && (soyad != "" && soyad.Length >= 3) && (telefon != "" && telefon.Length >= 10) && (adres != ""))
            {
                // Kategori id yi çıkar //
                FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu()); FbDataReader KategoriIdCek;
                baglanti.Open();
                FbCommand KategoriAdiSorgu = new FbCommand("SELECT * FROM Musteri_kategori WHERE Kategori_adi='" + kategori + "'", baglanti);
                KategoriIdCek = KategoriAdiSorgu.ExecuteReader();
                KategoriIdCek.Read(); katId = KategoriIdCek["Kategori_id"].ToString();
                baglanti.Close();
                // Kategori id yi çıkar //
                if (Musteri_bakiye.Text == "") Musteri_bakiye.Text = "0";
                else Musteri_bakiye.Text = Musteri_bakiye.Text.Replace(',', '.');

                if (MusAdi.Text == Mad && MusSoyadi.Text == Msoyad)
                {
                    // Müşteriyi güncelle //
                    byte sonuc;
                    sonuc = fk.Guncelle("Musteriler", "Musteri_adi='" + ad + "', Musteri_soyadi='" + soyad + "', Musteri_telefon='" + telefon + "', Musteri_adres='" + fk.IlkHarfleriBuyut(adres) + "', Musteri_kategori='" + katId + "', Musteri_bakiye='" + Musteri_bakiye.Text + "'", "Musteri_id='" + id + "'");
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Müşteri başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormM.GridYenile();
                        FormM.KaraListe.Items.Clear();
                        if (FormM.checkBox1.Checked == true)
                        {
                            // tarihe göre ara
                            FormM.ButonListe("", FormM.Tarih1.Value.ToString("yyyy-MM-dd"), FormM.Tarih2.Value.ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            // ada göre ara
                            if (FormM.Musteri_adsoyad.Text != "")
                            {
                                FormM.ButonListe(FormM.Musteri_adsoyad.Text, "", "");
                                FormM.BorcListe();
                            }
                            else FormM.GridListe();
                        }
                    }
                    else
                        MessageBox.Show("Müşteri güncellenemedi ( Hata kodu: M-05 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Müşteriyi güncelle //
                }
                else
                {
                    // kontrol
                    baglanti.Open();
                    FbCommand MusteriKontrol = new FbCommand("SELECT * FROM MUSTERILER WHERE Musteri_adi='" + MusAdi.Text + "' and Musteri_soyadi='" + MusSoyadi.Text + "'", baglanti);
                    object kontrol = MusteriKontrol.ExecuteScalar();
                    if (kontrol == null)
                    {
                        // Müşteriyi güncelle //
                        byte sonuc;
                        sonuc = fk.Guncelle("Musteriler", "Musteri_adi='" + ad + "', Musteri_soyadi='" + soyad + "', Musteri_telefon='" + telefon + "', Musteri_adres='" + adres + "', Musteri_kategori='" + katId + "', Musteri_bakiye='" + Musteri_bakiye.Text + "'", "Musteri_id='" + id + "'");
                        if (sonuc == 1)
                        {
                            MessageBox.Show("Müşteri başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormM.GridYenile();
                            FormM.KaraListe.Items.Clear();
                            if (FormM.checkBox1.Checked == true)
                            {
                                // tarihe göre ara
                                FormM.ButonListe("", FormM.Tarih1.Value.ToString("yyyy-MM-dd"), FormM.Tarih2.Value.ToString("yyyy-MM-dd"));
                            }
                            else
                            {
                                // ada göre ara
                                if (FormM.Musteri_adsoyad.Text != "")
                                {
                                    FormM.ButonListe(FormM.Musteri_adsoyad.Text, "", "");
                                    FormM.BorcListe();
                                }
                                else FormM.GridListe();
                            }
                        }
                        else
                            MessageBox.Show("Müşteri güncellenemedi ( Hata kodu: M-05 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Müşteriyi güncelle //
                    }
                    else
                    {
                        MessageBox.Show("Güncellemek istediğiniz müşteri sistemde kayıtlıdır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    baglanti.Close();
                    // kontrol
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayın ve bilgileri doğru şekilde doldurun","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void idyeGoreGrup_Enter(object sender, EventArgs e)
        {

        }

        private void MusTelefonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void katekle_Click(object sender, EventArgs e)
        {
            MusteriKategoriEkle mke = new MusteriKategoriEkle();
            mke.Show();
        }

        private void Musteri_bakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44 && e.KeyChar != (char)46 && e.KeyChar != (char)45)
            {
                e.Handled = true;

            }
        }

    }
}
