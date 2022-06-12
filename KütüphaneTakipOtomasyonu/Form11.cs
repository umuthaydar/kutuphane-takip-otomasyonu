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
    public partial class HakkindaForm : Form
    {
        public HakkindaForm()
        {
            InitializeComponent();
        }

        private void Cikis_Icon_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfaForm anaSayfaForm = new AnaSayfaForm();
            anaSayfaForm.Show();
        }
    }
}
