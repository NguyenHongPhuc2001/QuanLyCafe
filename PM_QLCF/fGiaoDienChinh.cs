using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_QLCF
{
    public partial class fGiaoDienChinh : Form
    {
        public fGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            fBanHang frm = new fBanHang();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            fQuanLyNCC frm = new fQuanLyNCC();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            fQuanLySanPham frm = new fQuanLySanPham();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            fThongKe frm = new fThongKe();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void btnQuanLyLichSu_Click(object sender, EventArgs e)
        {
            fLichSuBanHang frm = new fLichSuBanHang();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có chắc muốn thoát chứ ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK) Application.Exit();
        }

        private void btnQuanLyBan_Click(object sender, EventArgs e)
        {
            fQuanLyBan frm = new fQuanLyBan();
            Hide();
            frm.ShowDialog();
            Show();
        }
    }
}
