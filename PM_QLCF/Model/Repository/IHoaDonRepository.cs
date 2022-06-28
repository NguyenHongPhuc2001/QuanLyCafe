using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Model.Repository
{
    interface IHoaDonRepository
    {
        List<HoaDon> GetAllHoaDon();
        HoaDon GetHoaDonByIDHD(int idhd);
        HoaDon GetHoaDonByIDBan(int idban);
        HoaDon GetHoaDonByIDBanTrangThai(int idban, int trangthai);
        void InsertUpdate(HoaDon hoadon);
        void DeleteHoaDon(int idhd);

    }
}
