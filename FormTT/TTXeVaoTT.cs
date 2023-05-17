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

namespace ThiCuoiKyCNPM
{
    public partial class TTXeVaoTT : Form
    {
        public TTXeVaoTT()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        String sql = "Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002";
        SqlConnection conn;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private SqlDataAdapter da;
        private DataSet ds;

        void loadTable()
        {
            conn = new SqlConnection(sql);
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from Xe_vao_The_tu";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void TTXeVaoTT_Load(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}
