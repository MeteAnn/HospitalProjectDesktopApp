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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        public string Tcx;




        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTc.Text = Tcx;

            SqlCommand komut3 = new SqlCommand("Select * from TBL_Doktorlar where DoktorTC=@K1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@K1",MskTc.Text);
            SqlDataReader dr = komut3.ExecuteReader();

            while (dr.Read())
            {

                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                CmbBrans.Text = dr[3].ToString();
                TxtSifre.Text = dr[5].ToString();


            }
            bgl.baglanti().Close();



        }

        private void btnBilgileriGuncelle_Click(object sender, EventArgs e)
        {

            SqlCommand Komut1 = new SqlCommand("Update TBL_Doktorlar Set DoktorAd=@P1, DoktorSoyad=@P2, DoktorBrans=@P3,DoktorSifre=@P4 where DoktorTC=@P5",bgl.baglanti());
            Komut1.Parameters.AddWithValue("@P1",TxtAd.Text);
            Komut1.Parameters.AddWithValue("@P2", TxtSoyad.Text);
            Komut1.Parameters.AddWithValue("@P3", CmbBrans.Text);
            Komut1.Parameters.AddWithValue("@P4", TxtSifre.Text);
            Komut1.Parameters.AddWithValue("@P5", MskTc.Text);

            Komut1.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi");


      



        }
    }
}
