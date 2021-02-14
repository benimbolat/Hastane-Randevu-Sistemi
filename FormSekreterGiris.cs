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
    public partial class FormSekreterGiris : Form
    {
        public FormSekreterGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantısınıfı bgl = new Sqlbaglantısınıfı();
        private void butongirissekreter_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Table_Sekreterler where sekretertc=@p1 and sekretersifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", sekretertcid.Text);
            komut.Parameters.AddWithValue("@p2", sekretersifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FormSekreterDetay frs = new FormSekreterDetay();
                frs.tcnumarasekreter = sekretertcid.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız Lütfen Tekrar Deneyiniz", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        
        }

       
    }
}
