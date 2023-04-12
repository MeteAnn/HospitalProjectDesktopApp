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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();


        private void btnEkle_Click(object sender, EventArgs e)
        {

            SqlCommand komut5 = new SqlCommand("insert into TBL_Doktorlar (DoktorAd, DoktorSoyad, DoktorBrans, DoktorTC, DoktorSifre) values (@K1,@K2,@K3,@K4,@K5)", bgl.baglanti());
            komut5.Parameters.AddWithValue("@K1", txtAd.Text);
            komut5.Parameters.AddWithValue("@K2", txtSoyad.Text);
            komut5.Parameters.AddWithValue("@K3", CmbBrans.Text);
            komut5.Parameters.AddWithValue("@K4", MskTC.Text);
            komut5.Parameters.AddWithValue("@K5", txtSifre.Text);

            komut5.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Doktor Kaydı Yapıldı");


        }

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dd = new DataTable();
            SqlDataAdapter komut23 = new SqlDataAdapter("Select * from TBL_Doktorlar", bgl.baglanti());
            komut23.Fill(dd);
            dataGridView1.DataSource = dd;
            bgl.baglanti().Close();

            //Branşları Çekme
            SqlCommand bKomut = new SqlCommand("Select BransAd From TBL_Brans", bgl.baglanti());
            SqlDataReader dr1 = bKomut.ExecuteReader();
            while (dr1.Read())
            {

                CmbBrans.Items.Add(dr1[0]);

            }

            bgl.baglanti().Close();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtAd.Text=dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            SqlCommand komutSil = new SqlCommand("Delete from TBL_Doktorlar where DoktorTC=@P1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@P1",MskTC.Text);
            komutSil.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Seçtiğiniz Kayıt Silinmiştir.");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            //Güncelle

            SqlCommand Komut1 = new SqlCommand("Update TBL_Doktorlar Set DoktorAd=@P1, DoktorSoyad=@P2, DoktorBrans=@P3, DoktorSifre=@P4 where DoktorTC=@P5 ", bgl.baglanti());

            Komut1.Parameters.AddWithValue("@P1", txtAd.Text);
            Komut1.Parameters.AddWithValue("@P2", txtSoyad.Text);
            Komut1.Parameters.AddWithValue("@P3", CmbBrans.Text);
            Komut1.Parameters.AddWithValue("@P4", txtSifre.Text);
            Komut1.Parameters.AddWithValue("@P5", MskTC.Text);





            Komut1.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Güncelleme Yapıldı");


          


        }

      
    }
}
