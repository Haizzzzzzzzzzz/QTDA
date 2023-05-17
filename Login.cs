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
    public partial class Login : Form
    {
        
        SqlCommand cmd;
        String sql = "Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002";

        public Login()
        {
            InitializeComponent();
            
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(sql);
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT COUNT(*) FROM Login WHERE Username = '{txbTK.Text}' and Password = '{txbMK.Text}'";

            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            if (count > 0)
            {
                MessageBox.Show("Dang Nhap thanh cong");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("That bai");
            }
        }
    }
}
// hello im a good boy

