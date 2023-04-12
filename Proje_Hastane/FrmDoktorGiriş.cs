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

namespace Proje_Hastane
{
    public partial class FrmDoktorGiriş : Form
    {
        public FrmDoktorGiriş()
        {
            InitializeComponent();
        }


        sqlbaglanti bgl = new sqlbaglanti();


        private void GrsBtnHasta_Click(object sender, EventArgs e)
        {

            SqlCommand dgrs = new SqlCommand("select * From TBL_Doktorlar where DoktorTC=@C1 and DoktorSifre=@C2 ", bgl.baglanti());
            dgrs.Parameters.AddWithValue("@C1", GrsTcMsk.Text);
            dgrs.Parameters.AddWithValue("@C2", GrsTxtBox.Text);
            SqlDataReader dr = dgrs.ExecuteReader();

            
            if (dr.Read())
            {


                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.dtc = GrsTcMsk.Text; 
                fr.Show();
                this.Hide();

            }

            else
            {

                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");

            }

            bgl.baglanti().Close();


        }

        private void FrmDoktorGiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
