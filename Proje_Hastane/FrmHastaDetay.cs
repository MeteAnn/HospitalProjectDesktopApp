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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        
        public string tc;

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {

            lblTcKimlikNo.Text = tc;

            SqlCommand adsoyad = new SqlCommand("select HastaAd, HastaSoyad From TBL_Hastalar where HastaTC=@H1", bgl.baglanti());
            adsoyad.Parameters.AddWithValue("@H1",lblTcKimlikNo.Text);

            SqlDataReader dr = adsoyad.ExecuteReader();

            while (dr.Read())
            {

                lblAdSoyad.Text = dr[0] + " " + dr[1];

            }

           bgl.baglanti().Close();


            //Randevu Geçmişi

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From TBL_Randevular where HastaTC=" + tc, bgl.baglanti());
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            



            //Branşları Çekme 

            SqlCommand komut2 = new SqlCommand("Select BransAd From TBL_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {

                CmbBrans.Items.Add(dr2[0]);

            }
            
            bgl.baglanti().Close();


            //Doktorları Çekme

            SqlCommand komut3 = new SqlCommand("Select DoktorAd, DoktorSoyad From TBL_Doktorlar", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {


                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);

            }

            bgl.baglanti().Close();


            //Randevular
            DataTable dts = new DataTable();
            SqlDataAdapter das = new SqlDataAdapter("Select * From TBL_Randevular", bgl.baglanti());

            das.Fill(dts);
            dataGridView2.DataSource = dts;

            bgl.baglanti().Close();


        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {

            CmbDoktor.Items.Clear();

            SqlCommand komut7 = new SqlCommand("Select DoktorAd, DoktorSoyad From TBL_Doktorlar where DoktorBrans=@P1 ", bgl.baglanti());
            komut7.Parameters.AddWithValue("@P1",CmbBrans.Text);
            SqlDataReader dr8 = komut7.ExecuteReader();

            while (dr8.Read())
            {

                CmbDoktor.Items.Add(dr8[0] + " " + dr8[1]);

            }

            bgl.baglanti().Close();

        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_Randevular where RandevuBrans='"+CmbBrans.Text+"'" +" and RandevuDoktor='"+CmbDoktor.Text+"'",bgl.baglanti());

            da.Fill(dt);
            dataGridView2.DataSource = dt;


        }

        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmBilgiDuzenle df = new FrmBilgiDuzenle();
            df.TCno = lblTcKimlikNo.Text;
            df.Show();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            


        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtİD.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {

            SqlCommand komut1 = new SqlCommand("Update TBL_Randevular set RandevuDurum=1, HastaTC=@P1,HastaSikayet=@P2 where Randevuid=@P3",bgl.baglanti());
            komut1.Parameters.AddWithValue("@P1",lblTcKimlikNo.Text);
            komut1.Parameters.AddWithValue("@P2",RchSikayet.Text);
            komut1.Parameters.AddWithValue("@P3",txtİD.Text);
            komut1.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Randevu Alındı");



        }
    }
}
