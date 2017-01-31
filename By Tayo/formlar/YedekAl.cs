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
    public partial class YedekAl : Form
    {
        public YedekAl()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        private void DizinSec_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog1.ShowNewFolderButton = true;

                // Kontrolü göster
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Dizin.Text = folderBrowserDialog1.SelectedPath;
                    Dizin.Visible = true;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dizin.Text != "")
                {
                    fk.YedekAl(Dizin.Text);
                    System.Diagnostics.Process.Start(Dizin.Text);
                }
                else
                {
                    fk.YedekAl("Standart");
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fk.YedekAl("Standart");
        }

        private void YedekAl_Load(object sender, EventArgs e)
        {
            tarih.Text = fk.SonYedekAlma();
            if (tarih.Text == "")
                tarih.Text = "Yedekleme yapılmamıştır.";
        }
    }
}
