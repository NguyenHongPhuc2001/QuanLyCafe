using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Model.Repository
{
    interface IThucDonRepository
    {
        List<ThucDon> GetAllThucDon();
        ThucDon GetThucDon(int idtd);
        void InsertUpdate(ThucDon thucdon);
        void DeleteTD(int idtd);
        ThucDon GetIDDanhMucByTen(string tendm);
        List<ThucDon> GetThucDonByIDDanhMuc(int iddm);
    }
}
