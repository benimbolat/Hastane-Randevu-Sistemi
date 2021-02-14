using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Randevu_Sistemi
{
    public partial class FormDoktorGiris : Form
    {
        public FormDoktorGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantısınıfı bgl = new Sqlbaglantısınıfı();
        private void butondoktorgiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Table_Doktorlar Where doktortc=@p1 and doktorsifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", doktortcid.Text);
            komut.Parameters.AddWithValue("@p2", doktorsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FormDoktorDetay fr = new FormDoktorDetay();
                fr.tc = doktortcid.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }            
            bgl.baglanti().Close();
        }
    }
}
