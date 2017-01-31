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
    public partial class iletisim : Form
    {
        public iletisim()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        private void iletisim_Load(object sender, EventArgs e)
        {
            this.Text = fk.FirmaAdi + " İletişim";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ayancikhost.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:bilgi@ayancikhost.com");
        }

        private void formukapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
