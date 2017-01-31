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
    public partial class YardimRapor : Form
    {
        public YardimRapor()
        {
            InitializeComponent();
        }

        private void YardimRapor_Load(object sender, EventArgs e)
        {
            kodlar.SelectedIndex = 0;
        }

        private void kodlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kodlar.SelectedItem.ToString() == "R-01")
                kodAciklama.Text = "Günlük Raporlama; Bugünün tarihinde hiç satış eklenmemiştir.";
            else if (kodlar.SelectedItem.ToString() == "R-02")
                kodAciklama.Text = "Haftalık Raporlama; Bu hafta hiç satış eklenmemiştir.";
            else if (kodlar.SelectedItem.ToString() == "R-03")
                kodAciklama.Text = "Aylık Raporlama; Bu ay hiç satış eklenmemiştir.";
        }
    }
}
