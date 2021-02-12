using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Randevu_Sistemi
{
    public partial class FormGirisPenceresi : Form
    {
        public FormGirisPenceresi()
        {
            InitializeComponent();
        }

        private void butonhasta_Click(object sender, EventArgs e)
        {
            FrmHastaGiris fr = new FrmHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void butondoktor_Click(object sender, EventArgs e)
        {
            FormDoktorGiris fr = new FormDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void butonsekreter_Click(object sender, EventArgs e)
        {
            FormSekreterGiris fr = new FormSekreterGiris();
            fr.Show();
            this.Hide();
        }
    }
}
