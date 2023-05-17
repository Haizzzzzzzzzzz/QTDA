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
    public partial class TrangChu : UserControl
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private static TrangChu _instance;
        public static TrangChu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TrangChu();
                return _instance;
            }
        }

        SqlCommand cmd;
        String sql = "Data Source = localhost; Initial Catalog = Bai_thi_CNPM; User ID  = sa; Password = haihip2002";
        SqlConnection conn;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        //    MainForm frm = new MainForm();
        //    frm.panel1
        //    if (!panel1.Controls.Contains(TheTu.Instance))
        //    {
        //        panel1.Controls.Add(TheTu.Instance);
        //        TheTu.Instance.Dock = DockStyle.Fill;
        //        TheTu.Instance.BringToFront();
        //    }
        //    else
        //        TheTu.Instance.BringToFront();
        }
    }
}
