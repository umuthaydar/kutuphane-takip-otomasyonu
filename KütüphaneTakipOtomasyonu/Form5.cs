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
    public partial class KitapEkleForm : Form
    {
        public KitapEkleForm()
        {
            InitializeComponent();
        }
        
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Kütüphane Takip Otomasyonu\\KütüphaneTakipOtomasyonu\\VeriTabanı\\kutuphane.accdb");
        private void veriCek()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Insert Into tbl_kitaplar(kitapadi,yazaradi,turu,sayfasayisi,yayinevi,stokadet) Values(@kitapadi,@yazaradi,@turu,@sayfasayisi,@yayinevi,@stokadet)");
            komut.Parameters.Add("@kitapadi", KitapAdi_KitapEkle_TextBox.Text);
            komut.Parameters.Add("@yazaradi", YazarAdi_KitapEkle_TextBox.Text);
            komut.Parameters.Add("@turu", Turu_KitapEkle_ComboBox.Text);
            komut.Parameters.Add("@sayfasayisi", SayfaSayisi_KitapEkle_TextBox.Text);
            komut.Parameters.Add("@yayinevi", YayinEvi_KitapEkle_TextBox.Text);
            komut.Parameters.Add("@stokadet", StokAdet_KitapEkle_TextBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Kaydı Başarılı!");
        }
        private void KitapEkleKaydet_Button_Click(object sender, EventArgs e)
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

        private void KitapEkleİptal_Button_Click(object sender, EventArgs e)
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
