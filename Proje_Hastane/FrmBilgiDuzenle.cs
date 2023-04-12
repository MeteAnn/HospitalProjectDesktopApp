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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TCno;

        sqlbaglanti bgl = new sqlbaglanti();

        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {

            MskTc.Text = TCno;
            
            SqlCommand komut9 = new SqlCommand("Select * From TBL_Hastalar where HastaTC=@P1", bgl.baglanti());
            komut9.Parameters.AddWithValue("@P1",MskTc.Text);
            SqlDataReader dr = komut9.ExecuteReader();

            while (dr.Read())
            {
                TxtAd.Text=dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTlf.Text = dr[4].ToString();
                TxtSifre.Text = dr[5].ToString();
                CmbCinsiyet.Text = dr[6].ToString();



            }


            bgl.baglanti().Close();

        }

        private void btnBilgileriGuncelle_Click(object sender, EventArgs e)
        {

            SqlCommand Komut10 = new SqlCommand("Update TBL_Hastalar Set HastaAd=@P1, HastaSoyad=@P2, HastaTelefon=@P4, HastaSifre=@P5, HastaCinsiyet=@P6 where HastaTC=@P7", bgl.baglanti());
            Komut10.Parameters.AddWithValue("@P1", TxtAd.Text);
            Komut10.Parameters.AddWithValue("@P2", TxtSoyad.Text);
            
            Komut10.Parameters.AddWithValue("@P4", MskTlf.Text);
            Komut10.Parameters.AddWithValue("@P5", TxtSifre.Text);
            Komut10.Parameters.AddWithValue("@P6", CmbCinsiyet.Text);
            Komut10.Parameters.AddWithValue("@P7", MskTc.Text);

            Komut10.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Bilgileriniz Güncellendi.");

        }
    }
}
