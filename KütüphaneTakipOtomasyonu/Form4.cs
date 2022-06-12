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
    public partial class UyeİslemleriForm : Form
    {
        public UyeİslemleriForm()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Kütüphane Takip Otomasyonu\\KütüphaneTakipOtomasyonu\\VeriTabanı\\kutuphane.accdb");
        DataSet tablo = new DataSet();
        private void uyeListele()
        {
            baglanti.Open();
            string komut = "Select * From tbl_Uye";
            OleDbDataAdapter da = new OleDbDataAdapter(komut, baglanti);
            da.Fill(tablo,"tbl_uye");
            Uyeİslemleri_DataGridView.DataSource = tablo.Tables["tbl_Uye"];
            baglanti.Close();
        }

        private void UyeİslemleriForm_Load(object sender, EventArgs e)
        {
            uyeListele();
        }

        private void İsim_Uyeİslemleri_TextBox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From tbl_Uye Where ad_soyad Like '%"+İsim_Uyeİslemleri_TextBox.Text+"%'");
            OleDbDataReader oku = komut.ExecuteReader();
            
            while (oku.Read()) {
                Yas_Uyeİslemleri_TextBox.Text = oku["yas"].ToString();
                Cinsiyet_Uyeİslemleri_ComboBox.Text = oku["cinsiyet"].ToString();
                Telefon_Uyeİslemleri_TextBox.Text = oku["telefon"].ToString();
                Email_Uyeİslemleri_TextBox.Text = oku["email"].ToString();
                Adres_Uyeİslemleri_TextBox.Text = oku["adres"].ToString();
            }
            baglanti.Close();
        }

        private void Uyeİslemleri_DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            İsim_Uyeİslemleri_TextBox.Text = Uyeİslemleri_DataGridView.CurrentRow.Cells["ad_soyad"].Value.ToString();
        }


        private void İsimAra_Uyeİslemleri_TextBox_TextChanged(object sender, EventArgs e)
        {
            tablo.Tables["tbl_Uye"].Clear();
            baglanti.Open();
            string komut = "Select * From tbl_Uye Where ad_soyad Like '%" + İsimAra_Uyeİslemleri_TextBox.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(komut, baglanti);
            da.Fill(tablo, "tbl_Uye");
            Uyeİslemleri_DataGridView.DataSource = tablo.Tables["tbl_Uye"];
            baglanti.Close();
            
        }

       private void UyeİslemleriGuncelle_Button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Update tbl_Uye Set ad_soyad=@ad_soyad,yas=@yas,cinsiyet=@cinsiyet,telefon=@telefon,email=@email,adres=@adres Where ad_soyad=@ad_soyad");
            komut.Parameters.AddWithValue("@ad_soyad", İsim_Uyeİslemleri_TextBox.Text);
            komut.Parameters.AddWithValue("@yas", Yas_Uyeİslemleri_TextBox.Text);
            komut.Parameters.AddWithValue("@cinsiyet", Cinsiyet_Uyeİslemleri_ComboBox.Text);
            komut.Parameters.AddWithValue("@telefon", Telefon_Uyeİslemleri_TextBox.Text);
            komut.Parameters.AddWithValue("@email", Email_Uyeİslemleri_TextBox.Text);
            komut.Parameters.AddWithValue("@adres", Adres_Uyeİslemleri_TextBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı!");
            tablo.Tables["tbl_Uye"].Clear();
            uyeListele();
            foreach (Control i in Controls)
            {
                if (i is TextBox)
                {
                    i.Text = "";
                }
            }
        }

        private void UyeİslemleriSil_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu Kaydı Silmek İstediğinize Emin Misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = ("Delete * From tbl_Uye Where ad_soyad=@ad_soyad");
                komut.Parameters.AddWithValue("@ad_soyad", Uyeİslemleri_DataGridView.CurrentRow.Cells["ad_soyad"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti!");
                tablo.Tables["tbl_Uye"].Clear();
                uyeListele();
                foreach (Control i in Controls)
                {
                    if (i is TextBox)
                    {
                        i.Text = "";
                    }
                }
            }
            
        }

        private void Uyeİslemleriİptal_Button_Click(object sender, EventArgs e)
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
