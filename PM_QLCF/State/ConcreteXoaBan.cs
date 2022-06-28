using PM_QLCF.Model;
using PM_QLCF.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.State
{
    internal class ConcreteXoaBan : State
    {
        BanRepository repoBan = new BanRepository();
        public override void HandleRequest(Ban ban)
        {
            ban.TrangThai = "Trống";
            repoBan.InsertUpdate(ban);
        }
    }
}
