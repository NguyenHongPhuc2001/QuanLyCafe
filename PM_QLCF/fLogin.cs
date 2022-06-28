using PM_QLCF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PM_QLCF.Model.Repository;

namespace PM_QLCF
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoanRepository repo = new TaiKhoanRepository();
            List<TaiKhoan> listtk = repo.GetAllTaiKhoan();
            TaiKhoan tk = new TaiKhoan();
            TaiKhoan tk1 = new TaiKhoan();
            tk.Username = txtUsername.Text;
            tk.Password = txtPassword.Text;
            /*if (Singleton.SingletonLogin.GetInstance(tk).TaiKhoan())
            {
                
            }*/
            tk1 = Singleton.SingletonLogin.GetInstance(tk).TaiKhoan();
            if (tk1 != null)
            {
                fGiaoDienChinh frm = new fGiaoDienChinh();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng ! Vui lòng nhập lại !");
                txtUsername.Refresh();
                txtPassword.Refresh();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn có chắc muốn thoát chứ ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK) Application.Exit();
        }
    }
}
