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

namespace ThiCuoiKyCNPM.UserCotrol
{
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private static NhanVien _instance;
        public static NhanVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NhanVien();
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
            conn = new SqlConnection(sql);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Nhan_vien", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);
            dgvNhanVien.DataSource = table;
            conn.Close();

            //cmd = conn.CreateCommand();
            //cmd.CommandText = "Select * from Nhan_vien";
            //adapter.SelectCommand = cmd;
            //adapter.Fill(table);
            //dgvNhanVien.DataSource = table;
            //dgvNhanVien.DefaultCellStyle.Font = new Font("Tahoma", 12);

            //try
            //{
            //    List<DoiTuong.NhanVien> list = new List<DoiTuong.NhanVien>();

            //    SqlConnection conn  = new SqlConnection(sql);

            //    conn.Open();

            //    SqlCommand cmd = new SqlCommand("Select * from Nhan_vien", conn);

            //    SqlDataReader rd = cmd.ExecuteReader();
            //    while (rd.Read())
            //    {
            //        DoiTuong.NhanVien cd = new DoiTuong.NhanVien();
            //        cd.ID_NV1 = (string)rd["ID_NV"];
            //        cd.Ten_NV1 = (string)rd["Ten_NV"];
            //        cd.Ngay_sinh_NV1 = (DateTime)rd["Ngay_sinh_NV"];
            //        cd.Gioi_tinh_NV1 = (string)rd["Gioi_tinh_NV"];
            //        cd.Luong_NV1= (float)rd["Luong_NV"];
            //        cd.CMND1 = (int)rd["CMND "];
            //        cd.Dia_chi1 = (string)rd["Dia_chi"];
            //        cd.Phone1 = (int)rd["Phone"];
            //        cd.ID_Ca_lam1 = (string)rd["ID_Ca_lam"];
            //        cd.ID_Cham_cong1 = (string)rd["ID_Cham_cong"];

            //        list.Add(cd);
            //    }
            //    conn.Close();

            //    // hien thi du lieu len bang
            //    dgvNhanVien.DataSource = list;


        //}
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sql);
            conn.Open();

            
            cmd = conn.CreateCommand();
            cmd.CommandText = $"Insert into Nhan_vien(ID_NV, Ten_NV, Ngay_sinh_NV, Gioi_tinh_NV, Luong_NV, CMND, Dia_chi, Phone, ID_Ca_lam, ID_Cham_cong) " +
                $"Values ('{txbIDNV.Text}',N'{txbTenNV.Text}', '{dtpNgaySinh.Value}', N'{CbGioiTinh.Text}', '{txbLuong.Text}', '{txbCMND.Text}', N'{txbDiaChi.Text}', '{txbSDT.Text}', '{txbIDCaLam.Text}', '{txbIDChamCong.Text}')";

            int x = cmd.ExecuteNonQuery();

            conn.Close();

            if (x > 0)
            {
                MessageBox.Show("Them moi thanh cong");
                loadTable();
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void btnThemThongTin_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(sql);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = $"DELETE FROM NhanVien WHERE ID_NV = '{txbIDNV.Text}'";
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

        private void button3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sql);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = $"UPDATE Nhan_vien SET Ten_NV = '{txbTenNV.Text}', Ngay_sinh_NV = '{dtpNgaySinh.Value}', Gioi_tinh_NV = '{CbGioiTinh.Text}', Luong_NV = '{txbLuong.Text}', CMND = '{txbCMND.Text}', " +
                $" Dia_chi = '{txbDiaChi.Text}', Phone = '{txbSDT.Text}', ID_Ca_lam = '{txbIDCaLam.Text}', ID_Cham_cong = '{txbIDChamCong.Text}' WHERE ID_NV = '{txbIDNV.Text}'";
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

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNhanVien.CurrentRow.Index;
            txbIDNV.Text = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txbTenNV.Text = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            CbGioiTinh.Text = dgvNhanVien.Rows[i].Cells[3].Value.ToString();
            txbLuong.Text = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            txbCMND.Text = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            txbDiaChi.Text = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            txbSDT.Text = dgvNhanVien.Rows[i].Cells[7].Value.ToString();
            txbIDCaLam.Text = dgvNhanVien.Rows[i].Cells[8].Value.ToString();
            txbIDChamCong.Text = dgvNhanVien.Rows[i].Cells[9].Value.ToString();
        }
    }
}

