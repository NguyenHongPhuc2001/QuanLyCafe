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
    public partial class fLichSuBanHang : Form
    {
        HoaDonRepository repoHD = new HoaDonRepository();
        CTHDRepository repoCTHD = new CTHDRepository();
        public fLichSuBanHang()
        {
            InitializeComponent();
        }


        #region methods
        void BindingHoaDon(List<HoaDon> listhoadon)
        {
            dgvLSHoaDon.Rows.Clear();
            int id = 1;
            foreach(var item in listhoadon)
            {
                int index = dgvLSHoaDon.Rows.Add();
                dgvLSHoaDon.Rows[index].Cells[0].Value = item.IDHoaDon;
                dgvLSHoaDon.Rows[index].Cells[1].Value = id++;
                dgvLSHoaDon.Rows[index].Cells[2].Value = "Bàn " + item.Ban.SoBan;
                dgvLSHoaDon.Rows[index].Cells[3].Value = item.NgayLapHD;
                dgvLSHoaDon.Rows[index].Cells[4].Value = item.TongTien;
            }
        }

        void BindingCTHoaDon(List<ChiTietHoaDon> listcthd)
        {
            dgvLSCTHoaDon.Rows.Clear();
            int id = 1;
            foreach(var item in listcthd)
            {
                int index = dgvLSCTHoaDon.Rows.Add();
                dgvLSCTHoaDon.Rows[index].Cells[0].Value = item.IDChiTietHoaDon;
                dgvLSCTHoaDon.Rows[index].Cells[1].Value = id++;
                dgvLSCTHoaDon.Rows[index].Cells[2].Value = item.ThucDon.TenMonAn;
                dgvLSCTHoaDon.Rows[index].Cells[3].Value = item.SoLuong;
                dgvLSCTHoaDon.Rows[index].Cells[4].Value = item.ThucDon.DonGia;
            }
        }
        #endregion





        #region events
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime date1 = mcChonNgay.SelectionStart;
            DateTime date2 = mcChonNgay.SelectionEnd;

            List<HoaDon> listhd = repoHD.GetAllHoaDon();
            List<HoaDon> newlist = new List<HoaDon>();
            int flag = 0;
            foreach(var item in listhd)
            {
                if(item.NgayLapHD >= date1)
                {
                    if (item.NgayLapHD <= date2)
                    {
                        newlist.Add(item);
                        flag++;
                    }
                }
            }
            if(flag != 0)
                BindingHoaDon(newlist);
            else
            {
                MessageBox.Show("Ngày đó quán không mở ^_^ !");
            }
        }
        

        private void dgvLSHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idhd = int.Parse(dgvLSHoaDon.CurrentRow.Cells[0].Value.ToString());

            List<ChiTietHoaDon> listcthd = repoCTHD.GetListCTHDByIDHoaDon(idhd);
            BindingCTHoaDon(listcthd);

        }
        #endregion
    }
}
