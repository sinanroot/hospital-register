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

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TCNO;

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {

            txtTc.Text = TCNO;

            SqlCommand komut = new SqlCommand("select * from Tbl_Doktorlar where  DoktorTC=qp1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtTc.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();
                txtSifre.Text = dr[5].ToString();

            }
            bgl.baglanti().Close();




        }

        private void btnBilgiguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktorlar set = Doktor=@p1, Doktorsoyad=qp2, DoktorBrans=@p3, DoktorSifre=@p4 where DoktorTC= @p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.Parameters.AddWithValue("@5", txtTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();


            MessageBox.Show("Kayot Güncellendi!");







        }
    }
}
