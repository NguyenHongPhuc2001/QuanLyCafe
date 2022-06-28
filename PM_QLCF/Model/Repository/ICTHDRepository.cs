using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Model.Repository
{
    interface ICTHDRepository
    {
        List<ChiTietHoaDon> GetAllCTHD();
        List<ChiTietHoaDon> GetListCTHDByIDHoaDon(int idhd);
        ChiTietHoaDon GetCTHDByIDMon(int idmon);
        void InsertUpdate(ChiTietHoaDon cthd);
        void DeleteCTHoaDon(int idcthd);
    }
}
