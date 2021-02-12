using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Randevu_Sistemi
{
    class Sqlbaglantısınıfı
    {
        public SqlConnection baglanti ()
        {
            SqlConnection baglan = new SqlConnection ("Data Source=DESKTOP-HKI8OF4;Initial Catalog=HastaneRandevuSistemi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }




    }
}
