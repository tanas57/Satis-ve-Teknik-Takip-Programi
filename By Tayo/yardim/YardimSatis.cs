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
    public partial class YardimSatis : Form
    {
        public YardimSatis()
        {
            InitializeComponent();
        }

        private void YardimSatis_Load(object sender, EventArgs e)
        {
            kodlar.SelectedIndex = 0;
        }

        private void kodlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kodlar.SelectedItem.ToString() == "S-02")
                kodAciklama.Text = "Satışı barkod numarası ile eklemek istediğinizde barkod numarasını boş geçerseniz bu hatayı alırsınız.";
            else if (kodlar.SelectedItem.ToString() == "S-01")
                kodAciklama.Text = "Satış ekleme sırasında meydana gelen bir hatadır. Bu hata veritabanında meydana gelen bir hatadan dolayı verilmektedir.";
        }
    }
}
