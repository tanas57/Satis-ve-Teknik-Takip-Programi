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
    public partial class TakipSil : Form
    {
        public TakipSil()
        {
            InitializeComponent();
        }

        Fonksiyonlar fk = new Fonksiyonlar();
        Takipler Tkp = (Takipler)Application.OpenForms["Takipler"];
        private void Evet_Click(object sender, EventArgs e)
        {
            string id = "";
            FbConnection b1 = new FbConnection(fk.Baglanti_Kodu());
            b1.Open();
            FbCommand TakipDetay = new FbCommand("SELECT TAKIP_ID FROM TEKNIK_TAKIP WHERE TAKIP_NO='"+label8.Text+"'", b1);
            object s = TakipDetay.ExecuteScalar();
            if (s != null)
            {
                FbDataReader idOku = TakipDetay.ExecuteReader(); idOku.Read();
                id = idOku["TAKIP_ID"].ToString(); idOku.Close();
            }
            else
            {
                MessageBox.Show("Sistemsel bir hata oluştu, lütfen sağlayacınıza başvurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            b1.Close();

            if (id != "")
            {
                b1.Open();
                FbCommand Detaylar = new FbCommand("SELECT * FROM TEKNIKTAKIPISLEMLER WHERE TAKIP_ID='"+id+"'", b1);
                object s1 = TakipDetay.ExecuteScalar();
                if (s1 != null)
                {
                    FbDataReader IdOku = Detaylar.ExecuteReader();
                    while (IdOku.Read())
                    {
                        fk.Sil("TEKNIKTAKIPISLEMLER", "TK_ID='"+IdOku["TK_ID"].ToString()+"'");
                    }

                    byte sonuc;
                    sonuc = fk.Sil("Teknik_Takip", "Takip_no='" + label8.Text + "'");
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Teknik Takip başarıyla silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Tkp.GridGuncelle();
                        Tkp.FormLoad();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Teknik Takip silinemedi ( Hata kodu: T-13 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Sistemsel bir hata oluştu, lütfen sağlayacınıza başvurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                b1.Close();
            }
            
        }

        private void Hayir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teknik takip silme işlemi iptal edilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
