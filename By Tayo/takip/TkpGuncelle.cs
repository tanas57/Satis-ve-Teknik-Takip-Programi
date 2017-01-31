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
    public partial class TkpGuncelle : Form
    {
        public TkpGuncelle()
        {
            InitializeComponent();
        }
        Fonksiyonlar fk = new Fonksiyonlar();
        Takipler Tkp = (Takipler)Application.OpenForms["Takipler"];
        private void TkpGuncelle_Load(object sender, EventArgs e)
        {

        }

        private void CihazBGuncelle_Click(object sender, EventArgs e)
        {
            if (marka.Text != "" && model.Text != "" && (imei.Text != "" || serino.Text != ""))
            {
                byte sonuc;
                sonuc = fk.Guncelle("Teknik_Takip", "Takip_marka='" + fk.IlkHarfleriBuyut(marka.Text) + "', Takip_model='" + fk.IlkHarfleriBuyut(model.Text) + "', Takip_imei='" + imei.Text + "', Takip_serino='" + serino.Text + "'", "Takip_no='" + label8.Text + "'");
                if (sonuc == 1)
                {
                    MessageBox.Show("Cihaz bilgileri başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tkp.GridGuncelle();
                    if (Tkp.takipno.Text != "TKP") Tkp.TakipArama();
                    else Tkp.FormLoad();
                }
                else
                    MessageBox.Show("Cihaz bilgileri güncellenemedi ( Hata kodu: T-10 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Cihaz bilgilerini eksiksiz doldurunuz. ( Hata kodu: T-09 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MusteriBGuncelle_Click(object sender, EventArgs e)
        {
            if (adsoyad.Text != "" && telefon.Text !="")
            {
                byte sonuc;
                sonuc = fk.Guncelle("Teknik_Takip", "Takip_kisibilgi='" + fk.IlkHarfleriBuyut(adsoyad.Text) + "', Takip_kisiTel='" + telefon.Text + "'", "Takip_no='" + label8.Text + "'");
                if (sonuc == 1)
                {
                    MessageBox.Show("Müşteri bilgileri başarıyla güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tkp.GridGuncelle();
                    if (Tkp.takipno.Text != "TKP") Tkp.TakipArama();
                    else Tkp.FormLoad();
                }
                else
                    MessageBox.Show("Müşteri bilgileri güncellenemedi ( Hata kodu: T-11 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Müşteri bilgilerini eksiksiz doldurunuz. ( Hata kodu: T-12 )", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imei_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
