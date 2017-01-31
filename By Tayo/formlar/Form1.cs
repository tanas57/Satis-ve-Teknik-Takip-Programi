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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        KontrolForm kf = new KontrolForm();
        
        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriEkle mus = new MusteriEkle();
            mus.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = fk.FirmaAdi + " " + fk.ProAdi + " " + fk.Ekleme + " Versiyon: " +fk.Versiyon;

            fk.DizinAyar();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteri mus1 = new Musteri();
            mus1.ShowDialog();
        }

        private void müşteriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriGuncelle2 musg1 = new MusteriGuncelle2();
            musg1.ShowDialog();
        }

        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriSil2 muss2 = new MusteriSil2();
            muss2.ShowDialog();
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunKategori uk = new UrunKategori();
            uk.ShowDialog();
        }

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunKategoriEkle uke = new UrunKategoriEkle();
            uke.ShowDialog();
        }

        private void kategoriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunKategoriGuncelle2 ukg2 = new UrunKategoriGuncelle2();
            ukg2.ShowDialog();
        }

        private void kategoriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunKategoriSil2 uks2 = new UrunKategoriSil2();
            uks2.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UrunEkle ue = new UrunEkle();
            ue.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            UrunGuncelle2 ug2 = new UrunGuncelle2();
            ug2.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            UrunSil2 us2 = new UrunSil2();
            us2.ShowDialog();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void günlükRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisGunluk sg = new SatisGunluk();
            sg.ShowDialog();
        }

        private void haftalıkRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisHaftalik sf = new SatisHaftalik();
            sf.ShowDialog();
        }

        private void aylıkRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SatisAylik sa = new SatisAylik();
            sa.ShowDialog();
        }

        private void kategorilerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MusteriKategori mk = new MusteriKategori();
            mk.ShowDialog();
        }

        private void yeniEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MusteriKategoriEkle mke = new MusteriKategoriEkle();
            mke.ShowDialog();
        }

        private void yeniEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakipEkle te = new TakipEkle();
            te.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult sor = MessageBox.Show("Veritabanı yedeklemesi yapılsın mı ?", "Yedekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sor == DialogResult.Yes)
            {
                fk.YedekAl("Standart");
                Application.Exit();
            }
            else
                Application.Exit();
        }

        private void takipGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TakipGuncelle tg = new TakipGuncelle();
            tg.ShowDialog();
        }

        private void günlükRaporToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SatisGunluk sg = new SatisGunluk();
            sg.ShowDialog();
        }

        private void haftalıkRaporToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SatisHaftalik sf = new SatisHaftalik();
            sf.ShowDialog();
        }

        private void aylıkRaporToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SatisAylik sa = new SatisAylik();
            sa.ShowDialog();
        }

        private void satışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            YardimSatis ys = new YardimSatis();
            ys.ShowDialog();
        }

        private void takiplerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Takipler t = new Takipler();
            t.ShowDialog();
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YardimUrun yu = new YardimUrun();
            yu.ShowDialog(); 
        }

        private void müşteriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            YardimMusteri ym = new YardimMusteri();
            ym.ShowDialog();
        }

        private void teknikTakipToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            YardimTakip tk = new YardimTakip();
            tk.ShowDialog();
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YardimRapor yr = new YardimRapor();
            yr.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.ayancikhost.com");
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yeniSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniSatis ys = new YeniSatis();
            ys.ShowDialog();
        }

        private void satışlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satislar s = new Satislar();
            s.ShowDialog();
        }

        private void manuelSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManuelSatis ms = new ManuelSatis();
            ms.ShowDialog();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iletisim i = new iletisim(); i.ShowDialog();
        }

        private void ayarlarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ayar aa = new Ayar(); aa.ShowDialog();
        }

        private void yedeklemeYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YedekAl ya = new YedekAl(); ya.ShowDialog();
        }

        private void yedektenGeriYükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YedekYukle yy = new YedekYukle(); yy.ShowDialog();
        }

        private void programınDiziniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Programın çalıştığı dizin\n " + Application.StartupPath.ToString(), "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(Application.StartupPath.ToString());
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreDegis sd = new SifreDegis(); sd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
