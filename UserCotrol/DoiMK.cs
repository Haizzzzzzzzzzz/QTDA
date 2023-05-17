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
    public partial class DoiMK : UserControl
    {

        private static DoiMK _instance;
        public static DoiMK Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DoiMK();
                return _instance;
            }
        }

        SqlCommand cmd;
        String sql = "Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002";
        SqlConnection conn;
        SqlDataAdapter _adapter = new SqlDataAdapter();


        public DoiMK()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbMKmoi.Text == txbNhapLaiMk.Text)
            {
                conn = new SqlConnection(sql);
                conn.Open();
                cmd = conn.CreateCommand();

                cmd.CommandText = $"UPDATE Login set Password = '{txbMKmoi.Text}' WHERE Username = '{txbTK.Text}'";

                int x = cmd.ExecuteNonQuery();

                conn.Close();

                if (x == 1)
                {
                    MessageBox.Show("Doi mat khau thanh cong");

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
