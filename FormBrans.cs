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
    public partial class FormBrans : Form
    {
        public FormBrans()
        {
            InitializeComponent();
        }
        Sqlbaglantısınıfı bgl = new Sqlbaglantısınıfı();
        private void FormBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Table_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonbransekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Branslar (BransAd) Values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", textbransad.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("İşlem başarılı");
        }

        private void buttonbransguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Table_Branslar set Bransad=@b1 where bransid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", textbransad.Text);
            komut.Parameters.AddWithValue("@p2", textbransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("İşlem başarılı");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textbransid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textbransad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void buttonbranssil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Table_Branslar where bransid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textbransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme işlemi başarılı.");
        }
    }
}
