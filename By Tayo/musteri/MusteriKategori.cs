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
    public partial class MusteriKategori : Form
    {
        public MusteriKategori()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        MusteriKategoriGuncelle mkg = new MusteriKategoriGuncelle();
        MusteriKategoriSil mks = new MusteriKategoriSil();
        private void MusteriKategori_Load(object sender, EventArgs e)
        {
            FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
            baglanti.Open();

            FbDataAdapter ad = new FbDataAdapter("select * from Musteri_kategori", baglanti);
            FbCommand ad2 = new FbCommand("select * from Musteri_kategori", baglanti);
            object sonuc = ad2.ExecuteScalar();
            if (sonuc != null)
            {
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Müşteri kategorisi ekleyin", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MusteriKategoriEkle mke = new MusteriKategoriEkle();
                mke.ShowDialog();
                this.Close();
            }
            baglanti.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void MusteriGuncelle_Click(object sender, EventArgs e)
        {
            DataId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MusteriKategoriGuncelle mkg = new MusteriKategoriGuncelle();
            mkg.id = DataId.Text;
            mkg.ShowDialog();
        }

        private void MusteriSil_Click(object sender, EventArgs e)
        {
            DataId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            MusteriKategoriSil mks = new MusteriKategoriSil();
            mks.id = DataId.Text;
            mks.ShowDialog();
        }
    }
}
