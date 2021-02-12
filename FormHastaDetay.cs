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
            lbltc.Text = tc;                                            // Hasta Detay'a TC yazdırması gereken kod.

            SqlCommand komut = new SqlCommand("Select hastaad,hastasoyad From Table_Hastalar Where hastatc=@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
           
            //Randevu Geçmiş
        
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter ("Select * Frome Table_Randevular Where hastatc="+tc ,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt ;      
        
        }

    
    
    
    }
}
