using PM_QLCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PM_QLCF.Model.Repository;

namespace PM_QLCF.State
{
    internal class ConcreteDangSua : State
    {
        BanRepository repoBan = new BanRepository();
        public override void HandleRequest(Ban ban)
        {
            ban.TrangThai = "Đang Sửa";
            repoBan.InsertUpdate(ban);
        }
    }
}
