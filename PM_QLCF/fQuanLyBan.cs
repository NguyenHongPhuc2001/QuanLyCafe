using PM_QLCF.Model;
using PM_QLCF.Model.Repository;
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
    public partial class fQuanLyBan : Form
    {
        BanRepository repoBan = new BanRepository();
        public fQuanLyBan()
        {
            InitializeComponent();
            BindingBan(repoBan.GetAllBan());
        }

        #region methods
        void BindingBan(List<Ban> listban)
        {
            dgvQLBan.Rows.Clear();
            int id = 1;
            foreach(var item in listban)
            {
                int index = dgvQLBan.Rows.Add();
                dgvQLBan.Rows[index].Cells[0].Value = item.IDBan;
                dgvQLBan.Rows[index].Cells[1].Value = id++;
                dgvQLBan.Rows[index].Cells[2].Value = item.SoBan;
                dgvQLBan.Rows[index].Cells[3].Value = item.TrangThai;
            }
        }
        Ban GetBan()
        {
            Ban ban = new Ban();
            ban.SoBan = int.Parse(txtSoBan.Text);
            ban.TrangThai = cbTrangThai.SelectedItem.ToString();
            return ban;
        }
        #endregion




        #region events
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {                
                int check = 0;
                Ban ban = GetBan();
                List<Ban> listban = repoBan.GetAllBan();
                foreach(var item in listban)
                {
                    if(ban.SoBan == item.SoBan)
                    {
                        check = 1;
                        break;
                    }
                }
                
                Ban db = repoBan.GetBan(ban.IDBan);
      
                if(db == null)
                {
                    if (check == 0)
                    {
                        if (MessageBox.Show("Bạn có chắc muốn thêm chứ?", "Trả lời", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            repoBan.InsertUpdate(ban);
                            MessageBox.Show("Thêm thành công !");
                        }
                        BindingBan(repoBan.GetAllBan());
                    }
                    else
                    {
                        MessageBox.Show("Bàn đã tồn tại !");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Ban ban = GetBan();
                ban.IDBan = int.Parse(dgvQLBan.CurrentRow.Cells[0].Value.ToString());
                Ban db = repoBan.GetBan(ban.IDBan);
                if (db != null)
                {
                    if (MessageBox.Show("Bạn có chắc muốn sửa chứ?", "Trả lời", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        repoBan.InsertUpdate(ban);
                        MessageBox.Show("Sửa thành công !");
                    }
                    BindingBan(repoBan.GetAllBan());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idban = int.Parse(dgvQLBan.CurrentRow.Cells[0].Value.ToString());
            Ban ban = repoBan.GetBan(idban);
            if(ban != null)
            {
                if (MessageBox.Show("Bạn có chắc xóa chứ?", "Trả lời", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    repoBan.DeleteBan(idban);
                    MessageBox.Show("Xóa thành công !");
                }
                BindingBan(repoBan.GetAllBan());
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Ban> listban = repoBan.GetAllBan();
                var listbantk = listban.Where(p => (p is Ban) &&
                (p as Ban).SoBan.ToString().ToLower().Contains(txtSoBan.Text.ToLower())).ToList();
                if (listbantk.Count > 0)
                {
                    BindingBan(listbantk);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bàn !");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvQLBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoBan.Text = dgvQLBan.CurrentRow.Cells[2].Value.ToString();
            cbTrangThai.Text = dgvQLBan.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
