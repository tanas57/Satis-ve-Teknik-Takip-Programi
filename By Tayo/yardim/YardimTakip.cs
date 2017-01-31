using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace By_Tayo
{
    public partial class YardimTakip : Form
    {
        public YardimTakip()
        {
            InitializeComponent();
        }

        private void kodlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kodlar.SelectedItem.ToString() == "T-01")
                kodAciklama.Text = "Takip Ekleme; Yeni takip eklerken Sql Server hatası.";
            else if (kodlar.SelectedItem.ToString() == "T-02")
                kodAciklama.Text = "Cihaz bilgilerini doğru şekilde doldurunuz. İmei veya Serino ikisinden birisi zorunlu doldurulmalıdır.";
            else if (kodlar.SelectedItem.ToString() == "T-03")
                kodAciklama.Text = "Müşteri bilgileri eksiksiz girilmelidir.";
            else if (kodlar.SelectedItem.ToString() == "T-04")
                kodAciklama.Text = "Takip Arama; Takip numarasına göre aramada takip bulunamadı.";
            else if (kodlar.SelectedItem.ToString() == "T-05")
                kodAciklama.Text = "Takip güncelleme; Takip güncellerken Sql Server hatası.";
            else if (kodlar.SelectedItem.ToString() == "T-07")
                kodAciklama.Text = "Takip kapat; Takip kapatırken Sql Server hatası.";
            else if (kodlar.SelectedItem.ToString() == "T-06")
                kodAciklama.Text = "Takip güncelleme; Takip güncellemede Sql Server hatası.";
            else if (kodlar.SelectedItem.ToString() == "T-08")
                kodAciklama.Text = "Takip güncelleme; Takip güncellemede, yapılan işlemler kutusu boş bırakılırsa bu hata ile karşılaşırsınız.";
            else if (kodlar.SelectedItem.ToString() == "T-09")
                kodAciklama.Text = "Takip güncelleme; Cihaz bilgilerinden marka, model, imei veya serino boş bırakıldı.";
            else if (kodlar.SelectedItem.ToString() == "T-10")
                kodAciklama.Text = "Takip güncelleme; Cihaz bilgileri güncellenirken Sql Server hatası.";
            else if (kodlar.SelectedItem.ToString() == "T-11")
                kodAciklama.Text = "Takip güncelleme; Müşteri bilgileri güncellenirken Sql Server hatası.";
            else if (kodlar.SelectedItem.ToString() == "T-12")
                kodAciklama.Text = "Takip güncelleme; Müşteri bilgilerinde boş alan bırakıldı.";
            else if (kodlar.SelectedItem.ToString() == "T-13")
                kodAciklama.Text = "Takip Sil; Takip silinirken Sql Server hatası.";
            else if (kodlar.SelectedItem.ToString() == "T-14")
                kodAciklama.Text = "Takip Ara; Takip numarasını giriniz.";
        }

        private void YardimTakip_Load(object sender, EventArgs e)
        {
            kodlar.SelectedIndex = 0;
        }
    }
}
