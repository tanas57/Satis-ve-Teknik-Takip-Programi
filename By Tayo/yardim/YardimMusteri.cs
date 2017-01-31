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
    public partial class YardimMusteri : Form
    {
        public YardimMusteri()
        {
            InitializeComponent();
        }

        private void kodlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kodlar.SelectedItem.ToString() == "M-01")
                kodAciklama.Text = "Müşteri arama; Tarih aralığında hata, birinci tarih ikinci tarihten büyük olamaz.";
            else if (kodlar.SelectedItem.ToString() == "M-02")
                kodAciklama.Text = "Müşteri arama; Müşteri ismi veya soyismi girilmez ise bu hata ile karşılaşırsınız.";
            else if (kodlar.SelectedItem.ToString() == "M-03")
                kodAciklama.Text = "Müşteri ekleme; Müşteri ekleme işlemi yaparken Sql Server hatası.";
            else if (kodlar.SelectedItem.ToString() == "M-04")
                kodAciklama.Text = "Müşteri ekleme; Müşteri ekleme işlemi yaparken boş alan bırakılırsa bu hata ile karşılaşırsınız.";
            else if (kodlar.SelectedItem.ToString() == "M-05")
                kodAciklama.Text = "Müşteri güncelleme; Müşteri güncelleme işlemi yaparken Sql Server hatası.";
            else if (kodlar.SelectedItem.ToString() == "M-06")
                kodAciklama.Text = "Müşteri Arama; Müşteri ismi veya soyismi giriniz.";
            else if (kodlar.SelectedItem.ToString() == "M-07")
                kodAciklama.Text = "Müşteri Güncelleme; Müşteri güncelleme işleminde Sql Server hatası.";
            else if (kodlar.SelectedItem.ToString() == "M-08")
                kodAciklama.Text = "Müşteri Silme; Müşteri silme işleminde Sql Server hatası.";
            else if (kodlar.SelectedItem.ToString() == "M-09")
                kodAciklama.Text = "Müşteri Kategori Ekle; Müşteri kategori ekleme işleminde Sql Server hatası.";
            else if (kodlar.SelectedItem.ToString() == "M-10")
                kodAciklama.Text = "Müşteri Kategori Silme; Müşteri kategori silme işleminde Sql Server hatası.";
            else if (kodlar.SelectedItem.ToString() == "M-11")
                kodAciklama.Text = "Müşteri Kategori Güncelleme; Müşteri kategori güncelleme işleminde Sql Server hatası.";
        }

        private void YardimMusteri_Load(object sender, EventArgs e)
        {
            kodlar.SelectedIndex = 0;
        }
    }
}
