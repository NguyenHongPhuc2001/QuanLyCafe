using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Strategy
{
    internal class SortedList
    {
        private List<Model.ThucDon> list = new List<Model.ThucDon>();
        private SortStrategy sortstrategy;
        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this.sortstrategy = sortstrategy;
        }
        public List<Model.ThucDon> Sort(List<Model.ThucDon> list)
        {
            return sortstrategy.SortThucDon(list);
        }
    }
}
