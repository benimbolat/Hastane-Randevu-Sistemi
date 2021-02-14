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
    public partial class FormDoktorEkleme : Form
    {
        public FormDoktorEkleme()
        {
            InitializeComponent();
        }
        Sqlbaglantısınıfı bgl = new Sqlbaglantısınıfı();
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Table_Doktorlar where Doktortc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",maskedTextBoxtcdoktor);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme işlemi başarılı.");
        }

        private void FormDoktorEkleme_Load(object sender, EventArgs e)
        {
            //Doktor Ekleme 
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Table_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            bgl.baglanti().Close();
            //Doktor Brans
            SqlCommand komutbrans = new SqlCommand("Select bransad From Table_Branslar", bgl.baglanti());
            SqlDataReader drbrans = komutbrans.ExecuteReader();
            while (drbrans.Read())
            {
                comboBoxbrans.Items.Add(drbrans[0]);
            }
            bgl.baglanti().Close();

        }

        private void buttondoktorekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Doktorlar (Doktorad, doktorsoyad, doktorbrans, doktortc, doktorsifre) values (@d1, @d2, @d3, @d4, @d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", textDoktorad.Text);
            komut.Parameters.AddWithValue("@d2", textdoktorsoyad.Text);
            komut.Parameters.AddWithValue("@d3", comboBoxbrans.Text);
            komut.Parameters.AddWithValue("@d4", maskedTextBoxtcdoktor.Text);
            komut.Parameters.AddWithValue("@d5", textBoxsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklen", "Bilgi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textDoktorad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textdoktorsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBoxbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBoxtcdoktor.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBoxsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();


        }

        private void buttondoktorguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Table_Doktorlar set doktorad=@p1, doktorsoyad=@p2, doktorbrans=@p3, doktorsifre=@p5 where doktortc=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textDoktorad.Text);
            komut.Parameters.AddWithValue("@p2", textdoktorsoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxbrans.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxtcdoktor.Text);
            komut.Parameters.AddWithValue("@p5", textBoxsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi ve Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
