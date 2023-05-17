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
    public partial class XeRaTheTu : UserControl
    {
        public XeRaTheTu()
        {
            InitializeComponent();
            panelIcon.Hide();
        }

        private static XeRaTheTu _instance;
        public static XeRaTheTu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new XeRaTheTu();
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

        private void XeRaTheTu_Load(object sender, EventArgs e)
        {

        }

        private void dtpThoiGianVaoTT_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbidXe_Click(object sender, EventArgs e)
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
            picLRCamera2.Image = myimage;
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
            picLVCamera1.Image = myimage;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnChuXeVao_Click(object sender, EventArgs e)
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
            picLVCamera2.Image = myimage;
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

            SqlCommand cmd = new SqlCommand($"Insert into Xe_ra_The_tu (IDXeRaThetu, HinhAnhXe, HinhAnhBienSoXe, BienSoXe, ThoiGianRa, MaTheTu, LoaiXe, GiaTien) " +
               $"Values (@IDXeRaThetu, @HinhAnhXe, @HinhAnhBienSoXe, @BienSoXe, @ThoiGianRa, @MaTheTu, @LoaiXe, @GiaTien)", conn);

            


            cmd.Parameters.Add("@IDXeRaTheTu", a);
            cmd.Parameters.Add("@HinhAnhXe", b);
            cmd.Parameters.Add("@HinhAnhBienSoXe", c);

            string query = $"SELECT Xe_vao_The_tu.BienSoXe, Xe_vao_The_tu.MaTheTu FROM Xe_vao_The_tu, Xe_ra_The_tu where Xe_vao_The_tu.MaTheTu = '{txbMaTheTu.Text}'";

            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds, "Xe_vao_The_tu");
            table = ds.Tables["Xe_vao_The_tu"];
            dataGridView1.DataSource = table;
            txbBienSo.Text = table.Rows[0]["BienSoXe"].ToString();
            txbMaTheTu.Text = table.Rows[0]["MaTheTu"].ToString();
            dtpThoiGianVaoTT.Value = DateTime.Now;

            // loafd anh xe vao
            SqlCommand Load_img_VaoTT = new SqlCommand();
            Load_img_VaoTT = conn.CreateCommand();
            Load_img_VaoTT.CommandText = $"Select HinhAnhBienSoXe from Xe_vao_The_tu where MaTheTu = '{txbMaTheTu.Text}'";
            byte[] img = (byte[])Load_img_VaoTT.ExecuteScalar();
            Image load = byteArrayToImage(img);
            picLVCamera2.Image = load;

            Load_img_VaoTT = conn.CreateCommand();
            Load_img_VaoTT.CommandText = $"Select HinhAnhXe from Xe_vao_The_tu where MaTheTu = '{txbMaTheTu.Text}'";
            byte[] img1 = (byte[])Load_img_VaoTT.ExecuteScalar();
            Image load1 = byteArrayToImage(img1);
            picLVCamera1.Image = load1;

            
           
            cmd.Parameters.Add("@MaTheTu", txbMaTheTu.Text);
            cmd.Parameters.Add("ThoiGianRa", dtpThoiGianVaoTT.Value);
            cmd.Parameters.Add("@BienSoXe", txbBienSo.Text);



            SqlCommand cmd2 = new SqlCommand($"Select count(LoaiXe) FROM Xe_vao_The_tu WHERE LoaiXe = 'Xe máy'", conn);
            //SqlCommand cmd3 = new SqlCommand($"Select count(LoaiXe) FROM Xe_vao_The_tu WHERE LoaiXe = 'Xe máy'", conn);
            int x = (int)cmd2.ExecuteScalar();
            //int y = (int)cmd3.ExecuteScalar();

            if (x > 0)
            {
                txbGiatien.Text = 3000.ToString();
                rdXeMay.Checked = true;
                cmd.Parameters.Add("@LoaiXe", "Xe máy");
                cmd.Parameters.Add("@GiaTien", txbGiatien.Text);
                

            }
            else
            {
                txbGiatien.Text = 2000.ToString();
                rdXeDap.Checked = true;
                cmd.Parameters.Add("@LoaiXe", "Xe đạp");
                cmd.Parameters.Add("@GiaTien", txbGiatien.Text);

            }
            cmd.ExecuteNonQuery();
            lbidXe.Text = (a-1000).ToString();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int GiaTienGui = 0;
            try
            {
                conn = new SqlConnection("Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002");
                byte[] b = CopyImageToByteArray(picLRCamera1.Image);
                byte[] c = CopyImageToByteArray(picLRCamera2.Image);
                conn.Open();

                int a = random.Next(minValue: 1000, maxValue: 9999);
                SqlCommand cmd = new SqlCommand($"Insert into Xe_ra_The_tu (IDXeRaThetu, HinhAnhXe, HinhAnhBienSoXe, BienSoXe, ThoiGianRa, MaTheTu, LoaiXe, GiaTien, IDXeVaoTheTu) " +
                $"Values (@IDXeRaThetu, @HinhAnhXe, @HinhAnhBienSoXe, @BienSoXe, @ThoiGianRa, @MaTheTu, @LoaiXe, @GiaTien, @IDXeVaoTheTu)", conn);

                cmd.Parameters.Add("@IDXeRaTheTu", a);
                cmd.Parameters.Add("@HinhAnhXe", b);
                cmd.Parameters.Add("@HinhAnhBienSoXe", c);

                string query = "SELECT Xe_vao_The_tu.IDXeVaoTheTu, Xe_vao_The_tu.BienSoXe, Xe_vao_The_tu.MaTheTu FROM Xe_vao_The_tu, Xe_ra_The_tu where (convert(varbinary,Xe_vao_The_tu.HinhAnhXe)) = (convert(varbinary,Xe_ra_The_tu.HinhAnhXe)) and (convert(varbinary,Xe_vao_The_tu.HinhAnhBienSoXe)) = (convert(varbinary,Xe_ra_The_tu.HinhAnhBienSoXe))";




                SqlCommand cmd2 = new SqlCommand($"Select count(LoaiXe) FROM Xe_vao_The_tu WHERE LoaiXe = 'Xe đạp'", conn);

                int x = (int)cmd2.ExecuteScalar();


                cmd.Parameters.Add("@GiaTien", 2000);
                cmd.Parameters.Add("@LoaiXe", rdXeDap.Text);
                cmd.Parameters.Add("@MaTheTu", txbMaTheTu.Text);
                cmd.Parameters.Add("ThoiGianRa", dtpThoiGianVaoTT.Value);
                cmd.Parameters.Add("@BienSoXe", txbBienSo.Text);
                cmd.Parameters.Add("@IDXeVaoTheTu", 0.ToString());
                cmd.ExecuteNonQuery();

                if (x > 0)
                {


                    txbGiatien.Text = 2000.ToString();
                    rdXeDap.Checked = true;

                    da = new SqlDataAdapter(query, conn);
                    ds = new DataSet();
                    da.Fill(ds, "Xe_vao_The_tu");
                    table = ds.Tables["Xe_vao_The_tu"];
                    dataGridView1.DataSource = table;
                    string z = table.Rows[0]["IDXeVaoTheTu"].ToString();
                    txbBienSo.Text = table.Rows[0]["BienSoXe"].ToString();
                    txbMaTheTu.Text = table.Rows[0]["MaTheTu"].ToString();
                    dtpThoiGianVaoTT.Value = DateTime.Now;


                }
                else
                {
                    txbGiatien.Text = 3000.ToString();
                    rdXeMay.Checked = true;
                    //cmd.Parameters.Add("@IDXeRaTheTu", a);
                    //cmd.Parameters.Add("@HinhAnhXe", b);
                    //cmd.Parameters.Add("@HinhAnhBienSoXe", c);
                    //cmd.Parameters.Add("@LoaiXe", rdXeDap.Text);
                    //cmd.Parameters.Add("@MaTheTu", txbMaTheTu.Text);
                    //cmd.Parameters.Add("ThoiGianRa", dtpThoiGianVaoTT.Value);
                    //cmd.Parameters.Add("@BienSoXe", txbBienSo.Text
                    da = new SqlDataAdapter(query, conn);
                    ds = new DataSet();
                    da.Fill(ds, "Xe_vao_The_tu");
                    table = ds.Tables["Xe_vao_The_tu"];
                    dataGridView1.DataSource = table;
                    string z = table.Rows[0]["IDXeVaoTheTu"].ToString();
                    txbBienSo.Text = table.Rows[0]["BienSoXe"].ToString();
                    txbMaTheTu.Text = table.Rows[0]["MaTheTu"].ToString();
                    dtpThoiGianVaoTT.Value = DateTime.Now;

                }

                lbidXe.Text = (a-1000).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void txbMaTheTu_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }
