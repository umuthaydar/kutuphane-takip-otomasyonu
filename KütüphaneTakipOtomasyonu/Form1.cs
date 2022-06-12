using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KütüphaneTakipOtomasyonu
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }
        
        
        AnaSayfaForm AnaSayfaForm = new AnaSayfaForm();
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Kütüphane Takip Otomasyonu\\KütüphaneTakipOtomasyonu\\VeriTabanı\\kutuphane.accdb");
        
        private void veriÇek()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From tbl_Admin Where kullaniciadi='"+KullaniciAdi_TextBox.Text+"'And sifre='"+Parola_TextBox.Text+"'");
            OleDbDataReader oku = komut.ExecuteReader();
            
            if (oku.Read() == true)
            {
                MessageBox.Show("Giriş Başarılı!");
                this.Hide();
                AnaSayfaForm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre!");
            }
            baglanti.Close();
        }

        private void Giris_Button_Click(object sender, EventArgs e)
        {
                    veriÇek();
        }

        private void Cikis_Icon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
