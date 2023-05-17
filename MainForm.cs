using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiCuoiKyCNPM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(DoiMK.Instance))
            {
                panel1.Controls.Add(DoiMK.Instance);
                DoiMK.Instance.Dock = DockStyle.Fill;
                DoiMK.Instance.BringToFront();
            }
            else
                DoiMK.Instance.BringToFront();
        }

        private void thẻTừToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(TheTu.Instance))
            {
                panel1.Controls.Add(TheTu.Instance);
                TheTu.Instance.Dock = DockStyle.Fill;
                TheTu.Instance.BringToFront();
            }
            else
                TheTu.Instance.BringToFront();
        }

        private void thẻSinhViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserCtrol.TheSinhVien.Instance))
            {
                panel1.Controls.Add(UserCtrol.TheSinhVien.Instance);
                UserCtrol.TheSinhVien.Instance.Dock = DockStyle.Fill;
                UserCtrol.TheSinhVien.Instance.BringToFront();
            }
            else
                UserCtrol.TheSinhVien.Instance.BringToFront();
        }

        private void thẻTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!panel1.Controls.Contains(UserCotrol.XeVaoTheTu1.Instance))
            //{
            //    panel1.Controls.Add(UserCotrol.XeVaoTheTu1.Instance);
            //    UserCotrol.XeVaoTheTu1.Instance.Dock = DockStyle.Fill;
            //    UserCotrol.XeVaoTheTu1.Instance.BringToFront();
            //}
            //else
            //    UserCotrol.XeVaoTheTu1.Instance.BringToFront();

            XeVaoTheTu luuAnhCSDL = new XeVaoTheTu();
            luuAnhCSDL.Show();
        }

        private void thẻSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (!panel1.Controls.Contains(UserCotrol.XeVaoTheSinhVien.Instance))
            //{
            //    panel1.Controls.Add(UserCotrol.XeVaoTheSinhVien.Instance);
            //    UserCotrol.XeVaoTheSinhVien.Instance.Dock = DockStyle.Fill;
            //    UserCotrol.XeVaoTheSinhVien.Instance.BringToFront();
            //}
            //else
            //    UserCotrol.XeVaoTheSinhVien.Instance.BringToFront();
            XeVaoTheSV xeVaoTheSV = new XeVaoTheSV();
            xeVaoTheSV.Show();
        }

        private void thẻTừToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserCotrol.XeRaTheTu.Instance))
            {
                panel1.Controls.Add(UserCotrol.XeRaTheTu.Instance);
                UserCotrol.XeRaTheTu.Instance.Dock = DockStyle.Fill;
                UserCotrol.XeRaTheTu.Instance.BringToFront();
            }
            else
                UserCotrol.XeRaTheTu.Instance.BringToFront();
        }

        private void thẻSinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserCotrol.XeRaTheSV.Instance))
            {
                panel1.Controls.Add(UserCotrol.XeRaTheSV.Instance);
                UserCotrol.XeRaTheSV.Instance.Dock = DockStyle.Fill;
                UserCotrol.XeRaTheSV.Instance.BringToFront();
            }
            else
                UserCotrol.XeRaTheSV.Instance.BringToFront();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserCotrol.NhanVien.Instance))
            {
                panel1.Controls.Add(UserCotrol.NhanVien.Instance);
                UserCotrol.NhanVien.Instance.Dock = DockStyle.Fill;
                UserCotrol.NhanVien.Instance.BringToFront();
            }
            else
                UserCotrol.NhanVien.Instance.BringToFront();
        }

        private void danhSáchMấtThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserCotrol.DanhSachMatThe.Instance))
            {
                panel1.Controls.Add(UserCotrol.DanhSachMatThe.Instance);
                UserCotrol.DanhSachMatThe.Instance.Dock = DockStyle.Fill;
                UserCotrol.DanhSachMatThe.Instance.BringToFront();
            }
            else
                UserCotrol.DanhSachMatThe.Instance.BringToFront();
        }

        private void thanhToánOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserCotrol.ThanhToanONL.Instance))
            {
                panel1.Controls.Add(UserCotrol.ThanhToanONL.Instance);
                UserCotrol.ThanhToanONL.Instance.Dock = DockStyle.Fill;
                UserCotrol.ThanhToanONL.Instance.BringToFront();
            }
            else
                UserCotrol.ThanhToanONL.Instance.BringToFront();
        }

        private void báoCáoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserCotrol.BaoCao.Instance))
            {
                panel1.Controls.Add(UserCotrol.BaoCao.Instance);
                UserCotrol.BaoCao.Instance.Dock = DockStyle.Fill;
                UserCotrol.BaoCao.Instance.BringToFront();
            }
            else
                UserCotrol.BaoCao.Instance.BringToFront();
        }

        private void saoLưuDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserCotrol.TaoTK.Instance))
            {
                panel1.Controls.Add(UserCotrol.TaoTK.Instance);
                UserCotrol.TaoTK.Instance.Dock = DockStyle.Fill;
                UserCotrol.TaoTK.Instance.BringToFront();
            }
            else
                UserCotrol.TaoTK.Instance.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserCotrol.TrangChu.Instance))
            {
                panel1.Controls.Add(UserCotrol.TrangChu.Instance);
                UserCotrol.TrangChu.Instance.Dock = DockStyle.Fill;
                UserCotrol.TrangChu.Instance.BringToFront();
            }
            else
                UserCotrol.TrangChu.Instance.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserCotrol.TrangChu.Instance))
            {
                panel1.Controls.Add(UserCotrol.TrangChu.Instance);
                UserCotrol.TrangChu.Instance.Dock = DockStyle.Fill;
                UserCotrol.TrangChu.Instance.BringToFront();
            }
            else
                UserCotrol.TrangChu.Instance.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XeVaoTheTu luuAnhCSDL = new XeVaoTheTu();
            luuAnhCSDL.Show();

            if (!panel1.Controls.Contains(UserCotrol.XeRaTheTu.Instance))
            {
                panel1.Controls.Add(UserCotrol.XeRaTheTu.Instance);
                UserCotrol.XeRaTheTu.Instance.Dock = DockStyle.Fill;
                UserCotrol.XeRaTheTu.Instance.BringToFront();
            }
            else
                UserCotrol.XeRaTheTu.Instance.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XeVaoTheSV xeVaoTheSV = new XeVaoTheSV();
            xeVaoTheSV.Show();

            if (!panel1.Controls.Contains(UserCotrol.XeRaTheSV.Instance))
            {
                panel1.Controls.Add(UserCotrol.XeRaTheSV.Instance);
                UserCotrol.XeRaTheSV.Instance.Dock = DockStyle.Fill;
                UserCotrol.XeRaTheSV.Instance.BringToFront();
            }
            else
                UserCotrol.XeRaTheSV.Instance.BringToFront();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(TheTu.Instance))
            {
                panel1.Controls.Add(TheTu.Instance);
                TheTu.Instance.Dock = DockStyle.Fill;
                TheTu.Instance.BringToFront();
            }
            else
                TheTu.Instance.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserCtrol.TheSinhVien.Instance))
            {
                panel1.Controls.Add(UserCtrol.TheSinhVien.Instance);
                UserCtrol.TheSinhVien.Instance.Dock = DockStyle.Fill;
                UserCtrol.TheSinhVien.Instance.BringToFront();
            }
            else
                UserCtrol.TheSinhVien.Instance.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserCotrol.DanhSachMatThe.Instance))
            {
                panel1.Controls.Add(UserCotrol.DanhSachMatThe.Instance);
                UserCotrol.DanhSachMatThe.Instance.Dock = DockStyle.Fill;
                UserCotrol.DanhSachMatThe.Instance.BringToFront();
            }
            else
                UserCotrol.DanhSachMatThe.Instance.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserCotrol.BaoCao.Instance))
            {
                panel1.Controls.Add(UserCotrol.BaoCao.Instance);
                UserCotrol.BaoCao.Instance.Dock = DockStyle.Fill;
                UserCotrol.BaoCao.Instance.BringToFront();
            }
            else
                UserCotrol.BaoCao.Instance.BringToFront();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
