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
    public partial class UyeEkleForm : Form
    {
        public UyeEkleForm()
        {
            InitializeComponent();
        }
       
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Kütüphane Takip Otomasyonu\\KütüphaneTakipOtomasyonu\\VeriTabanı\\kutuphane.accdb");
        private void veriCek()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Insert Into tbl_Uye(ad_soyad,yas,cinsiyet,telefon,email,adres) Values(@ad_soyad,@yas,@cinsiyet,@telefon,@email,@adres)");
            komut.Parameters.Add("@ad_soyad", İsim_UyeEkle_TextBox.Text);
            komut.Parameters.Add("@yas", Yas_UyeEkle_TextBox.Text);
            komut.Parameters.Add("@cinsiyet", Cinsiyet_UyeEkle_ComboBox.Text);
            komut.Parameters.Add("@telefon", Telefon_UyeEkle_TextBox.Text);
            komut.Parameters.Add("@email", Email_UyeEkle_TextBox.Text);
            komut.Parameters.Add("@adres", Adres_UyeEkle_TextBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye Kaydı Başarılı!");
        }
        private void UyeEkleKaydet_Button_Click(object sender, EventArgs e)
        {
            veriCek();
            foreach(Control i in Controls)
            {
                if(i is TextBox)
                {
                    i.Text = "";
                }
            }
        }

        private void UyeEkleİptal_Button_Click(object sender, EventArgs e)
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

        private void Cikis_Icon_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfaForm anaSayfaForm = new AnaSayfaForm();
            anaSayfaForm.Show();
        }
    }
}
