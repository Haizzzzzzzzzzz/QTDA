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
    public partial class XeVaoTheTu : UserControl
    {
        public XeVaoTheTu()
        {
            InitializeComponent();
            panelIcon.Hide();
        }

        private static XeVaoTheTu _instance;
        public static XeVaoTheTu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new XeVaoTheTu();
                return _instance;
            }
        }

        SqlCommand cmd;
        String sql = "Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002";
        SqlConnection conn;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void XeVaoTheTu_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        Random random = new Random();
        int num = System.Environment.TickCount;

        
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = random.Next(minValue: 1000, maxValue: 9999);

                conn = new SqlConnection("Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002");
                byte[] b = CopyImageToByteArray(pictureBox1.Image);
                byte[] c = CopyImageToByteArray(pictureBox2.Image);
                conn.Open();
                SqlCommand cmd2 = new SqlCommand($"Insert into XeDap(IDXeDap) values (@IDXeDap)", conn);
                SqlCommand cmd3 = new SqlCommand($"Insert into XeMay(IDXeMay) values (@IDXeMay)", conn);


                if (rdXeDap.Checked == true)
                {
                    SqlCommand cmd = new SqlCommand($"Insert into Xe_vao_The_tu (IDXeVaoThetu, HinhAnhXe, HinhAnhBienSoXe, BienSoXe, ThoiGianXeVao, MaTheTu, LoaiXe, IDXeDap) " +
                    $"Values ('{a}','{b}','{c}', '{txbBienSo.Text}', '{dtpThoiGianVaoTT.Value}', '{txbMaTheTu.Text}', @LoaiXe, @IDXeDap)", conn);

                    cmd.Parameters.Add("@LoaiXe", rdXeDap.Text.ToString());
                    cmd2.Parameters.Add("@IDXeDap", a-1000);
                    cmd.Parameters.Add("@IDXeDap", a-1000);
                    lbidXe.Text = (a-1000).ToString();
                    cmd2.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                }

                if (rdXeMay.Checked == true)
                {
                    SqlCommand cmd = new SqlCommand($"Insert into Xe_vao_The_tu (IDXeVaoThetu, HinhAnhXe, HinhAnhBienSoXe, BienSoXe, ThoiGianXeVao, MaTheTu, LoaiXe, IDXeMay) " +
                    $"Values ('{a}','{b}','{c}', '{txbBienSo.Text}', '{dtpThoiGianVaoTT.Value}', '{txbMaTheTu.Text}', @LoaiXe, @IDXeMay)", conn);

                    cmd.Parameters.Add("@LoaiXe", rdXeMay.Text);
                    cmd3.Parameters.Add("@IDXeMay", a+1000);
                    cmd.Parameters.Add("@IDXeMay", a+1000);
                    lbidXe.Text = (a+1000).ToString();
                    cmd3.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();

                }
                panelIcon.Show();

                //cmd.Parameters.Add("@IDXeVaoTheSV", a);
                //cmd.Parameters.Add("@HinhAnhXe", b);
                //cmd.Parameters.Add("@HinhAnhBienSoXe", c);
                //cmd.Parameters.Add("@BienSoXe", txbBienSo.Text);
                //cmd.Parameters.Add("@ThoiGianXeVao", dtpThoiGianVaoTT.Value);
                //cmd.Parameters.Add("@MaTheTu", txbMaTheTu.Text

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void lbicon_Click(object sender, EventArgs e)
        {

        }
    }
}
