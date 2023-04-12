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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }


        sqlbaglanti bgl = new sqlbaglanti();


        private void button1_Click(object sender, EventArgs e)
        {

          

            SqlCommand hastagiris = new SqlCommand("Select * From TBL_Hastalar where HastaTC=@K1 and HastaSifre=@K2", bgl.baglanti());
            hastagiris.Parameters.AddWithValue("@K1", GrsTcMsk.Text);
            hastagiris.Parameters.AddWithValue("@K2", GrsTxtBox.Text);
            SqlDataReader hgs = hastagiris.ExecuteReader();

            if (hgs.Read())
            {

                FrmHastaDetay hd = new FrmHastaDetay();
                hd.tc = GrsTcMsk.Text;
                hd.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Hatalı TC veya ŞİFRE Tekrar Deneyiniz");
            }




            bgl.baglanti().Close();

            


        }

        private void FrmGirisler_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmUyeKayit uk = new FrmUyeKayit();
            uk.Show();
            

        }
    }
}
