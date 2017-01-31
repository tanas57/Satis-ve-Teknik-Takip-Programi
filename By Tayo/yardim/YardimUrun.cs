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
    public partial class YardimUrun : Form
    {
        public YardimUrun()
        {
            InitializeComponent();
        }

        private void YardimUrun_Load(object sender, EventArgs e)
        {
            kodlar.SelectedIndex = 0;
        }

        private void kodlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kodlar.SelectedItem.ToString() == "U-01")
                kodAciklama.Text = "Ürün eklerken hata; Ürün adı girilmez ise bu hata ile karşılaşırsınız.";
            else if (kodlar.SelectedItem.ToString() == "U-02")
                kodAciklama.Text = "Ürün eklerken hata; Ürün barkod numarası doldurulmaz ise bu hata ile karşılaşırsınız.";
            else if (kodlar.SelectedItem.ToString() == "U-03")
                kodAciklama.Text = "Ürün güncellemede hata; Güncelleme işleminde Sql Server ile ilgili bir sorundur.";
            else if (kodlar.SelectedItem.ToString() == "U-04")
                kodAciklama.Text = "Ürün silmede hata; Ürün silme işleminde Sql Server ile ilgili bir sorundur.";
            else if (kodlar.SelectedItem.ToString() == "U-05")
                kodAciklama.Text = "Ürün eklerken hata; Ürün ekleme işleminde Sql Server ile ilgili bir sorundur.";
            else if (kodlar.SelectedItem.ToString() == "U-06")
                kodAciklama.Text = "Ürün eklerken hata; Ürün ekleme işleminde boş alan bırakırsanız bu hata ile karşılaşırsınız.";
            else if (kodlar.SelectedItem.ToString() == "U-07")
                kodAciklama.Text = "Ürün güncellemede hata; Güncelleme işleminde Sql Server ile ilgili bir sorundur.";
            else if (kodlar.SelectedItem.ToString() == "U-08")
                kodAciklama.Text = "Ürün silmede hata; Ürün silme işleminde Sql Server ile ilgili bir sorundur.";
            else if (kodlar.SelectedItem.ToString() == "U-09")
                kodAciklama.Text = "Ürün silmede hata; Ürün silme işleminde Sql Server ile ilgili bir sorundur.";
        }
    }
}
