using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FirebirdSql.Data.FirebirdClient;
namespace By_Tayo
{
    public partial class YedekYukle : Form
    {
        public YedekYukle()
        {
            InitializeComponent();
        }
        OpenFileDialog file = new OpenFileDialog();
        Fonksiyonlar fk = new Fonksiyonlar();
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                file.Filter = "Yedek Dosyası |*.fbk";
                file.Title = "Yüklemek istediğiniz yedek dosyasını seçiniz";
                file.Multiselect = false;
                file.ShowDialog();
                YukleYol.Text = file.FileName.ToString();
                YukleYol.Visible = true;
            }
            catch (Exception ed1)
            {
                MessageBox.Show(ed1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (file.FileName.ToString() != "")
                {
                    DialogResult sor = MessageBox.Show("Seçilen yedek işleme alınacaktır. Bu işlemin geri dönüşü yoktur. İşleme devam edilsin mi ? ", "Yedekleme Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (sor == DialogResult.Yes)
                    {
                        fk.YedekYukle(YukleYol.Text);
                    }
                    else
                    {
                        MessageBox.Show("Yedek yükleme işlemi iptal edilmiştir.", "Yedekleme Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen veritabanı yedek dosyası (.fbk) seçiniz", "Yedekleme Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ed1)
            {
                MessageBox.Show(ed1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void YedekYukle_Load(object sender, EventArgs e)
        {
            try
            {
                tarih.Text = fk.SonYedekYukleme();
                if (tarih.Text == "") tarih.Text = "Yedek yüklenmemiştir.";
            }
            catch (Exception ed1)
            {
                MessageBox.Show(ed1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            try
            {
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbCommand Cek = new FbCommand("select yedek_dizin from Ayar", baglan);
                FbDataReader oku = Cek.ExecuteReader();
                oku.Read();
                string path = oku["yedek_dizin"].ToString();
                baglan.Close();
                if (path == "" || path == "0")
                    path = Application.StartupPath.ToString();

                DirectoryInfo Yillar = new DirectoryInfo(path+"\\");
                DirectoryInfo[] Dos = Yillar.GetDirectories();

                if (Dos.Length > 0)
                {
                    foreach (DirectoryInfo yaz in Dos)
                    {
                        yil.Items.Add(yaz.Name);
                    }
                    yil.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Yedek dosyanız bulunmamaktadır.", "Yedekleme Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                yedek.Items.Clear();
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbCommand Cek = new FbCommand("select yedek_dizin from Ayar", baglan);
                FbDataReader oku = Cek.ExecuteReader();
                oku.Read();
                string path = oku["yedek_dizin"].ToString();
                baglan.Close();

                DirectoryInfo Yillar = new DirectoryInfo(path + "\\" + yil.Text + "\\" + ay.Text);
                FileInfo[] Dos = Yillar.GetFiles();

                if (Dos.Length > 0)
                {
                    yedek.Items.Clear();
                    foreach (FileInfo yaz in Dos)
                    {
                        yedek.Items.Add(yaz.Name);
                    }
                    yedek.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Seçilen ayda yedek dosyanız bulunmamaktadır.", "Yedekleme Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ed1)
            {
                MessageBox.Show(ed1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yil_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ay.Items.Clear();
                FbConnection baglan = new FbConnection(fk.Baglanti_Kodu());
                baglan.Open();
                FbCommand Cek = new FbCommand("select yedek_dizin from Ayar", baglan);
                FbDataReader oku = Cek.ExecuteReader();
                oku.Read();
                string path = oku["yedek_dizin"].ToString();
                baglan.Close();

                DirectoryInfo Yillar = new DirectoryInfo(path + "\\" + yil.Text);
                DirectoryInfo[] Dos = Yillar.GetDirectories();

                if (Dos.Length > 0)
                {
                    ay.Items.Clear();
                    foreach (DirectoryInfo yaz in Dos)
                    {
                        ay.Items.Add(yaz.Name);
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen yılda yedek dosyanız bulunmamaktadır.", "Yedekleme Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ed1)
            {
                MessageBox.Show(ed1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sor = MessageBox.Show("Seçilen yedek işleme alınacaktır. Bu işlemin geri dönüşü yoktur. İşleme devam edilsin mi ? ", "Yedekleme Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sor == DialogResult.Yes)
                {
                    string yol = fk.YedekDizin() + "\\" + yil.Text + "\\" + ay.Text + "\\" + yedek.Text;
                    fk.YedekYukle(yol);
                }
                else
                {
                    MessageBox.Show("Yedek yükleme işlemi iptal edilmiştir.", "Yedekleme Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ed1)
            {
                MessageBox.Show(ed1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
