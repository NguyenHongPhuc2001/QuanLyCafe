using PM_QLCF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Strategy
{
    internal class SortName : SortStrategy
    {
        public override List<ThucDon> SortThucDon(List<ThucDon> list)
        {
            List<ThucDon> result = quicksort(list);
            return result;
        }

        private static List<ThucDon> quicksort(List<ThucDon> list)
        {
            if (list.Count <= 1) return list;
            int pivotPosition = list.Count / 2;
            ThucDon pivotValue = list[pivotPosition];
            list.RemoveAt(pivotPosition);
            List<ThucDon> smaller = new List<ThucDon>();
            List<ThucDon> greater = new List<ThucDon>();
            foreach (ThucDon item in list)
            {
               
                if (String.Compare(item.TenMonAn,pivotValue.TenMonAn) == -1)
                {
                    smaller.Add(item);
                }
                else
                {
                    greater.Add(item);
                }
            }
            List<ThucDon> sorted = quicksort(smaller);
            sorted.Add(pivotValue);
            sorted.AddRange(quicksort(greater));
            return sorted;
        }
    }
}
