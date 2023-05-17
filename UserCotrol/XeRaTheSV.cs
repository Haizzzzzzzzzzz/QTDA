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
    public partial class XeRaTheSV : UserControl
    {
        public XeRaTheSV()
        {
            InitializeComponent();
            panelIcon.Hide();
        }

        private static XeRaTheSV _instance;
        public static XeRaTheSV Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new XeRaTheSV();
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

        private void btnChuXeRa_Click(object sender, EventArgs e)
        {
            ofdOpenfile.ShowDialog();
            string file = ofdOpenfile.FileName;
            if (string.IsNullOrEmpty(file))
            {
                return;
            }
            Image myimage = Image.FromFile(file);
            picLRCamera1.Image = myimage;
        }

        private void btnBienSoRa_Click(object sender, EventArgs e)
        {
            ofdOpenfile.ShowDialog();
            string file = ofdOpenfile.FileName;
            if (string.IsNullOrEmpty(file))
            {
                return;
            }
            Image myimage = Image.FromFile(file);
            picLRCamera2.Image = myimage;
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


        Random random = new Random();
        int num = System.Environment.TickCount;

        private void btnXeRa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002");
            byte[] b = CopyImageToByteArray(picLRCamera1.Image);
            byte[] c = CopyImageToByteArray(picLRCamera2.Image);
            int a = random.Next(minValue: 1000, maxValue: 9999);
            conn.Open();

            SqlCommand cmd = new SqlCommand($"Insert into Xe_ra_The_SV (IDXeRaTheSV, HinhAnhXe, HinhAnhBienSoXe, BienSoXe, ThoiGianRa, LoaiXe, GiaTien, MaSinhVien, IDThanhToanONL, IDXeVaoTheSV ) " +
               $"Values (@IDXeRaTheSV, @HinhAnhXe, @HinhAnhBienSoXe, @BienSoXe, @ThoiGianRa, @LoaiXe, @GiaTien, @MaSinhVien, @IDThanhToanONL, @IDXeVaoTheSV)", conn);



            cmd.Parameters.Add("@IDXeRaTheSV", a);
            cmd.Parameters.Add("@HinhAnhXe", b);
            cmd.Parameters.Add("@HinhAnhBienSoXe", c);

            string query = $"SELECT Xe_vao_The_SV.BienSoXe, Xe_vao_The_SV.MaSinhVien, Xe_vao_The_SV.ThoiGianXeVao ,Xe_vao_The_SV.IDThanhToanONL, Xe_vao_The_SV.IDXeVaoTheSV FROM Xe_vao_The_SV" +
                $" where Xe_vao_The_SV.MaSinhVien = '{txbMaTheSV.Text}' ORDER BY ThoiGianXeVao DESC";

            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds, "Xe_vao_The_SV");
            table = ds.Tables["Xe_vao_The_SV"];
            dataGridView1.DataSource = table;
            txbBienSo.Text = table.Rows[0]["BienSoXe"].ToString();
            txbMaTheSV.Text = table.Rows[0]["MaSinhVien"].ToString();
            txbIDThanhToanONL.Text = table.Rows[0]["IDThanhToanONL"].ToString();
            string z = table.Rows[0]["IDXeVaoTheSV"].ToString();
            dtpThoiGianVaoTT.Value = DateTime.Now;

            // loafd anh xe vao
            SqlCommand Load_img_VaoTT = new SqlCommand();
            Load_img_VaoTT = conn.CreateCommand();
            Load_img_VaoTT.CommandText = $"Select HinhAnhBienSoXe from Xe_vao_The_SV where IDThanhToanONL = '{txbIDThanhToanONL.Text}'";
            byte[] img = (byte[])Load_img_VaoTT.ExecuteScalar();
            Image load = byteArrayToImage(img);
            picLVCamera2.Image = load;

            Load_img_VaoTT = conn.CreateCommand();
            Load_img_VaoTT.CommandText = $"Select HinhAnhXe from Xe_vao_The_SV where IDThanhToanONL = '{txbIDThanhToanONL.Text}'";
            byte[] img1 = (byte[])Load_img_VaoTT.ExecuteScalar();
            Image load1 = byteArrayToImage(img1);
            picLVCamera1.Image = load1;

            
            cmd.Parameters.Add("@MaSinhVien", txbMaTheSV.Text);
            cmd.Parameters.Add("ThoiGianRa", dtpThoiGianVaoTT.Value);
            cmd.Parameters.Add("@BienSoXe", txbBienSo.Text);
            cmd.Parameters.Add("@IDThanhToanONL", txbIDThanhToanONL.Text);
            cmd.Parameters.Add("@IDXeVaoTheSV", z);

           

            SqlCommand cmd2 = new SqlCommand($"Select count(LoaiXe) FROM Xe_vao_The_SV WHERE LoaiXe = 'Xe máy'", conn);

            int x = (int)cmd2.ExecuteScalar();

            if (x > 0)
            {
                txbGiatien.Text = 3000.ToString();
                rdXeMay.Checked = true;
                cmd.Parameters.Add("@GiaTien", 3000);
                cmd.Parameters.Add("@LoaiXe", rdXeMay.Text);
            }
            else
            {
                txbGiatien.Text = 2000.ToString();
                rdXeDap.Checked = true;
                cmd.Parameters.Add("@GiaTien", 2000);
                cmd.Parameters.Add("@LoaiXe", rdXeDap.Text);
            }
            cmd.ExecuteNonQuery();
            lbidXe.Text = (a-1000).ToString();
        }

        private void XeRaTheSV_Load(object sender, EventArgs e)
        {

        }
    }
}
