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
    public partial class FormDoktorDetay : Form
    {
        public FormDoktorDetay()
        {
            InitializeComponent();
        }
        Sqlbaglantısınıfı bgl =new Sqlbaglantısınıfı();
        public string tc;
        private void FormDoktorDetay_Load(object sender, EventArgs e)
        {
            lbldoktortc.Text = tc;

            //doktorad soyad
            SqlCommand komut = new SqlCommand("Select doktorad,doktorsoyad from Table_Doktorlar where doktortc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbldoktortc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbldoktoradsoyad.Text = dr[0] + " " + dr[1];              
            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Randevular where randevudoktor='" + lbldoktoradsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        
        }

        private void butonguncelle_Click(object sender, EventArgs e)
        {
            FormDoktorBilgiDüzenleme fr = new FormDoktorBilgiDüzenleme();
            fr.tcnosu = lbldoktortc.Text;
            fr.Show();

        }

        private void butonduyurular_Click(object sender, EventArgs e)
        {
            FormDuyurular frd = new FormDuyurular();
            frd.Show();
        }

        private void vutoncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBoxdktrsikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
