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
    public partial class FrmUyeKayit : Form
    {
        public FrmUyeKayit()
        {
            InitializeComponent();
        }


        sqlbaglanti bgl = new sqlbaglanti();


        private void button1_Click(object sender, EventArgs e)
        {



            SqlCommand kayityap = new SqlCommand("insert into TBL_Hastalar (HastaAd, HastaSoyad, HastaTC, HastaTelefon, HastaSifre, HastaCinsiyet) values (@P1,@P2,@P3,@P4,@P5,@P6)", bgl.baglanti());

            kayityap.Parameters.AddWithValue("@P1", TxtAd.Text);
            kayityap.Parameters.AddWithValue("@P2", TxtSoyad.Text);
            kayityap.Parameters.AddWithValue("@P3", MskTc.Text);
            kayityap.Parameters.AddWithValue("@P4", MskTlf.Text);
            kayityap.Parameters.AddWithValue("@P5", TxtSifre.Text);
            kayityap.Parameters.AddWithValue("@P6", CmbCinsiyet.Text);
            kayityap.ExecuteNonQuery();

            bgl.baglanti().Close();


            MessageBox.Show("Hasta Kaydı Eklendi", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);







        }
    }
}
