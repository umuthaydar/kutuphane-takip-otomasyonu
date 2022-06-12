using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneTakipOtomasyonu
{
    public partial class AdminEkleForm : Form
    {
        public AdminEkleForm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Kütüphane Takip Otomasyonu\\KütüphaneTakipOtomasyonu\\VeriTabanı\\kutuphane.accdb");

        private void veriCek()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Insert Into tbl_Admin(kullaniciadi,sifre) Values(@kullaniciadi,@sifre)");
            komut.Parameters.Add("@kullaniciadi", KullaniciAdi_AdminEkle_TextBox.Text);
            komut.Parameters.Add("@sifre", Sifre_AdminEkle_TextBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Admin Kaydı Başarılı!");
        }

        private void AdminEkleKaydet_Button_Click(object sender, EventArgs e)
        {
            veriCek();
            foreach (Control i in Controls)
            {
                if (i is TextBox)
                {
                    i.Text = "";
                }
            }
        }

        private void Cikis_Icon_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfaForm anaSayfaForm = new AnaSayfaForm();
            anaSayfaForm.Show();
        }

        private void AdminEkleİptal_Button_Click(object sender, EventArgs e)
        {
            foreach (Control i in Controls)
            {
                if (i is TextBox)
                {
                    i.Text = "";
                }
            }
            this.Close();
            AnaSayfaForm anaSayfaForm = new AnaSayfaForm();
            anaSayfaForm.Show();
        }
    }
}
