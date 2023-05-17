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
using System.IO;
using System.Drawing.Imaging;

namespace ThiCuoiKyCNPM.UserCotrol
{
    public partial class DanhSachMatThe : UserControl
    {
        public DanhSachMatThe()
        {
            InitializeComponent();
        }

        private static DanhSachMatThe _instance;
        public static DanhSachMatThe Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DanhSachMatThe();
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //conn = new SqlConnection("Data Source = LAPTOP-7HAVK214\\SQLEXPRESS; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002");
            //conn.Open();



            ////string query = $"SELECT HinhAnhXe, HinhAnhBienSoXe, Xe_vao_The_tu.BienSoXe, ThoiGianXeVao, IDXeDap, IDXeMay  FROM Xe_vao_The_tu where Xe_vao_The_tu.BienSoXe = '{txbMaTheTu.Text}'";

            //string query = $"SELECT *  FROM Xe_vao_The_tu ";

            //da = new SqlDataAdapter(query, conn);
            //ds = new DataSet();
            //da.Fill(ds, "Xe_vao_The_tu");
            //table = ds.Tables["Xe_vao_The_tu"];
            //dataGridView1.DataSource = table;
            ////txbMaTheTu.Text = table.Rows[0]["MaTheTu"].ToString();
            //txbBienSo.Text = table.Rows[0]["BienSoXe"].ToString();
            //dtpThoiGianVaoTT.Text = table.Rows[0]["ThoiGianXeVao"].ToString();



            //// loafd anh xe vao
            //SqlCommand Load_img_VaoTT = new SqlCommand();
            //Load_img_VaoTT = conn.CreateCommand();
            //Load_img_VaoTT.CommandText = $"Select HinhAnhBienSoXe from Xe_vao_The_tu where MaTheTu = '{txbMaTheTu.Text}'";
            //byte[] img = (byte[])Load_img_VaoTT.ExecuteScalar();
            //Image load = byteArrayToImage(img);
            //pictureBox2.Image = load;

            //Load_img_VaoTT = conn.CreateCommand();
            //Load_img_VaoTT.CommandText = $"Select HinhAnhXe from Xe_vao_The_tu where MaTheTu = '{txbMaTheTu.Text}'";
            //byte[] img1 = (byte[])Load_img_VaoTT.ExecuteScalar();
            //Image load1 = byteArrayToImage(img1);
            //pictureBox1.Image = load1;


            //SqlCommand cmd2 = new SqlCommand($"Select count(LoaiXe) FROM Xe_vao_The_tu WHERE LoaiXe = 'Xe máy' and MaTheTu = '{txbMaTheTu.Text}'", conn);
            ////SqlCommand cmd3 = new SqlCommand($"Select count(LoaiXe) FROM Xe_vao_The_tu WHERE LoaiXe = 'Xe máy'", conn);
            //int x = (int)cmd2.ExecuteScalar();
            ////int y = (int)cmd3.ExecuteScalar();

            //if (x > 0)
            //{
            //    rdXeMay.Checked = true;
            //    lbidXe.Text = table.Rows[0]["IDXeMay"].ToString();


            //}
            //else
            //{
            //    rdXeDap.Checked = true;
            //    lbidXe.Text = table.Rows[0]["IDXeDap"].ToString();

            //}

            //conn.Close();

            conn = new SqlConnection("Data Source = LAPTOP-7HAVK214\\SQLEXPRESS; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002");
            conn.Open();

            //string query = $"SELECT HinhAnhXe, HinhAnhBienSoXe, Xe_vao_The_tu.BienSoXe, ThoiGianXeVao, IDXeDap, IDXeMay  FROM Xe_vao_The_tu where Xe_vao_The_tu.BienSoXe = '{txbMaTheTu.Text}'";

            string query = $"SELECT *  FROM Xe_vao_The_tu where Xe_vao_The_tu.BienSoXe = '{txbMaTheTu.Text}'";

            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds, "Xe_vao_The_tu");
            table = ds.Tables["Xe_vao_The_tu"];
            dataGridView2.DataSource = table;
        }

        public static byte[] CopyImageToByteArray(Image theImage)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                theImage.Save(memoryStream, ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        void LoadTable()
        {
            conn = new SqlConnection("Data Source = LAPTOP-7HAVK214\\SQLEXPRESS; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002");
            conn.Open();

            //string query = $"SELECT HinhAnhXe, HinhAnhBienSoXe, Xe_vao_The_tu.BienSoXe, ThoiGianXeVao, IDXeDap, IDXeMay  FROM Xe_vao_The_tu where Xe_vao_The_tu.BienSoXe = '{txbMaTheTu.Text}'";

            string query = $"SELECT *  FROM Xe_vao_The_tu ";

            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds, "Xe_vao_The_tu");
            table = ds.Tables["Xe_vao_The_tu"];
            dataGridView2.DataSource = table;
            //txbMaTheTu.Text = table.Rows[0]["MaTheTu"].ToString();
            //txbBienSo.Text = table.Rows[0]["BienSoXe"].ToString();
            //dtpThoiGianVaoTT.Text = table.Rows[0]["ThoiGianXeVao"].ToString();

        }
        private void DanhSachMatThe_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dtpThoiGianVaoTT_ValueChanged(object sender, EventArgs e)
        {

        }

        string IDXeVaoTheTu;
        byte[] HinhAnhXe;
        byte[] HinhAnhBienSoXee;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txbMaTheTu.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            IDXeVaoTheTu = dataGridView2.Rows[i].Cells[0].Value.ToString();

            //// loafd anh xe vao
            SqlCommand Load_img_VaoTT = new SqlCommand();
            Load_img_VaoTT = conn.CreateCommand();
            Load_img_VaoTT.CommandText = $"Select HinhAnhBienSoXe from Xe_vao_The_tu where IDXeVaoTheTu = '{IDXeVaoTheTu}'";
            byte[] img = (byte[])Load_img_VaoTT.ExecuteScalar();
            Image load = byteArrayToImage(img);
            pictureBox2.Image = load;

            Load_img_VaoTT = conn.CreateCommand();
            Load_img_VaoTT.CommandText = $"Select HinhAnhXe from Xe_vao_The_tu where IDXeVaoTheTu = '{IDXeVaoTheTu}'";
            byte[] img1 = (byte[])Load_img_VaoTT.ExecuteScalar();
            Image load1 = byteArrayToImage(img1);
            pictureBox1.Image = load1;
        }
    }
}
