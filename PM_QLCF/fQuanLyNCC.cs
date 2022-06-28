using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PM_QLCF.Model;
using PM_QLCF.Model.Repository;

namespace PM_QLCF
{
    public partial class fQuanLyNCC : Form
    {
        NhaCungCapRepository repoNCC = new NhaCungCapRepository();
        public fQuanLyNCC()
        {
            InitializeComponent();
            BindingNCC(repoNCC.GetAllNCC());
        }


        #region method
        void BindingNCC(List<NhaCungCap> listNCC)
        {
            dgvQLNCC.Rows.Clear();
            int id = 1;
            foreach (var item in listNCC)
            {
                int index = dgvQLNCC.Rows.Add();
                dgvQLNCC.Rows[index].Cells[0].Value = item.IDNhaCungCap;
                dgvQLNCC.Rows[index].Cells[1].Value = id++;
                dgvQLNCC.Rows[index].Cells[2].Value = item.TenNCC;
                dgvQLNCC.Rows[index].Cells[3].Value = item.DiaChi;
                dgvQLNCC.Rows[index].Cells[4].Value = item.SDT;
            }
        }


        NhaCungCap GetNhaCungCap()
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.TenNCC = txtTenNCC.Text;
            ncc.DiaChi = txtDiaChi.Text;
            ncc.SDT = txtSDT.Text;
            return ncc;
        }
        #endregion



        #region events
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int check = 0;
                NhaCungCap ncc = GetNhaCungCap();
                List<NhaCungCap> listncc = repoNCC.GetAllNCC();
                foreach(var item in listncc)
                {
                    if (ncc.TenNCC == item.TenNCC)
                    {
                        check = 1;
                        break;
                    }

                }
                NhaCungCap db = repoNCC.GetNhaCungCap(ncc.IDNhaCungCap);
                if (db == null)
                {
                    if (check == 0)
                    {
                        if (MessageBox.Show("Bạn có chắc muốn thêm chứ?", "Trả lời", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            repoNCC.InsertUpdateNCC(ncc);
                            MessageBox.Show("Thêm thành công !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã tồn tại nhà cung cấp !");
                    }
                }

                BindingNCC(repoNCC.GetAllNCC());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap ncc = GetNhaCungCap();
                ncc.IDNhaCungCap = int.Parse(dgvQLNCC.CurrentRow.Cells[0].Value.ToString());
                NhaCungCap db = repoNCC.GetNhaCungCap(ncc.IDNhaCungCap);
                if (MessageBox.Show("Bạn có chắc muốn sửa chứ?", "Trả lời", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (db != null)
                    {
                        repoNCC.InsertUpdateNCC(ncc);
                        MessageBox.Show("Sửa thành công !");
                    }
                    BindingNCC(repoNCC.GetAllNCC());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int idncc = int.Parse(dgvQLNCC.CurrentRow.Cells[0].Value.ToString());
                if (MessageBox.Show("Bạn có chắc muốn xóa chứ?", "Trả lời", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    repoNCC.DeleteNCC(idncc);
                    MessageBox.Show("Xóa thành công !");
                }
                BindingNCC(repoNCC.GetAllNCC());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                List<NhaCungCap> listNCC = repoNCC.GetAllNCC();
                var listNCCTK = listNCC.Where(p => (p is NhaCungCap) &&
                (p as NhaCungCap).TenNCC.ToLower().Contains(txtTenNCC.Text.ToLower())).ToList();
                if (listNCCTK.Count > 0)
                {
                    BindingNCC(listNCCTK);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp !");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void dgvQLNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idncc = int.Parse(dgvQLNCC.CurrentRow.Cells[0].Value.ToString());
                NhaCungCap ncc = repoNCC.GetNhaCungCap(idncc);
                txtTenNCC.Text = ncc.TenNCC.ToString();
                txtDiaChi.Text = ncc.DiaChi.ToString();
                txtSDT.Text = ncc.SDT.ToString();
            }
        }
        #endregion

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
