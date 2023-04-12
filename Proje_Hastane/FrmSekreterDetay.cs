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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();
        public string Stc;
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {

            lblTC.Text = Stc;

            SqlCommand komut12 = new SqlCommand("Select SekreterAdSoyad From TBL_Sekreter where SekreterTC=@P1 ", bgl.baglanti());
            komut12.Parameters.AddWithValue("@P1",lblTC.Text);

            SqlDataReader dr = komut12.ExecuteReader();
            while (dr.Read())
            {

                lblAdSoyad.Text = dr[0].ToString();


            }

            bgl.baglanti().Close();



            //Branş Paneli

            DataTable ddts = new DataTable();
            SqlDataAdapter komut22 = new SqlDataAdapter("Select * from TBL_Brans", bgl.baglanti());
            komut22.Fill(ddts);
            dataGridView1.DataSource = ddts;

            bgl.baglanti().Close();


            //Doktorlar 

            DataTable dd = new DataTable();
            SqlDataAdapter komut23 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar' ,DoktorBrans from TBL_Doktorlar", bgl.baglanti());
            komut23.Fill(dd);
            dataGridView2.DataSource = dd;
            bgl.baglanti().Close();


            //Branşları Çekme

            SqlCommand bransKomut = new SqlCommand("Select BransAd From TBL_Brans", bgl.baglanti());
            SqlDataReader dr1 = bransKomut.ExecuteReader();
            while (dr1.Read())
            {

                cmbBrans.Items.Add(dr1[0]);

            }

            bgl.baglanti().Close();



            //Doktorları Çekme
            SqlCommand DoktorKomut = new SqlCommand("Select DoktorAd, DoktorSoyad From TBL_Doktorlar", bgl.baglanti());
            SqlDataReader dr2 = DoktorKomut.ExecuteReader();
            while (dr2.Read())
            {

                cmbDoktor.Items.Add(dr2[0] + " " + dr2[1]);

            }

            bgl.baglanti().Close();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {


            SqlCommand komut24 = new SqlCommand("Insert into TBL_Randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) values(@R1,@R2,@R3,@R4)",bgl.baglanti());
            komut24.Parameters.AddWithValue("@R1",mskTarih.Text);
            komut24.Parameters.AddWithValue("@R2",mskSaat.Text);
            komut24.Parameters.AddWithValue("@R3",cmbBrans.Text);
            komut24.Parameters.AddWithValue("@R4",cmbDoktor.Text);
            komut24.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kaydedildi.");




           


        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            SqlCommand Komut30 = new SqlCommand("Select DoktorAd, DoktorSoyad From TBL_Doktorlar where DoktorBrans=@P1", bgl.baglanti());

            Komut30.Parameters.AddWithValue("@P1",cmbBrans.Text);
            SqlDataReader dr4 = Komut30.ExecuteReader();
          

            while (dr4.Read())
            {
                cmbDoktor.Items.Add(dr4[0] + " " + dr4[1]);

            }

            bgl.baglanti().Close();


        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into TBL_Duyuru (Duyuru) values (@D1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@D1",RchDuyuruOlustur.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Duyuru Oluşturuldu");

        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {

            FrmDoktorPaneli dp = new FrmDoktorPaneli();
            dp.Show();
           


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {



            FrmBransPaneli bp = new FrmBransPaneli();
            bp.Show();


        }

        private void btnRandevuList_Click(object sender, EventArgs e)
        {


            FrmRandevuListesi rl = new FrmRandevuListesi();
            rl.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {

       


        }
    }
}
