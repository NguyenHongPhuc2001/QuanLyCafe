using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Model.Repository
{
    interface IDanhMucRepository
    {
        List<DanhMuc> GetAllDanhMuc();
        DanhMuc GetDanhMuc(int iddm);
        void InsertUpdate(DanhMuc danhmuc);
        void DeleteDM(int iddm);

    }
}
