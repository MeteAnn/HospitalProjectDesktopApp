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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        public string dtc;


            private void FrmDoktorDetay_Load(object sender, EventArgs e)
            {



             
                lblTc.Text = dtc;

                SqlCommand komut6 = new SqlCommand("Select DoktorAd,DoktorSoyad From TBL_Doktorlar where DoktorTC=@K1", bgl.baglanti());
                komut6.Parameters.AddWithValue("@K1",lblTc.Text);

                SqlDataReader dr3 = komut6.ExecuteReader();

                while (dr3.Read())
                {


                    LblAdSoyad.Text = dr3[0] + " " + dr3[1];
                    
                    

                }
            
                bgl.baglanti().Close();


               

                //Randevuları Çekme

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_Randevular where RandevuDoktor='"+LblAdSoyad.Text+"'",bgl.baglanti());

                da.Fill(dt);

                 dataGridView1.DataSource = dt;

                bgl.baglanti().Close();
            

            }

        private void BtnDuyuru_Click(object sender, EventArgs e)
        {

            FrmDuyurular dy = new FrmDuyurular();
            dy.Show();


        }



        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {

            FrmDoktorBilgiDuzenle dr = new FrmDoktorBilgiDuzenle();
            dr.Tcx = lblTc.Text;
            dr.Show();
            


        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           



        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {



            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();




        }
    }
}
