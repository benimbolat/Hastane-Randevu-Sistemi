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
    public partial class FormHastaBilgiDüzenle : Form
    {
        public FormHastaBilgiDüzenle()
        {
            InitializeComponent();
        }
        Sqlbaglantısınıfı bgl = new Sqlbaglantısınıfı();

        public string tcno;
        private void FormHastaBilgiDüzenle_Load(object sender, EventArgs e)
        {
            msktchasta.Text = tcno;
            SqlCommand komut = new SqlCommand("select * from Table_Hastalar where Hastatc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktchasta.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                texthastaad.Text = dr[1].ToString();
                texthastasoyad.Text = dr[2].ToString();
                msktchasta.Text = dr[3].ToString();
                msktelefon.Text = dr[4].ToString();
                hastasifre.Text = dr[5].ToString();
                comboBoxcinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();

        }

        private void butonhastabilgiguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Table_Hastalar set hastaad=@p1,hastasoyad=@p2,hastatel=@p3,hastasifre=@p4,hastacinsiyet=@p5 where hastatc=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", texthastaad.Text);
            komut.Parameters.AddWithValue("@p2", texthastasoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktelefon.Text);
            komut.Parameters.AddWithValue("@p4", hastasifre.Text);
            komut.Parameters.AddWithValue("@p5", comboBoxcinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", msktchasta.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi ve Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
