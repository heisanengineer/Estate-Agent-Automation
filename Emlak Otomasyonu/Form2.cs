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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnKayitekle_Click(object sender, EventArgs e)
        {
            Form3 frmKayitekle = new Form3();
            frmKayitekle.Show();
            this.Hide();
        }

        private void btnKayitguncelle_Click(object sender, EventArgs e)
        {
            Form3 frmKayitekle = new Form3();
            frmKayitekle.Show();
            this.Hide();
            
            
        }
    }
}
