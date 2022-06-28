using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Strategy
{
    public abstract class SortStrategy
    {
        public abstract List<Model.ThucDon> SortThucDon(List<Model.ThucDon> list);
    }
}
