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
    public partial class FormHastaDetay : Form
    {
        public FormHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;                                               // Hasta Detay'a TC yazdırması gereken kod.

        Sqlbaglantısınıfı bgl = new Sqlbaglantısınıfı();                   // SQL bağlantısını çağırdım.

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void FormHastaDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;                                            // Hasta Detay'a TC yazdırması gereken kod.

            SqlCommand komut = new SqlCommand("Select hastaad,hastasoyad From Table_Hastalar Where hastatc=@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
           
            //Randevu Geçmiş
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter ("Select * From Table_Randevular where hastatc="+tc ,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt ;      

            bgl.baglanti().Close();                                     //Genel Bağlantı Kapaması (yukarıda veya aşşağıda olması önemsiz. Parantez içinde olması yeterli.)

            //Branşları SQLden çekme
            SqlCommand komutbrans = new SqlCommand("Select bransad From Table_Branslar", bgl.baglanti());

            SqlDataReader dr2 = komutbrans.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxbranş.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();                                     //Genel Bağlantı Kapaması (yukarıda veya aşşağıda olması önemsiz. Parantez içinde olması yeterli.)

        }

        private void comboBoxbranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Doktor Listesi Combobox
            comboBoxdoktor.Items.Clear();
            SqlCommand komutdoktor = new SqlCommand("Select doktorad,doktorsoyad From Table_Doktorlar where Doktorbrans=@p1", bgl.baglanti());
            komutdoktor.Parameters.AddWithValue("@p1", comboBoxbranş.Text);
            SqlDataReader dr3 = komutdoktor.ExecuteReader();
            while (dr3.Read())
            {
                comboBoxdoktor.Items.Add(dr3[0] + " " + dr3[1]);

            }
            bgl.baglanti().Close();                                     //Genel Bağlantı Kapaması (yukarıda veya aşşağıda olması önemsiz. Parantez içinde olması yeterli.)

        }

        private void comboBoxdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Randevular where randevubrans='"+comboBoxbranş.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;


        }

        private void linkLabelbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaBilgiDüzenle fr = new FormHastaBilgiDüzenle();
            fr.Show();
        }
    }
}
