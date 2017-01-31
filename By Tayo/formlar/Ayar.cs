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
    public partial class Ayar : Form
    {
        public Ayar()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        Lisanslama ls = new Lisanslama();
        private void Ayar_Load(object sender, EventArgs e)
        {
            try
            {
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbCommand VeriCek = new FbCommand("select * from Ayar", baglan);
                FbDataReader VeriOku = VeriCek.ExecuteReader();
                VeriOku.Read();
                unvan.Text = VeriOku["firma_unvani"].ToString();
                adres.Text = VeriOku["firma_adres"].ToString();
                telefon.Text = VeriOku["firma_telefon"].ToString();
                yedek_dizin.Text = VeriOku["yedek_dizin"].ToString();
                if (VeriOku["program_acilis"].ToString() == "1") otoBaslangic.Checked = true;
                else otoBaslangic.Checked = false;
                VeriOku.Close();
                baglan.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DizinAc_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(yedek_dizin.Text);
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void DizinSec_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;

            // Kontrolü göster
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                yeni_dizin.Text = folderBrowserDialog1.SelectedPath;
                yeni_dizin.Visible = true;
                yedek_dizin.Text = yeni_dizin.Text;
            }
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                if (yeni_dizin.Text.Length > 1)
                {
                    FbCommand Guncelle = new FbCommand("update Ayar set yedek_dizin='" + yeni_dizin.Text + "'", baglan);
                    Guncelle.ExecuteNonQuery();
                    yedek_dizin.Text = yeni_dizin.Text;
                    MessageBox.Show("Yedekleme dizininiz başarıyla güncellenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen yedek dizinini seçin.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglan.Close();
            }
            catch (Exception e4)
            {
                MessageBox.Show(e4.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guncellee_Click(object sender, EventArgs e)
        {
            try
            {
                unvan.Text = unvan.Text.Replace("'", "’");
                adres.Text = adres.Text.Replace("'", "’");
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbCommand Guncelle = new FbCommand("update Ayar set firma_unvani='" + fk.IlkHarfleriBuyut(unvan.Text) + "', firma_adres='" + fk.IlkHarfleriBuyut(adres.Text) + "', firma_telefon='" + telefon.Text + "'", baglan);
                Guncelle.ExecuteNonQuery();
                MessageBox.Show("Firma bilgileri başarıyla güncellenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglan.Close();
            }
            catch (Exception e5)
            {
                MessageBox.Show(e5.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void otoBaslangic_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (otoBaslangic.Checked == true)
                {
                    FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                    baglan.Open();
                    FbCommand Guncelle = new FbCommand("update Ayar set program_acilis='1'", baglan);
                    Guncelle.ExecuteNonQuery(); baglan.Close();
                    fk.OtomatikBaslangic(true);
                }
                else
                {
                    FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                    baglan.Open();
                    FbCommand Guncelle = new FbCommand("update Ayar set program_acilis='0'", baglan);
                    Guncelle.ExecuteNonQuery(); baglan.Close();
                    fk.OtomatikBaslangic(false);
                }
            }
            catch (Exception e6)
            {
                MessageBox.Show(e6.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formukapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            folderBrowserDialog1.ShowNewFolderButton = true;

            // Kontrolü göster
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                yeni_dizin.Text = folderBrowserDialog1.SelectedPath;
                yeni_dizin.Visible = true;
            }
        }
    }
}
