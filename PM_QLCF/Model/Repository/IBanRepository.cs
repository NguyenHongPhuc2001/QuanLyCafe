using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Model.Repository
{
    interface IBanRepository
    {
        List<Ban> GetAllBan();
        Ban GetBan(int id);
        void InsertUpdate(Ban ban);
        void DeleteBan(int id);

    }
}
