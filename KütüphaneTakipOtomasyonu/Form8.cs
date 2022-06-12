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
    public partial class OduncTakipForm : Form
    {
        public OduncTakipForm()
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

        private void OduncTakipForm_Load(object sender, EventArgs e)
        {
            emanetListele();
        }

        private void İsimArama_OduncTakip_TextBox_TextChanged(object sender, EventArgs e)
        {
            tablo.Tables["tbl_EmanetKitaplar"].Clear();
            baglanti.Open();
            OleDbDataAdapter komut = new OleDbDataAdapter("Select * From tbl_EmanetKitaplar Where ad_soyad Like '%" + İsimArama_OduncTakip_TextBox.Text + "%'",baglanti);
            komut.Fill(tablo, "tbl_EmanetKitaplar");
            baglanti.Close();
            if (İsimArama_OduncTakip_TextBox.Text == "")
            {
                tablo.Tables["tbl_EmanetKitaplar"].Clear();
                emanetListele();
            }
        }

        private void KitapAraOduncTakip_TextBox_TextChanged(object sender, EventArgs e)
        {
            tablo.Tables["tbl_EmanetKitaplar"].Clear();
            baglanti.Open();
            OleDbDataAdapter komut = new OleDbDataAdapter("Select * From tbl_EmanetKitaplar Where kitapadi Like '%" + KitapAraOduncTakip_TextBox.Text + "%'", baglanti);
            komut.Fill(tablo, "tbl_EmanetKitaplar");
            baglanti.Close();
            if (İsimArama_OduncTakip_TextBox.Text == "")
            {
                tablo.Tables["tbl_EmanetKitaplar"].Clear();
                emanetListele();
            }
        }

        private void OduncTakipİptal_Button_Click(object sender, EventArgs e)
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

        private void OduncTakipTeslimAl_Button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Delete * From tbl_EmanetKitaplar Where ad_soyad=@ad_soyad");
            komut.Parameters.AddWithValue("@ad_soyad", dataGridView1.CurrentRow.Cells["ad_soyad"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Teslim Alındı!");
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
}
