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
    public partial class frmhastakayit : Form
    {
        public frmhastakayit()
        {
            InitializeComponent();
        }

        Sqlbaglantısınıfı bgl = new Sqlbaglantısınıfı();

        private void butonhastakaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Table_Hastalar (Hastaad,hastasoyad,hastatc,hastatel,hastasifre,hastacinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", texthastaad.Text);
            komut.Parameters.AddWithValue("@p2", texthastasoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktchasta.Text);
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut.Parameters.AddWithValue("@p5", hastasifre.Text);
            komut.Parameters.AddWithValue("@p6", comboBoxcinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Gerçekleşti. Şifreniz :" + hastasifre.Text ,"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
