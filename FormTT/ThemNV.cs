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
    
    public partial class ThemNV : Form
    {
        public ThemNV()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        String sql = "Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002";
        SqlConnection conn;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void btnThemThongTin_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(sql);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = $"Insert into Nhan_vien(ID_NV, Ten_NV, Ngay_sinh_NV, Gioi_tinh_NV, Luong_NV, CMND, Dia_chi, Phone, ID_Ca_lam, ID_Cham_cong) " +
                $"Values ('{txbIDNV.Text}','{txbTenNV.Text}', '{dtpNgaySinh.Value}', '{CbGioiTinh.Text}', '{txbLuong.Text}', '{txbCMND.Text}', '{txbDiaChi.Text}', '{txbSDT.Text}', '{txbIDCaLam.Text}', '{txbIDChamCong.Text}')";

            int x = cmd.ExecuteNonQuery();

            conn.Close();

            if (x > 0)
            {
                MessageBox.Show("Them moi thanh cong");
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }

        private void ThemNV_Load(object sender, EventArgs e)
        {

        }
    }
}
