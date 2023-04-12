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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();    



        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter komut = new SqlDataAdapter("Select * From TBL_Brans ",bgl.baglanti());
            komut.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti();


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Brans Ekle

            SqlCommand komut1 = new SqlCommand("insert into TBL_Brans (BransAd) values (@P1)",bgl.baglanti());
            komut1.Parameters.AddWithValue("@P1",txtBrans.Text);
            komut1.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Branş Eklenmiştir.");







        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            int secilens = dataGridView1.SelectedCells[0].RowIndex;

            txtBransid.Text = dataGridView1.Rows[secilens].Cells[0].Value.ToString();
            txtBrans.Text = dataGridView1.Rows[secilens].Cells[1].Value.ToString();



        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            SqlCommand komut2 = new SqlCommand("Delete From TBL_Brans where Branid=@P1",bgl.baglanti());
            komut2.Parameters.AddWithValue("@P1",txtBransid.Text);
            komut2.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Kayıt Silindi");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            SqlCommand kmt32 = new SqlCommand("Update TBL_Brans set BransAd=@K1 where Branid=@K2", bgl.baglanti());
            kmt32.Parameters.AddWithValue("@K1",txtBrans.Text);
            kmt32.Parameters.AddWithValue("@K2", txtBransid.Text);

            kmt32.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Kayıtlar Güncellenmiştir.");

        }
    }
}
