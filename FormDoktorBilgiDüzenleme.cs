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
    public partial class FormDoktorBilgiDüzenleme : Form
    {
        public FormDoktorBilgiDüzenleme()
        {
            InitializeComponent();
        }
        Sqlbaglantısınıfı bgl = new Sqlbaglantısınıfı();
        public string tcnosu;
        private void butondoktorbilgiguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Table_Doktorlar set doktorad=@p1,doktorsoyad=@p2,doktorsifre=@p3,doktorbrans=@p4 where doktortc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textdoktorad.Text);
            komut.Parameters.AddWithValue("@p2", textdoktorsoyad.Text);
            komut.Parameters.AddWithValue("@p3", doktorsifretext.Text);
            komut.Parameters.AddWithValue("@p4", comboBoxbrasdoktor.Text);
            komut.Parameters.AddWithValue("@p5", msktcdoktor.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi ve Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FormDoktorBilgiDüzenleme_Load(object sender, EventArgs e)
        {
            msktcdoktor.Text = tcnosu;
            SqlCommand komut = new SqlCommand("select * from Table_Doktorlar where doktortc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktcdoktor.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textdoktorad.Text = dr[1].ToString();
                textdoktorsoyad.Text = dr[2].ToString();
                doktorsifretext.Text = dr[5].ToString();
                comboBoxbrasdoktor.Text = dr[3].ToString();
                msktcdoktor.Text = dr[4].ToString();
            }
            bgl.baglanti().Close();
          
            SqlCommand komutbrans = new SqlCommand("Select bransad From Table_Branslar", bgl.baglanti());
            SqlDataReader drbrans = komutbrans.ExecuteReader();
            while (drbrans.Read())
            {
                comboBoxbrasdoktor.Items.Add(drbrans[0]);
            }
            bgl.baglanti().Close();
        }
    }
}
