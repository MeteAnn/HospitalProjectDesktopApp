using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public class sqlbaglanti
    {


        public SqlConnection  baglanti()
        {

            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-C6NAGE9\\SQLEXPRESS;Initial Catalog=Hastane_Proje;Integrated Security=True");
            baglan.Open();
            return baglan; 



        }






    }
}
