using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneTakipOtomasyonu
{
    public partial class AnaSayfaForm : Form
    {
        public AnaSayfaForm()
        {
            InitializeComponent();
        }

        private void AnaSayfaForm_Load(object sender, EventArgs e)
        {

        }

        private void UyeEkle_Button_Click(object sender, EventArgs e)
        {
            UyeEkleForm uyeEkleForm = new UyeEkleForm();
            this.Hide();
            uyeEkleForm.Show();
        }

        private void Uyeİslemleri_Button_Click(object sender, EventArgs e)
        {
            UyeİslemleriForm uyeİslemleriForm = new UyeİslemleriForm();
            this.Hide();
            uyeİslemleriForm.Show();
        }

        private void KitapEkle_Button_Click(object sender, EventArgs e)
        {
            KitapEkleForm kitapEkleForm = new KitapEkleForm();
            this.Hide();
            kitapEkleForm.Show();
        }

        private void KitaplariEkle_Button_Click(object sender, EventArgs e)
        {
            KitapİslemleriForm kitapİslemleriForm = new KitapİslemleriForm();
            this.Hide();
            kitapİslemleriForm.Show();
        }

        private void OduncVer_Button_Click(object sender, EventArgs e)
        {
            OduncVerForm oduncVerForm = new OduncVerForm();
            this.Hide();
            oduncVerForm.Show();
        }

        private void OduncTakip_Button_Click(object sender, EventArgs e)
        {
            OduncTakipForm oduncTakipForm = new OduncTakipForm();
            this.Hide();
            oduncTakipForm.Show();
        }

        private void AdminEkle_Button_Click(object sender, EventArgs e)
        {
            AdminEkleForm adminEkleForm = new AdminEkleForm();
            this.Hide();
            adminEkleForm.Show();
        }

        private void Hakkında_Button_Click(object sender, EventArgs e)
        {
            HakkindaForm hakkindaForm = new HakkindaForm();
            this.Hide();
            hakkindaForm.Show();
        }
        
        private void Cikis_Icon_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Close();
            loginForm.Show();
            
        }

        
    }
}
