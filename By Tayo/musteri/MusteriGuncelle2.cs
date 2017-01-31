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
    public partial class MusteriGuncelle2 : Form
    {
        public MusteriGuncelle2()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        string id, Mad="", Msoyad="";
        private void MusteriGuncelle2_Load(object sender, EventArgs e)
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
            Musteri_kategori.Items.Clear();
            object Kssor = KategoriSorgu.ExecuteScalar();
            if (Kssor != null)
            {
                KategoriGetir = KategoriSorgu.ExecuteReader();
                while (KategoriGetir.Read())
                {
                    Musteri_kategori.Items.Add(KategoriGetir["Kategori_adi"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Müşteri kategorisi ekleyiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MusteriKategoriEkle mke = new MusteriKategoriEkle();
                this.Close();
                mke.ShowDialog();
            }
            baglanti.Close();

            // Kategorileri çek //
        }

        private void AramaMusteriAdi_TextChanged(object sender, EventArgs e)
        {
            if (AramaMusteriAdi.Text.Length > 0 )
            {
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
                    Musteri_adi_combo.SelectedIndex = 0;
                    Musteri_adi_combo.Enabled = true;
                    MusteriBilgiGrup.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Aranan isme / soyisme göre müşteri bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                baglanti.Close();
            }
            else
            {
                Musteri_adi_combo.SelectedIndex = -1;
                Musteri_adi_combo.Enabled = false;
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
                object sn = MusteriSorgu.ExecuteScalar();
                if (sn != null)
                {
                    MusteriBilgi = MusteriSorgu.ExecuteReader(); MusteriBilgi.Read();
                    id = MusteriBilgi["Musteri_id"].ToString();
                    Musteri_adi.Text = MusteriBilgi["Musteri_adi"].ToString(); Musteri_soyadi.Text = MusteriBilgi["Musteri_soyadi"].ToString();
                    this.Text = MusteriBilgi["Musteri_adi"].ToString() + " " + MusteriBilgi["Musteri_soyadi"].ToString() + " - Müşteri Güncelleme";
                    Musteri_telefonu.Text = MusteriBilgi["Musteri_telefon"].ToString(); Musteri_adresi.Text = MusteriBilgi["Musteri_adres"].ToString();
                    string MusteriKatString = MusteriBilgi["Musteri_kategori"].ToString();
                    Musteri_bakiye.Text = float.Parse(MusteriBilgi["Musteri_bakiye"].ToString()).ToString();
                    if (float.Parse(MusteriBilgi["Musteri_bakiye"].ToString()) < -1) label3.Visible = true;

                    // Genel Ad ve Soyad
                    Mad = MusteriBilgi["Musteri_adi"].ToString();
                    Msoyad = MusteriBilgi["Musteri_soyadi"].ToString();
                    // Genel Ad ve Soyad

                    baglanti.Close();
                    // Müşteri bilgileri //



                    // Müşter hangi kategoride //
                    baglanti.Open();
                    FbCommand KategoriAdiSorgu = new FbCommand("SELECT * FROM Musteri_kategori WHERE Kategori_id='" + MusteriKatString + "'", baglanti);
                    FbDataReader KatAdiOku; KatAdiOku = KategoriAdiSorgu.ExecuteReader(); KatAdiOku.Read();
                    Musteri_kategori.Text = KatAdiOku["Kategori_adi"].ToString();
                    baglanti.Close();
                    // Müşter hangi kategoride //
                }
                else
                {
                    MessageBox.Show("Sistemsel bir hata oluştu, lütfen sağlayıcınıza başvurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
            }
            else
            {
                MusteriBilgiGrup.Enabled = false;
                Musteri_adi.Text = ""; Musteri_soyadi.Text = ""; Musteri_adresi.Text = ""; Musteri_telefonu.Text = ""; Musteri_kategori.SelectedIndex = -1; Musteri_bakiye.Text = "0";
            }
        }

        private void ButonAramayaGoreGuncelle_Click(object sender, EventArgs e)
        {
            Musteri_adi.Text = Musteri_adi.Text.Replace("'", "’");
            Musteri_soyadi.Text = Musteri_soyadi.Text.Replace("'", "’");
            Musteri_adresi.Text = Musteri_adresi.Text.Replace("'", "’");
            Musteri_adi.Text = fk.IlkHarfleriBuyut(Musteri_adi.Text);
            Musteri_soyadi.Text = fk.IlkHarfleriBuyut(Musteri_soyadi.Text);
            string ad, soyad, telefon, adres, kategori; string katId = "";
            ad = Musteri_adi.Text; soyad = Musteri_soyadi.Text; telefon = Musteri_telefonu.Text; kategori = Musteri_kategori.Text; adres = Musteri_adresi.Text;
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

                if (Musteri_adi.Text == Mad && Musteri_soyadi.Text == Msoyad)
                {
                    // Müşteriyi güncelle //
                    byte sonuc;
                    sonuc = fk.Guncelle("Musteriler", "Musteri_adi='" + ad + "', Musteri_soyadi='" + soyad + "', Musteri_telefon='" + telefon + "', Musteri_adres='" + fk.IlkHarfleriBuyut(adres) + "', Musteri_kategori='" + katId + "', Musteri_bakiye='" + Musteri_bakiye.Text + "'", "Musteri_id='" + id + "'");
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Müşteri başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Müşteri güncellenemedi ( Hata kodu: M-07 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Müşteriyi güncelle //
                }
                else
                {
                    // kontrol
                    baglanti.Open();
                    FbCommand MusteriKontrol = new FbCommand("SELECT * FROM MUSTERILER WHERE Musteri_adi='" + Musteri_adi.Text + "' and Musteri_soyadi='" + Musteri_soyadi.Text + "'", baglanti);
                    object kontrol = MusteriKontrol.ExecuteScalar();
                    if (kontrol == null)
                    {

                        // Müşteriyi güncelle //
                        byte sonuc;
                        sonuc = fk.Guncelle("Musteriler", "Musteri_adi='" + ad + "', Musteri_soyadi='" + soyad + "', Musteri_telefon='" + telefon + "', Musteri_adres='" + adres + "', Musteri_kategori='" + katId + "', Musteri_bakiye='" + Musteri_bakiye.Text + "'", "Musteri_id='" + id + "'");
                        if (sonuc == 1)
                        {
                            MessageBox.Show("Müşteri başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Müşteri güncellenemedi ( Hata kodu: M-07 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Müşteriyi güncelle //
                    }
                    else
                    {
                        MessageBox.Show("Güncellemek istediğiniz müşteri sistemde kayıtlıdır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    baglanti.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayın ve bilgileri doğru şekilde doldurun", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Musteri_telefonu_KeyPress(object sender, KeyPressEventArgs e)
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
