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

namespace ThiCuoiKyCNPM
{
    public partial class TheTu : UserControl
    {
        public TheTu()
        {
            InitializeComponent();
        }

        private static TheTu _instance;
        public static TheTu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TheTu();
                return _instance;
            }
        }

        SqlCommand cmd;
        String sql = "Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002";
        SqlConnection conn;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable dt = new DataTable();
        public void loadTable()
        {
            //dgvTheTu.DataSource = null;
            //conn = new SqlConnection(sql);
            //conn.Open();
            ////SqlCommand cmd = new SqlCommand("Select MaTheTu, LoaiXe from Ma_The_Tu", conn);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(table);
            //dgvTheTu.DataSource = table;

            //conn.Close();

            //cmd = conn.CreateCommand();
            //cmd.CommandText = "Select MaTheTu, LoaiXe from Ma_The_Tu";
            //adapter.SelectCommand = cmd;
            //adapter.Fill(table);
            //dgvTheTu.DataSource = table;
            //dgvTheTu.DefaultCellStyle.Font = new Font("Tahoma", 12);

            try
            {
                List<DoiTuong.TheTu> list = new List<DoiTuong.TheTu>();
                //Buoc 1 khơi tạo chuỗi kết nối

                //string SQL = "Data Source = LAPTOP-7HAVK214\\SQLEXPRESS; Initial Catalog = TestConnection; User ID  = sa; Password = haihip2002";

                // B2: Tạo kết nối tới cơ sở dữ liệu
                SqlConnection conn = new SqlConnection(sql);


                //B3: Mở kết nối cơ sở dữ liệu
                conn.Open();

                // B?1 tao cau lenh truy van
                SqlCommand cmd = new SqlCommand("Select MaTheTu, LoaiXe from Ma_The_Tu", conn);

                // B?3 Đọc dữ liệu trả về bơi truy vấn => truy vấn select trả về nhiều nên chúng ta sử dụng excutereader
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    DoiTuong.TheTu cd = new DoiTuong.TheTu();
                    cd.MaTheTu1 = (string)rd["MaTheTu"];
                    cd.LoaiXe1 = (string)rd["LoaiXe"];
                    list.Add(cd);
                }

                // b4 dong ket noi
                conn.Close();

                // hien thi du lieu len bang
                dgvTheTu.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TheTu_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void btnThemTT_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sql);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = $"Insert into Ma_the_tu(MaTheTu, LoaiXe) Values ('{txbMaTheTu.Text}',N'{txbLoaiXe.Text}')";

            int x = cmd.ExecuteNonQuery();

            conn.Close();

            if (x > 0)
            {
                MessageBox.Show("Them moi thanh cong");
                dt.Columns.Clear();
                dt.Rows.Clear();
                dgvTheTu.DataSource = dt;

                loadTable();
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void btnXoaTT_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sql);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = $"DELETE FROM Ma_the_tu WHERE MaTheTu = '{txbMaTheTu.Text}'";
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

        private void dgvTheTu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvTheTu.CurrentRow.Index;
            txbMaTheTu.Text = dgvTheTu.Rows[i].Cells[0].Value.ToString();
            txbLoaiXe.Text = dgvTheTu.Rows[i].Cells[1].Value.ToString();
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sql);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = $"UPDATE Ma_the_tu SET LoaiXe = N'{txbLoaiXe.Text}' WHERE MaTheTu = '{txbMaTheTu.Text}'";
            int x = cmd.ExecuteNonQuery();

            conn.Close();

            if (x > 0)
            {
                MessageBox.Show("Sua thanh cong");
                loadTable();
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }
    }
}
