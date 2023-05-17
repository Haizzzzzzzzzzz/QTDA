using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ThiCuoiKyCNPM
{
    public partial class XeVaoTheSV : Form
    {
        public XeVaoTheSV()
        {
            InitializeComponent();
            panelIcon.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdOpenfile.ShowDialog();
            string file = ofdOpenfile.FileName;
            if (string.IsNullOrEmpty(file))
            {
                return;
            }
            Image myimage = Image.FromFile(file);
            pictureBox1.Image = myimage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ofdOpenfile.ShowDialog();
            string file = ofdOpenfile.FileName;
            if (string.IsNullOrEmpty(file))
            {
                return;
            }
            Image myimage = Image.FromFile(file);
            pictureBox2.Image = myimage;
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

        SqlConnection conn;
        Random rand = new Random();
        int num = System.Environment.TickCount;
        private void button2_Click(object sender, EventArgs e)
        {


            int a = rand.Next(minValue: 1000, maxValue: 9999);
            int TT = rand.Next(minValue: 1000000, maxValue: 9999999);

            conn = new SqlConnection("Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002");
            byte[] b = CopyImageToByteArray(pictureBox1.Image);
            byte[] c = CopyImageToByteArray(pictureBox2.Image);
            conn.Open();

            SqlCommand cmd2 = new SqlCommand($"Insert into XeDap(IDXeDap) values (@IDXeDap)", conn);
            SqlCommand cmd3 = new SqlCommand($"Insert into XeMay(IDXeMay) values (@IDXeMay)", conn);

            if (rdXeDap.Checked == true)
            {

                SqlCommand cmd = new SqlCommand($"Insert into Xe_vao_The_SV (IDXeVaoTheSV, HinhAnhXe, HinhAnhBienSoXe, BienSoXe, ThoiGianXeVao, LoaiXe, MaSinhVien, IDThanhToanONL , IDXeDap) " +
                $"Values ('{a}', @HinhAnhXe, @HinhAnhBienSoXe, @BienSo, @ThoiGianVao, @LoaiXe, @MaSinhVien, @IDThanhToanONL, @IDXeDap)", conn);
                cmd.Parameters.Add("@HinhAnhXe", b);
                cmd.Parameters.Add("@HinhAnhBienSoXe", c);
                cmd.Parameters.Add("@BienSo", txbBienSo.Text);
                cmd.Parameters.Add("@ThoiGianVao", dtpThoiGianVaoTT.Value);
                cmd.Parameters.Add("@MaSinhVien", txbMaTheTu.Text);
                cmd.Parameters.Add("@IDThanhToanONL", TT);
                cmd.Parameters.Add("@LoaiXe", rdXeDap.Text.ToString());
                cmd2.Parameters.Add("@IDXeDap", a-1000);
                cmd.Parameters.Add("@IDXeDap", a-1000);
                lbidXe.Text = (a-1000).ToString();
                cmd2.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
            }

            if (rdXeMay.Checked == true)
            {
                //SqlCommand cmd = new SqlCommand($"Insert into Xe_vao_The_tu (IDXeVaoThetu, HinhAnhXe, HinhAnhBienSoXe, BienSoXe, ThoiGianXeVao, MaTheTu, LoaiXe, IDXeMay) " +
                //$"Values ('{a}','{b}','{c}', '{txbBienSo.Text}', '{dtpThoiGianVaoTT.Value}', '{txbMaTheTu.Text}', @LoaiXe, @IDXeMay)", conn);

                //cmd.Parameters.Add("@LoaiXe", rdXeMay.Text);
                //cmd3.Parameters.Add("@IDXeMay", a+1000);
                //cmd.Parameters.Add("@IDXeMay", a+1000);
                //lbidXe.Text = (a+1000).ToString();
                //cmd3.ExecuteNonQuery();
                //cmd.ExecuteNonQuery();

                SqlCommand cmd = new SqlCommand($"Insert into Xe_vao_The_SV (IDXeVaoTheSV, HinhAnhXe, HinhAnhBienSoXe, BienSoXe, ThoiGianXeVao, LoaiXe, MaSinhVien, IDThanhToanONL , IDXeMay) " +
                $"Values ('{a}', @HinhAnhXe, @HinhAnhBienSoXe, @BienSo, @ThoiGianVao, @LoaiXe, @MaSinhVien, @IDThanhToanONL, @IDXeMay)", conn);
                cmd.Parameters.Add("@HinhAnhXe", b);
                cmd.Parameters.Add("@HinhAnhBienSoXe", c);
                cmd.Parameters.Add("@BienSo", txbBienSo.Text);
                cmd.Parameters.Add("@ThoiGianVao", dtpThoiGianVaoTT.Value);
                cmd.Parameters.Add("@MaSinhVien", txbMaTheTu.Text);
                cmd.Parameters.Add("@IDThanhToanONL", TT);
                cmd.Parameters.Add("@LoaiXe", rdXeMay.Text.ToString());
                cmd3.Parameters.Add("@IDXeMay", a+1000);
                cmd.Parameters.Add("@IDXeMay", a+1000);
                lbidXe.Text = (a+1000).ToString();
                cmd3.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
            }
            txbThanhToanONL.Text = TT.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void XeVaoTheSV_Load(object sender, EventArgs e)
        {

        }
    }
}