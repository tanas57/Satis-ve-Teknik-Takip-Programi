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
    public partial class UrunKategori : Form
    {
        public UrunKategori()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        private void Kategori_Adi_TextChanged(object sender, EventArgs e)
        {
            Kategori_Adi.Text = Kategori_Adi.Text.Replace("'", "’");
            Ara();
        }

        private void UrunKategori_Load(object sender, EventArgs e)
        {
            KategoriDataGrid.DataSource = fk.KategoriStunOlustur();
            FormLoad();
        }

        private void KategoriDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataId.Text = KategoriDataGrid.CurrentRow.Cells[0].Value.ToString();
        }

        private void KategoriGuncelle_Click(object sender, EventArgs e)
        {
            DataId.Text = KategoriDataGrid.CurrentRow.Cells[0].Value.ToString();
            UrunKategoriGuncelle ukg = new UrunKategoriGuncelle();
            ukg.id = DataId.Text;
            ukg.ShowDialog();
        }

        private void KategoriSil_Click(object sender, EventArgs e)
        {
            DataId.Text = KategoriDataGrid.CurrentRow.Cells[0].Value.ToString();
            UrunKategoriSil uks = new UrunKategoriSil();
            uks.id = DataId.Text;
            uks.ShowDialog();
        }

        private void katekle_Click(object sender, EventArgs e)
        {
            UrunKategoriEkle uke = new UrunKategoriEkle();
            uke.Show();
        }

        public void FormLoad()
        {
            try
            {
                ToolTip Aciklama = new ToolTip();
                Aciklama.SetToolTip(katekle, "Ürün Kategorisi Ekle");


                FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                FbDataReader KategoriOku; DataRow satir;
                baglanti.Open();
                FbCommand KategoriAraSorgu = new FbCommand("SELECT * FROM Urun_kategori", baglanti);
                fk.dt.Clear();
                KategoriDataGrid.Refresh();
                object sonuc = KategoriAraSorgu.ExecuteScalar();
                if (sonuc != null)
                {
                    KategoriOku = KategoriAraSorgu.ExecuteReader();
                    while (KategoriOku.Read())
                    {
                        satir = fk.dt.NewRow();
                        satir["Kategori Id"] = KategoriOku["Kategori_id"].ToString();
                        satir["Kategori Adı"] = KategoriOku["Kategori_adi"].ToString();
                        fk.dt.Rows.Add(satir);
                    }
                }
                else
                {
                    MessageBox.Show("Ürün kategorisi ekleyiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UrunKategoriEkle uke = new UrunKategoriEkle();
                    uke.ShowDialog();
                    this.Close();
                }
                baglanti.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Ara()
        {
            try
            {
                if (Kategori_Adi.Text.Length > 0)
                {
                    FbConnection baglanti = new FbConnection(fk.Baglanti_Kodu());
                    FbDataReader KategoriOku; object sonuc; DataRow satir;
                    baglanti.Open();
                    FbCommand KategoriAraSorgu = new FbCommand("SELECT * FROM Urun_kategori WHERE Kategori_adi like '%" + Kategori_Adi.Text + "%'", baglanti);
                    sonuc = KategoriAraSorgu.ExecuteScalar();
                    if (sonuc != null)
                    {
                        fk.dt.Clear();
                        KategoriDataGrid.Refresh();
                        KategoriOku = KategoriAraSorgu.ExecuteReader();
                        while (KategoriOku.Read())
                        {
                            satir = fk.dt.NewRow();
                            satir["Kategori Id"] = KategoriOku["Kategori_id"].ToString();
                            satir["Kategori Adı"] = KategoriOku["Kategori_adi"].ToString();
                            fk.dt.Rows.Add(satir);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aranan isme göre kategori bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen kategori adını boş bırakmayın ( Hata kodu: K-01 )", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GridYenile()
        {
            fk.dt.Clear();
            KategoriDataGrid.Refresh();
        }
    }
}
