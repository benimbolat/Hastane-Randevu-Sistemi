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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantısınıfı bgl = new Sqlbaglantısınıfı();

        

        private void linkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmhastakayit fr = new frmhastakayit();
            fr.Show();
        }

        private void butonhastagiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Table_Hastalar Where hastatc=@p1 and hastasifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", hastatcid.Text);
            komut.Parameters.AddWithValue("@p2", hastasifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FormHastaDetay fr = new FormHastaDetay();
                fr.tc = hastatcid.Text;                                  // Hasta Detay'a TC yazdırması gereken kod.
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatali giriş yaptınız tekrar deneyiniz");
            }
        }
    }
}
