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
    public partial class ThanhToanONL : UserControl
    {
        public ThanhToanONL()
        {
            InitializeComponent();
        }

        private static ThanhToanONL _instance;
        public static ThanhToanONL Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ThanhToanONL();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void loadTable()
        {
            conn = new SqlConnection("Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002");
            conn.Open();

            //string query = $"SELECT HinhAnhXe, HinhAnhBienSoXe, Xe_vao_The_tu.BienSoXe, ThoiGianXeVao, IDXeDap, IDXeMay  FROM Xe_vao_The_tu where Xe_vao_The_tu.BienSoXe = '{txbMaTheTu.Text}'";

            string query = $"SELECT *  FROM Xe_ra_The_SV ";

            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds, "Xe_ra_The_SV");
            table = ds.Tables["Xe_ra_The_SV"];
            dataGridView1.DataSource = table;
        }

        private void ThanhToanONL_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002");
            conn.Open();

            //string query = $"SELECT HinhAnhXe, HinhAnhBienSoXe, Xe_vao_The_tu.BienSoXe, ThoiGianXeVao, IDXeDap, IDXeMay  FROM Xe_vao_The_tu where Xe_vao_The_tu.BienSoXe = '{txbMaTheTu.Text}'";

            string query = $"SELECT *  FROM Xe_ra_The_SV  where MaSinhVien = '{txtMaSinhVien.Text}'";

            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da.Fill(ds, "Xe_ra_The_SV");
            table = ds.Tables["Xe_ra_The_SV"];
            dataGridView1.DataSource = table;

            SqlCommand cmd2 = new SqlCommand($"Select count(MaSinhVien) FROM Xe_ra_The_SV WHERE MaSinhVien = '{txtMaSinhVien.Text}' and LoaiXe = 'Xe đạp'", conn);
            SqlCommand cmd3 = new SqlCommand($"Select count(MaSinhVien) FROM Xe_ra_The_SV WHERE MaSinhVien = '{txtMaSinhVien.Text}' and LoaiXe = 'Xe máy'", conn);

            int x = (int)cmd2.ExecuteScalar();
            int y = (int)cmd3.ExecuteScalar();
            float TT;
            TT = (2000*x) + y*3000;
            if (x>0)
            {

                txbTongTien.Text = TT.ToString();
            }
            if (TT > 24000)
            {
                MessageBox.Show("Nợ xấu nợ dai dẳng không trả");
            }
        }
        string TongTien;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i  = dataGridView1.CurrentRow.Index;
            lbMaSinhVien.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            TongTien = dataGridView1.Rows[i].Cells[6].Value.ToString();

            SqlCommand cmd2 = new SqlCommand($"Select count(MaSinhVien) FROM Xe_ra_The_SV WHERE MaSinhVien = '{lbMaSinhVien.Text}' and LoaiXe = 'Xe đạp'", conn);
            SqlCommand cmd3 = new SqlCommand($"Select count(MaSinhVien) FROM Xe_ra_The_SV WHERE MaSinhVien = '{lbMaSinhVien.Text}' and LoaiXe = 'Xe máy'", conn);

            int x = (int)cmd2.ExecuteScalar();
            int y = (int)cmd3.ExecuteScalar();
            float TT;
            float k = float.Parse(TongTien);
            TT = (k*x) + y*3000;
            if (x>0)
            {
                
                txbTongTien.Text = TT.ToString();
            }
            if(TT > 24000)
            {
                MessageBox.Show("Nợ xấu nợ dai dẳng không trả");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sql);
            conn.Open();
            cmd = conn.CreateCommand();
            SqlCommand cmd2 = conn.CreateCommand();
            cmd.CommandText = $"DELETE FROM MaSinhVien WHERE MaSinhVien = '{txtMaSinhVien.Text}'";
            cmd2.CommandText = $"DELETE FROM MaSinhVien WHERE MaSinhVien = '{lbMaSinhVien.Text}'";
            int x = cmd.ExecuteNonQuery();

            conn.Close();

            if (x > 0)
            {
                MessageBox.Show("Xoa thanh cong");
                loadTable();
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }
    }
}
