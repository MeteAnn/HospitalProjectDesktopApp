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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }


        sqlbaglanti bgl = new sqlbaglanti();


        private void FrmDuyurular_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("select * from TBL_Duyuru", bgl.baglanti());
            dr.Fill(dt);    
            dataGridView1.DataSource = dt;





        }
    }
}
