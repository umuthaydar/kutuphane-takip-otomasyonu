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
    public partial class KitapİslemleriForm : Form
    {
        public KitapİslemleriForm()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Kütüphane Takip Otomasyonu\\KütüphaneTakipOtomasyonu\\VeriTabanı\\kutuphane.accdb");
        DataSet tablo = new DataSet();

        public void kitapListele()
        {
            baglanti.Open();
            string komut = "Select * From tbl_kitaplar";
            OleDbDataAdapter da = new OleDbDataAdapter(komut, baglanti);
            da.Fill(tablo, "tbl_kitaplar");
            Kitapİslemleri_DataGridView.DataSource = tablo.Tables["tbl_kitaplar"];
            baglanti.Close();
        }
        
        private void KitapİslemleriForm_Load(object sender, EventArgs e)
        {
            kitapListele();
        }

        private void KitapAdi_Kitapİslemleri_TextBox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From tbl_kitaplar Where kitapadi Like '%" + KitapAdi_Kitapİslemleri_TextBox.Text + "%'");
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                
                YazarAdi_Kitapİslemleri_TextBox.Text = oku["yazaradi"].ToString();
                Turu_Kitapİslemleri_ComboBox.Text = oku["turu"].ToString();
                SayfaSayisi_Kitapİslemleri_TextBox.Text = oku["sayfasayisi"].ToString();
                YayinEvi_Kitapİslemleri_TextBox.Text = oku["yayinevi"].ToString();
                StokAdet_Kitapİslemleri_TextBox.Text = oku["stokadet"].ToString();
            }
            baglanti.Close();
        }

        private void KitapAdiArama_Kitapİslemleri_TextBox_TextChanged(object sender, EventArgs e)
        {
            tablo.Tables["tbl_kitaplar"].Clear();
            baglanti.Open();
            string komut = "Select * From tbl_kitaplar Where kitapadi Like '%" + KitapAdiArama_Kitapİslemleri_TextBox.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(komut, baglanti);
            da.Fill(tablo);
            Kitapİslemleri_DataGridView.DataSource = tablo;
            baglanti.Close();
        }
        
        private void KitapİslemleriGuncelle_Button_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Update tbl_kitaplar Set kitapadi=@kitapadi,yazaradi=@yazaradi,turu=@turu,sayfasayisi=@sayfasayisi,yayinevi=@yayinevi,stokadet=@stokadet Where kitapadi=@kitapadi");
            komut.Parameters.AddWithValue("@kitapadi", KitapAdi_Kitapİslemleri_TextBox.Text);
            komut.Parameters.AddWithValue("@yazaradi", YazarAdi_Kitapİslemleri_TextBox.Text);
            komut.Parameters.AddWithValue("@turu", Turu_Kitapİslemleri_ComboBox.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", SayfaSayisi_Kitapİslemleri_TextBox.Text);
            komut.Parameters.AddWithValue("@yayinevi", YayinEvi_Kitapİslemleri_TextBox.Text);
            komut.Parameters.AddWithValue("@stokadet", StokAdet_Kitapİslemleri_TextBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı!");
            tablo.Tables["tbl_kitaplar"].Clear();
            kitapListele();
            foreach (Control i in Controls)
            {
                if (i is TextBox)
                {
                    i.Text = "";
                }
            }
        }

        private void KitapİslemleriSil_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu Kaydı Silmek İstediğinize Emin Misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = ("Delete * From tbl_kitaplar Where kitapadi=@kitapadi");
                komut.Parameters.AddWithValue("@kitapadi", Kitapİslemleri_DataGridView.CurrentRow.Cells["kitapadi"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti!");
                tablo.Tables["tbl_kitaplar"].Clear();
                kitapListele();
                foreach (Control i in Controls)
                {
                    if (i is TextBox)
                    {
                        i.Text = "";
                    }
                }
            }

        }

        private void Kitapİslemleriİptal_Button_Click(object sender, EventArgs e)
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
