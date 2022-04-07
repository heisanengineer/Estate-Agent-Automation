using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Emlak_Otomasyonu
{
    public partial class frmKullanicigiris : Form
    {
        public frmKullanicigiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciadi.Text == "emlakadmin" && txtSifre.Text == "admin1234")
            {
                Form2 frmAnamenu = new Form2();
                frmAnamenu.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frmAnamenu = new Form2();
            frmAnamenu.Show();
            this.Hide();
        }
    }
}
