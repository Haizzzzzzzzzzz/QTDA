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
    public partial class TaoTK : UserControl
    {
        public TaoTK()
        {
            InitializeComponent();
        }

        private static TaoTK _instance;
        public static TaoTK Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TaoTK();
                return _instance;
            }
        }

        SqlCommand cmd;
        String sql = "Data Source = LAPTOP-7HAVK214\\SQLEXPRESS; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002";
        SqlConnection conn;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataTable dt = new DataTable();

        SqlDataAdapter _adapter = new SqlDataAdapter();

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txbMKmoi.Text == txbNhapLaiMk.Text)
            {
                conn = new SqlConnection(sql);
                conn.Open();
                cmd = conn.CreateCommand();

                cmd.CommandText = $"Insert into Login(Username, Password) values ('{txbTK.Text}', '{txbNhapLaiMk.Text}')";
                int x = cmd.ExecuteNonQuery();

                conn.Close();

                if (x == 1)
                {
                    MessageBox.Show("Tao tai khoan thanh cong");

                }
                else
                {
                    MessageBox.Show("That bai");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
            }
        }
    }
}
