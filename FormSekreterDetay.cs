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
    public partial class FormSekreterDetay : Form
    {
        public FormSekreterDetay()
        {
            InitializeComponent();
        }

      
        Sqlbaglantısınıfı bgl = new Sqlbaglantısınıfı();
        public string tcnumarasekreter;
        private void FormSekreterDetay_Load(object sender, EventArgs e)
        {
            lblsekretertc.Text = tcnumarasekreter;

            //AD Soyad ekleme

            SqlCommand komut = new SqlCommand("Select sekreteradsoyad From Table_Sekreterler where sekretertc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblsekretertc.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                lblsekreteradsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branslar
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            bgl.baglanti().Close();                //Genel Bağlantı Kapaması (yukarıda veya aşşağıda olması önemsiz. Parantez içinde olması yeterli.)

            //Doktorları listeye aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (doktorad + ' ' + doktorsoyad) as 'Doktorlar',doktorbrans From Table_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            bgl.baglanti().Close();

            //Combobox'a Brasnları aktarma
            SqlCommand komutbrans = new SqlCommand("Select bransad From Table_Branslar", bgl.baglanti());
            SqlDataReader drbrans = komutbrans.ExecuteReader();
            while (drbrans.Read())
            {
                comboBoxbrans.Items.Add(drbrans[0]);
            }
            bgl.baglanti().Close();
        }

        private void buttonrandevukaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Table_Randevular (randevutarih,randevusaat,randevubrans,randevudoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", maskedTextBoxtarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", maskedTextBoxsaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", comboBoxbrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", comboBoxdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBoxbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobox'a doktor çekme
            comboBoxdoktor.Items.Clear();
            SqlCommand komutkaydet = new SqlCommand("select doktorad,doktorsoyad From Table_Doktorlar where doktorbrans=@sart1", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@sart1", comboBoxbrans.Text);
            SqlDataReader dr = komutkaydet.ExecuteReader();
            while (dr.Read())
            {
                comboBoxdoktor.Items.Add(dr[0] + " " +dr[1] );
            }
            bgl.baglanti().Close();
        }

        private void buttonduyuruolustur_Click(object sender, EventArgs e)
        {
            SqlCommand duyurukaydet = new SqlCommand("insert into Table_Duyurular (duyuru) values (@duyuru)", bgl.baglanti());
            duyurukaydet.Parameters.AddWithValue("@duyuru", richduyuru.Text);
            duyurukaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru kaydedildi.", "Başarılı");

        }

        private void buttondoktorpaneli_Click(object sender, EventArgs e)
        {
            FormDoktorEkleme fr = new FormDoktorEkleme();
            fr.Show();
        }

        private void buttonbranspaneli_Click(object sender, EventArgs e)
        {
            FormBrans fr = new FormBrans();
            fr.Show();
        }

        private void buttonrandevulistesi_Click(object sender, EventArgs e)
        {
            FormRandevuListesi fr = new FormRandevuListesi();
            fr.Show();
        }

        private void buttonrandevuguncelle_Click(object sender, EventArgs e)
        {
        }
    }
}
