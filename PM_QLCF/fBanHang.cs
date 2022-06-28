using PM_QLCF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PM_QLCF.Model.Repository;

namespace PM_QLCF
{
    public partial class fBanHang : Form
    {
        DanhMucRepository repoDM = new DanhMucRepository();
        HoaDonRepository repoHD = new HoaDonRepository();
        CTHDRepository repoCTHD = new CTHDRepository();
        BanRepository repoBan = new BanRepository();
        ThucDonRepository repoTD = new ThucDonRepository();

        public fBanHang()
        {
            InitializeComponent();
            LoadBan();
            BindingCBDanhMuc();
            BindingCBChuyenBan();
        }



        #region methods
        void LoadBan()
        {
            flpBan.Controls.Clear();
            List<Ban> listban = repoBan.GetAllBan();

            foreach (var item in listban)
            {
                Button btn = new Button() { Width = Ban.ChieuRong, Height = Ban.ChieuDai };
                btn.Text = "Bàn " + item.SoBan + Environment.NewLine + item.TrangThai;
                FontFamily fontfamily = new FontFamily("Times New Roman");
                btn.Font = new Font(fontfamily, 18, FontStyle.Regular, GraphicsUnit.Pixel);
                btn.Click += btn_Click;
                btn.Tag = item;


                switch (item.TrangThai)
                {
                    case "Đặt Trước":
                        btn.BackColor = Color.Brown;
                        break;
                    case "Đang Sửa":
                        btn.BackColor = Color.OrangeRed;
                        break;
                    case "Có Người":
                        btn.BackColor = Color.GreenYellow;
                        break;
                    default:
                        btn.BackColor = Color.LightBlue;
                        break;
                }
                flpBan.Controls.Add(btn);
            }
        }

        void ShowBill(int idban)
        {
            lsvHoaDon.Items.Clear();
            txtTongTien.Clear();
            Ban ban = repoBan.GetBan(idban);
            HoaDon hd = repoHD.GetHoaDonByIDBanTrangThai(idban, 0);
            if(ban.TrangThai=="Đang Sửa") {
                btnFix.Text = "Hoàn Thành";
                btnThemMon.Enabled = false;
            } else
            {
                btnThemMon.Enabled = true;
                if (ban.TrangThai == "Đặt Trước")
                {
                    btnDT.Text = "Huỷ Đặt";
                }
                else { btnDT.Text = "Đặt Trước"; }
                btnFix.Text = "Sửa Chữa";
                if (hd != null)
                {
                    if (hd.TrangThai == 0)
                    {
                        List<ChiTietHoaDon> listcthd = repoCTHD.GetListCTHDByIDHoaDon(hd.IDHoaDon);
                        double tt = 0;
                        foreach (var item in listcthd)
                        {
                            int idtd = item.IDMonAn.Value;
                            ThucDon thucdon = repoTD.GetThucDon(idtd);
                            int idhd = item.IDHoaDon.Value;
                            HoaDon hoadon = repoHD.GetHoaDonByIDHD(idhd);
                            ListViewItem lsvitem = new ListViewItem(thucdon.TenMonAn);                           
                            lsvitem.SubItems.Add(thucdon.DonGia.ToString());
                            lsvitem.SubItems.Add(item.SoLuong.ToString());
                            hoadon.TongTien = item.SoLuong * thucdon.DonGia;
                            lsvitem.SubItems.Add(hoadon.TongTien.ToString());

                            tt = tt + double.Parse(hoadon.TongTien.ToString());

                            lsvHoaDon.Items.Add(lsvitem);
                        }
                        //CultureInfo culture = new CultureInfo("vi-VN");

                        txtTongTien.Text = tt.ToString();
                    }
                }
            }
        }

        void BindingCBDanhMuc()
        {
            List<DanhMuc> listdm = repoDM.GetAllDanhMuc();
            cmbDanhMuc.DataSource = listdm;
            cmbDanhMuc.DisplayMember = "TenDM";
        }

        void BindingCBThucDon(int iddm)
        {
            List<ThucDon> listtd = repoTD.GetThucDonByIDDanhMuc(iddm);
            cmbThucDon.DataSource = listtd;
            cmbThucDon.DisplayMember = "TenMonAn";
            cmbThucDon.ValueMember = "IDMonAn";
        }

