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

namespace ThiCuoiKyCNPM.UserCtrol
{
    public partial class TheSinhVien : UserControl
    {
        public TheSinhVien()
        {
            InitializeComponent();
        }

        private static TheSinhVien _instance;
        public static TheSinhVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TheSinhVien();
                return _instance;
            }
        }

        SqlCommand cmd;
        String sql = "Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002";
        SqlConnection conn;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public void loadTable()
        {
            conn = new SqlConnection(sql);
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select MaSinhVien, TenSinhVien, LopHoc, KhoaHoc, SDT, DiaChi from MaSinhVien";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dgvTheSinhVien.DataSource = table;
        }

        private void TheSinhVien_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
