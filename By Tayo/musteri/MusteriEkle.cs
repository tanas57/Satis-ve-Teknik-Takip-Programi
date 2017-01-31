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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            try
            {
                ToolTip Aciklama = new ToolTip();
                Aciklama.SetToolTip(katekle, "Müşteri Kategorisi Ekle");
                FbConnection komut_baglan = new FbConnection(fk.Baglanti_Kodu());
                FbDataReader oku;
                FbCommand cmd = new FbCommand();

                object sonuc;

                komut_baglan.Open();
                cmd.Connection = komut_baglan;
                cmd.CommandText = "SELECT * FROM Musteri_kategori";
                sonuc = cmd.ExecuteScalar();
                if (sonuc != null)
                {
                    oku = cmd.ExecuteReader();

                    while (oku.Read())
                    {
                        Musteri_kategori.Items.Add(oku[1].ToString());
                    }

                    Musteri_kategori.SelectedIndex = 0;
                    oku.Close();
                    Musteri_kategori.Enabled = true;
                    ButonEkle.Enabled = true;
                }
                else
                {
                    Musteri_kategori.Enabled = false;
                    ButonEkle.Enabled = false;
                    MessageBox.Show("Müşteri kategorisi bulunamadı, müşteri kategorisi ekleyiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    MusteriKategoriEkle mke = new MusteriKategoriEkle();
                    mke.ShowDialog();
                }
                komut_baglan.Close();
            }
            catch (Exception me1)
            {
                MessageBox.Show(me1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButonEkle_Click(object sender, EventArgs e)
        {
            MusAdi.Text = MusAdi.Text.Replace("'", "’");
            MusSoyadi.Text = MusSoyadi.Text.Replace("'", "’");
            MusAdresi.Text = MusAdresi.Text.Replace("'", "’");
            byte kayit;
            MusAdi.Text = fk.IlkHarfleriBuyut(MusAdi.Text);
            MusSoyadi.Text = fk.IlkHarfleriBuyut(MusSoyadi.Text);
            if (MusAdi.Text != "" && MusSoyadi.Text != "" && MusAdresi.Text != "" && MusTelefonu.Text != "")
            {
                string adi, soyadi, adresi, kategori, tarih;
                int kategori_id = 0;
                string telefonu;
                adi = MusAdi.Text;
                soyadi = MusSoyadi.Text;
                adresi = MusAdresi.Text;
                telefonu = MusTelefonu.Text;
                kategori = Musteri_kategori.SelectedItem.ToString();
                tarih = DateTime.Now.Year.ToString(); tarih += '-' + DateTime.Now.Month.ToString(); tarih += '-' + DateTime.Now.Day.ToString();
                // kategori id çekme
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                FbDataReader oku;
                object sonuc;
                FbCommand kategori_cek = new FbCommand("SELECT Kategori_id FROM Musteri_kategori where Kategori_adi='" + kategori + "'");
                kategori_cek.Connection = baglan;
                baglan.Open();
                sonuc = kategori_cek.ExecuteScalar();
                if (sonuc != null)
                {
                    oku = kategori_cek.ExecuteReader();
                    while (oku.Read())
                    {
                        kategori_id = int.Parse(oku[0].ToString());
                    }
                }
                baglan.Close();
                // kategor id çekme

                baglan.Open();
                FbCommand MusteriKontrol = new FbCommand("SELECT * FROM MUSTERILER WHERE Musteri_adi='"+adi+"' and Musteri_soyadi='"+soyadi+"'", baglan);
                object kontrol = MusteriKontrol.ExecuteScalar();
                if (kontrol == null)
                {
                    kayit = fk.Ekle("Musteriler", "Musteri_adi,Musteri_soyadi,Musteri_adres,Musteri_telefon,Musteri_kayitTarihi,Musteri_kategori,Musteri_bakiye", "'" + adi + "','" + soyadi + "','" + fk.IlkHarfleriBuyut(adresi) + "','" + telefonu + "','" + tarih + "','" + kategori_id.ToString() + "','0'");
                    if (kayit == 1)
                    {
                        MessageBox.Show("Müşteri başarıyla eklenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MusAdi.Text = ""; MusAdresi.Text = ""; MusSoyadi.Text = ""; MusTelefonu.Text = "";
                    }
                    else
                        MessageBox.Show("Müşteri eklenemedi ( Hata kodu: M-03 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Eklemek istediğiniz müşteri sistemde kayıtlıdır.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                baglan.Close();
            }
            else
            {
                MessageBox.Show("Boş alanları doldurun! ( Hata kodu: M-04 )", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
