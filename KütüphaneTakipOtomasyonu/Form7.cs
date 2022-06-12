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
    public partial class OduncVerForm : Form
    {
        public OduncVerForm()
        {
            InitializeComponent();
        }


        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Kütüphane Takip Otomasyonu\\KütüphaneTakipOtomasyonu\\VeriTabanı\\kutuphane.accdb");

        DataSet tablo = new DataSet();

        public void emanetListele()
        {
            baglanti.Open();
            string komut = "Select * From tbl_EmanetKitaplar";
            OleDbDataAdapter da = new OleDbDataAdapter(komut, baglanti);
            da.Fill(tablo, "tbl_EmanetKitaplar");
            dataGridView1.DataSource = tablo.Tables["tbl_EmanetKitaplar"];
            baglanti.Close();

        }

        private void OduncVerForm_Load(object sender, EventArgs e)
        {
            emanetListele();
        }

        
        
        
        private void İsim_OduncVer_TextBox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From tbl_Uye Where ad_soyad Like '%" + İsim_OduncVer_TextBox.Text + "%'");
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                Yas_OduncVer_TextBox.Text = oku["yas"].ToString();
                Telefon_OduncVer_TextBox.Text = oku["telefon"].ToString();
                
            }
            baglanti.Close();

            if(İsim_OduncVer_TextBox.Text == "")
            {
                foreach (Control i in groupBox1.Controls)
                {
                    i.Text = "";
                }
            }
        }
        private void KitapAdi_OduncVer_TextBox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From tbl_kitaplar Where kitapadi Like '%" + KitapAdi_OduncVer_TextBox.Text + "%'");
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                
                YazarAdi_OduncVer_TextBox.Text = oku["yazaradi"].ToString();
                SayfaSayisi_OduncVer_TextBox.Text = oku["sayfasayisi"].ToString();
                YayinEvi_OduncVer_TextBox.Text = oku["yayinevi"].ToString();

            }
            baglanti.Close();
            if (KitapAdi_OduncVer_TextBox.Text == "")
            {
                foreach (Control i in groupBox2.Controls)
                {
                    i.Text = "";
                }
            }
        }

        private void OduncVerTeslimEt_Button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Insert Into tbl_EmanetKitaplar(ad_soyad,yas,telefon,kitapadi,yazaradi,sayfasayisi,yayinevi,teslimtarihi,iadetarihi) Values(@ad_soyad,@yas,@telefon,@kitapadi,@yazaradi,@sayfasayisi,@yayinevi,@teslimtarihi,iadetarihi)");
            komut.Parameters.Add("@ad_soyad", İsim_OduncVer_TextBox.Text);
            komut.Parameters.Add("@yas", Yas_OduncVer_TextBox.Text);
            komut.Parameters.Add("@telefon", Telefon_OduncVer_TextBox.Text);
            komut.Parameters.Add("@kitapadi", KitapAdi_OduncVer_TextBox.Text);
            komut.Parameters.Add("@yazaradi", YazarAdi_OduncVer_TextBox.Text);
            komut.Parameters.Add("@sayfasayisi", SayfaSayisi_OduncVer_TextBox.Text);
            komut.Parameters.Add("@yayinevi", YayinEvi_OduncVer_TextBox.Text);
            komut.Parameters.Add("@teslimtarihi", dateTimePicker1.Text);
            komut.Parameters.Add("@iadetarihi", dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydı Başarılı!");
        }

        private void OduncVerSil_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu Kaydı Silmek İstediğinize Emin Misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = ("Delete * From tbl_EmanetKitaplar Where ad_soyad=@ad_soyad");
                komut.Parameters.AddWithValue("@ad_soyad", dataGridView1.CurrentRow.Cells["ad_soyad"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti!");
                tablo.Tables["tbl_EmanetKitaplar"].Clear();
                emanetListele();
                foreach (Control i in Controls)
                {
                    if (i is TextBox)
                    {
                        i.Text = "";
                    }
                }
            }
        }

        private void OduncVerİptal_Button_Click(object sender, EventArgs e)
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
