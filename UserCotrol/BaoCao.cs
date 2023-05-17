using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiCuoiKyCNPM.UserCotrol
{
    public partial class BaoCao : UserControl
    {
        public BaoCao()
        {
            InitializeComponent();
            groupBoxXe.Hide();
        }

        private static BaoCao _instance;
        public static BaoCao Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BaoCao();
                return _instance;
            }
        }

        SqlCommand cmd;
        String sql = "Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002";
        SqlConnection conn;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private SqlDataAdapter da;
        private DataSet ds;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        int VaoTheTu()
        {

            conn =  new SqlConnection(sql);
            conn.Open();
            SqlCommand cmd = new SqlCommand($"Select count(IDXeVaoTheTu) FROM Xe_vao_The_tu ", conn);

            int x = (int)cmd.ExecuteScalar();
            conn.Close();
            return x;
        }

        int RaTheTu()
        {
            conn =  new SqlConnection(sql);
            conn.Open ();
            SqlCommand cmd = new SqlCommand($"Select count(IDXeRaTheTu) FROM Xe_ra_The_tu ", conn);

            int x = (int)cmd.ExecuteScalar();
            conn.Close ();
            return x;
        }

        int VaoSV()
        {
            conn =  new SqlConnection(sql);
            conn.Open();
            SqlCommand cmd = new SqlCommand($"Select count(IDXeVaoTheSV) FROM Xe_vao_The_SV ", conn);

            int x = (int)cmd.ExecuteScalar();
            conn.Close();
            return x;
        }

        int RaSV()
        {
            conn =  new SqlConnection(sql);
            conn.Open ();
            SqlCommand cmd = new SqlCommand($"Select count(IDXeRaTheSV) FROM Xe_ra_The_SV ", conn);

            int x = (int)cmd.ExecuteScalar();
            conn.Close ();
            return x;
        }



        private void BaoCao_Load(object sender, EventArgs e)
        {
            button3.Text =  VaoTheTu().ToString();
            button4.Text = RaTheTu().ToString();
            button5.Text = VaoSV().ToString();
            button6.Text = RaSV().ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBoxXe.Show();
            conn =  new SqlConnection(sql);
            conn.Open();
            SqlCommand cmd = new SqlCommand($"Select count(IDXeDap) FROM Xe_vao_The_tu ", conn);

            int x = (int)cmd.ExecuteScalar();
            lbXedap.Text = x.ToString();


            SqlCommand cmd2 = new SqlCommand($"Select count(IDXeMay) FROM Xe_vao_The_tu ", conn);

            int y = (int)cmd2.ExecuteScalar();
            lbXemay.Text = y.ToString();

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxXe.Show ();
            conn =  new SqlConnection(sql);
            conn.Open();
            SqlCommand cmd = new SqlCommand($"Select count(IDXeDap) FROM Xe_vao_The_SV ", conn);

            int x = (int)cmd.ExecuteScalar();
            lbXedap.Text = x.ToString();


            SqlCommand cmd2 = new SqlCommand($"Select count(IDXeMay) FROM Xe_vao_The_SV ", conn);

            int y = (int)cmd2.ExecuteScalar();
            lbXemay.Text = y.ToString();

            conn.Close();
        }

        private void lbXeVaoTT_Click(object sender, EventArgs e)
        {
            TTXeVaoTT tTXeVaoTT = new TTXeVaoTT();
            tTXeVaoTT.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TTXeVaoTT tTXeVaoTT = new TTXeVaoTT();
            tTXeVaoTT.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TTXeRaTT a = new TTXeRaTT();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TTXeVaoSV t = new TTXeVaoSV();    
            t.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TTXeRaSV a = new TTXeRaSV();
            a.Show();
        }
    }
}