        int CheckHoaDon(int idhd)
        {
            int check = 0;
            List<HoaDon> listhd = repoHD.GetAllHoaDon();
            foreach (var item in listhd)
            {
                if (idhd == item.IDHoaDon)
                {
                    check += 1;
                    break;
                }

            }
            return check;
        }

        void BindingCBChuyenBan()
        {
            cmbChuyenBan.DataSource = repoBan.GetAllBan();
            cmbChuyenBan.DisplayMember = "SoBan";
            cmbChuyenBan.ValueMember = "IDBan";
        }
        #endregion





        #region events
        void btn_Click(object sender, EventArgs e)
        {
            int idBan = ((sender as Button).Tag as Ban).IDBan;
            lsvHoaDon.Tag = (sender as Button).Tag;
            ShowBill(idBan);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            DanhMuc selected = cb.SelectedItem as DanhMuc;
            id = selected.IDDanhMuc;

            BindingCBThucDon(id);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            try
            {
                Ban ban = lsvHoaDon.Tag as Ban;

                HoaDon hoadon = repoHD.GetHoaDonByIDBanTrangThai(ban.IDBan, 0);
                

                if (hoadon == null)
                {
                    if (nudSoLuong.Value < 0)
                    {
                        MessageBox.Show("Số lượng không hợp lệ ! Vui lòng nhập lại !");
                    }
                    else
                    {

                        DateTime date = mcNgay.TodayDate;
                        int idban = ban.IDBan;
                        HoaDon hd = new HoaDon();
                        hd.IDBan = idban;
                        hd.TongTien = 0;
                        hd.NgayLapHD = date;
                        hd.TrangThai = 0;

                        repoHD.InsertUpdate(hd);


                        int soluong = int.Parse(nudSoLuong.Value.ToString());
                        int idhoadon = hd.IDHoaDon;
                        int idmon = int.Parse(cmbThucDon.SelectedValue.ToString());


                        ChiTietHoaDon cthd = new ChiTietHoaDon();
                        cthd.IDHoaDon = idhoadon;
                        cthd.IDMonAn = idmon;
                        cthd.SoLuong = soluong;

                        repoCTHD.InsertUpdate(cthd);


                        MessageBox.Show("Thêm món thành công !");

                        Ban table = repoBan.GetBan(ban.IDBan);
                        State.DocumentContext context = new State.DocumentContext();
                        context.setState(new State.ConcreteThemBan());
                        context.applyState(table);
                        /*table.TrangThai = "Có Người";
                        table.InsertUpdate();*/

                        ShowBill(table.IDBan);
                        LoadBan();
                    }
                }
                else
                {
                    int soluong = int.Parse(nudSoLuong.Value.ToString());
                    int idhoadon = hoadon.IDHoaDon;
                    int idmon = int.Parse(cmbThucDon.SelectedValue.ToString());

                    List<ChiTietHoaDon> listcthd = repoCTHD.GetListCTHDByIDHoaDon(idhoadon);
                    if (listcthd.Count > 0)
                    {
                        int check = 0;
                        foreach (var item in listcthd)
                        {
                            if (idmon == item.IDMonAn)
                                check++;
                        }
                        if (check > 0)
                        {
                            ChiTietHoaDon cthd = listcthd.Where(p => p.IDMonAn == idmon).FirstOrDefault();
                            cthd.SoLuong += soluong;
                            if (cthd.SoLuong > 0)
                            {
                                repoCTHD.InsertUpdate(cthd);
                                MessageBox.Show("Thêm món thành công !");
                            }
                            else if (cthd.SoLuong == 0)
                            {
                                repoCTHD.DeleteCTHoaDon(cthd.IDChiTietHoaDon);
                                if (listcthd.Count == 1)
                                {
                                    Ban table1 = repoBan.GetBan(ban.IDBan);
                                    State.DocumentContext context = new State.DocumentContext();
                                    context.setState(new State.ConcreteXoaBan());
                                    context.applyState(table1);
                                    //table1.TrangThai = "Trống";
                                    //table1.InsertUpdate();
                                    repoHD.DeleteHoaDon(hoadon.IDHoaDon);
                                }
                                MessageBox.Show("Thêm món thành công !");
                            }
                            else
                            {
                                MessageBox.Show("Số lượng không hợp lệ ! Vui lòng nhập lại !");
                            }
                        }
                        else
                        {
                            if (soluong <= 0)
                            {
                                MessageBox.Show("Số lượng không hợp lệ ! Vui lòng nhập lại !");
                            }
                            else
                            {
                                ChiTietHoaDon cthd = new ChiTietHoaDon();
                                cthd.IDHoaDon = idhoadon;
                                cthd.IDMonAn = idmon;
                                cthd.SoLuong = soluong;
                                repoCTHD.InsertUpdate(cthd);
                                MessageBox.Show("Thêm món thành công !");
                            }
                        }
                    }
                    ShowBill(ban.IDBan);
                    LoadBan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {


                Ban ban = lsvHoaDon.Tag as Ban;
                if (ban.TrangThai != "Đang Sửa" && ban.TrangThai != "Đặt Trước")
                {
                    if (MessageBox.Show("Bạn có chắc muốn thanh toán cho bàn " + ban.SoBan + " chứ?", "Trả lời", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        HoaDon hoadon = repoHD.GetHoaDonByIDBanTrangThai(ban.IDBan, 0);
                        State.DocumentContext context = new State.DocumentContext();
                        context.setState(new State.ConcreteXoaBan());
                        context.applyState(ban);
                        //ban.TrangThai = "Trống";
                        //ban.InsertUpdate();

                        hoadon.TrangThai = 1;
                        hoadon.TongTien = double.Parse(txtTongTien.Text);

                        repoHD.InsertUpdate(hoadon);

                        txtTongTien.Clear();
                    }
                    LoadBan();
                    lsvHoaDon.Items.Clear();
                    MessageBox.Show("Thanh toán thành công !");
                }
                else MessageBox.Show("Bạn chưa có món !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            Ban ban = lsvHoaDon.Tag as Ban;
            if (MessageBox.Show("Bạn có chắc muốn chuyển từ bàn " + ban.SoBan + "qua bàn " +
                (cmbChuyenBan.SelectedItem as Ban).SoBan + " chứ?", "Trả lời", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                HoaDon hd1 = repoHD.GetHoaDonByIDBanTrangThai(ban.IDBan, 0);

                HoaDon hd2 = new HoaDon();
                hd2 = hd1;
                hd2.IDBan = (cmbChuyenBan.SelectedItem as Ban).IDBan;

                string temp = ban.TrangThai;
                ban.TrangThai = (cmbChuyenBan.SelectedItem as Ban).TrangThai;
                (cmbChuyenBan.SelectedItem as Ban).TrangThai = temp;


                repoHD.InsertUpdate(hd2);
                repoBan.InsertUpdate(ban);

                Ban b = (cmbChuyenBan.SelectedItem as Ban);
                repoBan.InsertUpdate(b);

                LoadBan();
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            
            Ban ban = lsvHoaDon.Tag as Ban;
            if (ban.TrangThai == "Đang Sửa")
            {
                btnFix.Text = "Sửa Chữa";
                btnThemMon.Enabled = true;
                State.DocumentContext context = new State.DocumentContext();
                context.setState(new State.ConcreteXoaBan());
                context.applyState(ban);
                LoadBan();

            }
            else
            {
                if (ban.TrangThai == "Trống")
                {
                    btnThemMon.Enabled = false;
                    btnFix.Text = "Hoàn Thành";
                    State.DocumentContext context = new State.DocumentContext();
                    context.setState(new State.ConcreteDangSua());
                    context.applyState(ban);
                    LoadBan();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ban ban = lsvHoaDon.Tag as Ban;
            if(ban.TrangThai=="Đặt Trước")
            {
                btnDT.Text = "Đặt Trước";
                State.DocumentContext context = new State.DocumentContext();
                context.setState(new State.ConcreteXoaBan());
                context.applyState(ban);
                LoadBan();
            }
            else
            if (ban.TrangThai == "Trống")
                {
                    btnDT.Text = "Huỷ Đặt";
                    State.DocumentContext context = new State.DocumentContext();
                    context.setState(new State.ConcreteDatTruoc());
                    context.applyState(ban);
                    LoadBan();
                }
        }
    }
}
