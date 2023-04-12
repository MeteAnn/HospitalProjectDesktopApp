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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }


        sqlbaglanti bgl = new sqlbaglanti();    

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {
           



        }

        private void GrsBtnHasta_Click(object sender, EventArgs e)
        {
            SqlCommand komut11 = new SqlCommand("Select * From TBL_Sekreter where SekreterTC=@P1 and SekreterSifre=@P2", bgl.baglanti());
            komut11.Parameters.AddWithValue("@P1", GrsTcMsk.Text);
            komut11.Parameters.AddWithValue("@P2", GrsTxtBox.Text);
            SqlDataReader da = komut11.ExecuteReader();

            if (da.Read())
            {

                FrmSekreterDetay sd = new FrmSekreterDetay();
                sd.Stc = GrsTcMsk.Text;
                sd.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlış TC veya ŞİFRE");
            }

            bgl.baglanti().Close();
        }
    }
}
