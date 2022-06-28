using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Model.Repository
{
    interface INhaCungCapRepository
    {
        List<NhaCungCap> GetAllNCC();
        NhaCungCap GetNhaCungCap(int id);
        void InsertUpdateNCC(NhaCungCap ncc);
        void DeleteNCC(int idncc);
    }
}
