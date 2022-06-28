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
    public partial class fQuanLySanPham : Form
    {
        DanhMucRepository repoDM = new DanhMucRepository();
        ThucDonRepository repoTD = new ThucDonRepository();
        public fQuanLySanPham()
        {
            InitializeComponent();
            BindingDanhMuc(repoDM.GetAllDanhMuc());
            BindingComboBoxDanhMuc();
            BindingThucDon(repoTD.GetAllThucDon());
        }

        #region method
        void BindingDanhMuc(List<DanhMuc> listdm)
        {
            dgvDanhMuc.Rows.Clear();
            int id = 1;
            foreach (var item in listdm)
            {
                int index = dgvDanhMuc.Rows.Add();
                dgvDanhMuc.Rows[index].Cells[0].Value = item.IDDanhMuc;
                dgvDanhMuc.Rows[index].Cells[1].Value = id++;
                dgvDanhMuc.Rows[index].Cells[2].Value = item.TenDM;
            }
        }
        void BindingComboBoxDanhMuc()
        {
            List<DanhMuc> listdm = repoDM.GetAllDanhMuc();
            cbTenDanhMuc.DataSource = listdm;
            cbTenDanhMuc.DisplayMember = "TenDM";
            cbTenDanhMuc.ValueMember = "IDDanhMuc";
        }

        void BindingThucDon(List<ThucDon> listtd)
        {
            dgvThucDon.Rows.Clear();
            int id = 1;
            foreach(var item in listtd)
            {
                int index = dgvThucDon.Rows.Add();
                dgvThucDon.Rows[index].Cells[0].Value = item.IDMonAn;
                dgvThucDon.Rows[index].Cells[1].Value = item.IDDanhMuc;
                dgvThucDon.Rows[index].Cells[2].Value = id++;
                dgvThucDon.Rows[index].Cells[3].Value = item.DanhMuc.TenDM;
                dgvThucDon.Rows[index].Cells[4].Value = item.TenMonAn;
                dgvThucDon.Rows[index].Cells[5].Value = item.DonGia;
            }
        }

        DanhMuc GetDanhMuc()
        {
            DanhMuc dm = new DanhMuc();
            dm.TenDM = txtTenDanhMuc.Text;
            return dm;
        }

        ThucDon GetThucDon()
        {
            ThucDon td = new ThucDon();
            td.TenMonAn = txtTenMonAn.Text;
            td.DonGia = int.Parse(txtDonGia.Text);
            td.IDDanhMuc = int.Parse(cbTenDanhMuc.SelectedValue.ToString());
            return td;
        }
        #endregion



        #region events DanhMuc
        private void btnThemDM_Click(object sender, EventArgs e)
        {
            try
            {
                int check = 0;
                DanhMuc dm = GetDanhMuc();
                List<DanhMuc> listdm = repoDM.GetAllDanhMuc();
                foreach(var item in listdm)
                {
                    if(dm.TenDM == item.TenDM)
                    {
                        check = 1;
                        break;
                    }
                }
                DanhMuc db = repoDM.GetDanhMuc(dm.IDDanhMuc);
                if (db == null)
                {
                    if (check == 0)
                    {


                        if (MessageBox.Show("Bạn có chắc muốn thêm chứ?", "Trả lời", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {                          
                            repoDM.InsertUpdate(dm);
                            MessageBox.Show("Thêm thành công !");
                            BindingDanhMuc(repoDM.GetAllDanhMuc());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Danh mục đã tồn tại !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            try
            {
                DanhMuc dm = GetDanhMuc();
                dm.IDDanhMuc = int.Parse(dgvDanhMuc.CurrentRow.Cells[0].Value.ToString());
                DanhMuc db = repoDM.GetDanhMuc(dm.IDDanhMuc);
                if (db != null)
                {
                    if (MessageBox.Show("Bạn có chắc muốn sửa chứ?", "Trả lời", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        repoDM.InsertUpdate(dm);
                        MessageBox.Show("Sửa thành công !");
                        BindingDanhMuc(repoDM.GetAllDanhMuc());
                    }                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            try
            {
                int iddm = int.Parse(dgvDanhMuc.CurrentRow.Cells[0].Value.ToString());
                if (MessageBox.Show("Bạn có chắc muốn xóa chứ?", "Trả lời", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    repoDM.DeleteDM(iddm);
                    BindingDanhMuc(repoDM.GetAllDanhMuc());
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiemDM_Click(object sender, EventArgs e)
        {
            List<DanhMuc> listdm = repoDM.GetAllDanhMuc();
            var listdmtk = listdm.Where(p => (p is DanhMuc) &&
            (p as DanhMuc).TenDM.ToLower().Contains(txtTenDanhMuc.Text.ToLower())).ToList();
            if (listdmtk.Count > 0)
            {
                BindingDanhMuc(listdmtk);
            }
            else
            {
                MessageBox.Show("Không tìm thấy danh mục !");
            }
        }

        private void dgvDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenDanhMuc.Text = dgvDanhMuc.CurrentRow.Cells[2].Value.ToString();
        }
        #endregion



        #region events ThucDon
        private void btnThemTD_Click(object sender, EventArgs e)
        {
            try
            {
                int check = 0;
                ThucDon td = GetThucDon();
                List<ThucDon> listtd = repoTD.GetAllThucDon();
                foreach(var item in listtd)
                {
                    if(td.TenMonAn == item.TenMonAn)
                    {
                        check = 1;
                        break;
                    }
                }
                ThucDon db = repoTD.GetThucDon(td.IDMonAn);
                if (db == null)
                {
                    if (check == 0)
                    {
                        if (MessageBox.Show("Bạn có chắc muốn thêm chứ?", "Trả lời", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            repoTD.InsertUpdate(td);
                            MessageBox.Show("Thêm thành công !");
                            BindingThucDon(repoTD.GetAllThucDon());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Món ăn đã tồn tại !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSuaTD_Click(object sender, EventArgs e)
        {
            try
            {
                ThucDon td = GetThucDon();
                td.IDMonAn = int.Parse(dgvThucDon.CurrentRow.Cells[0].Value.ToString());
                ThucDon db = repoTD.GetThucDon(td.IDMonAn);
                if (db != null)
                {
                    if (MessageBox.Show("Bạn có chắc muốn sửa chứ?", "Trả lời", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    { 
                        repoTD.InsertUpdate(td);
                        MessageBox.Show("Sửa thành công !");
                        BindingThucDon(repoTD.GetAllThucDon());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoaTD_Click(object sender, EventArgs e)
        {
            try
            {
                int idtd = int.Parse(dgvThucDon.CurrentRow.Cells[0].Value.ToString());
                ThucDon td = repoTD.GetThucDon(idtd);
                if (td != null)
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa chứ?", "Trả lời", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        repoTD.DeleteTD(idtd);
                        MessageBox.Show("Xóa thành công !");
                        BindingThucDon(repoTD.GetAllThucDon());
                    }                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTimKiemTD_Click(object sender, EventArgs e)
        {
            try
            {
                List<ThucDon> listtd = repoTD.GetAllThucDon();
                var listtdtk = listtd.Where(p => (p is ThucDon) &&
                (p as ThucDon).TenMonAn.ToLower().Contains(txtTenMonAn.Text.ToLower())).ToList();
                if (listtdtk != null)
                {
                    BindingThucDon(listtdtk);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy món ăn !");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenMonAn.Text = dgvThucDon.CurrentRow.Cells[4].Value.ToString();
            txtDonGia.Text = dgvThucDon.CurrentRow.Cells[5].Value.ToString();
            cbTenDanhMuc.Text = dgvThucDon.CurrentRow.Cells["DanhMucTD"].Value.ToString();
        }
        #endregion


        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            List<ThucDon> listtd = repoTD.GetAllThucDon();
            Strategy.SortedList thucDonList = new Strategy.SortedList();
            thucDonList.SetSortStrategy(new Strategy.SortName());
            BindingThucDon(thucDonList.Sort(listtd));
        }

        private void btnSortPrice_Click(object sender, EventArgs e)
        {
            List<ThucDon> listtd = repoTD.GetAllThucDon();
            Strategy.SortedList thucDonList = new Strategy.SortedList();
            thucDonList.SetSortStrategy(new Strategy.SortPrice());
            BindingThucDon(thucDonList.Sort(listtd));

        }

        private void lblQuanLySanPham_Click(object sender, EventArgs e)
        {

        }
    }
}
