using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.Strategy
{
    internal class SortPrice: SortStrategy
    {
        public override List<Model.ThucDon> SortThucDon(List<Model.ThucDon> list)
        {
            List<Model.ThucDon> result = quicksort(list);
            return result;
        }

        private static List<Model.ThucDon> quicksort(List<Model.ThucDon> list)
        {
            if (list.Count <= 1) return list;
            int pivotPosition = list.Count / 2;
            Model.ThucDon pivotValue = list[pivotPosition];
            list.RemoveAt(pivotPosition);
            List<Model.ThucDon> smaller = new List<Model.ThucDon>();
            List<Model.ThucDon> greater = new List<Model.ThucDon>();
            foreach (Model.ThucDon item in list)
            {
                if (item.DonGia < pivotValue.DonGia)
                {
                    smaller.Add(item);
                }
                else
                {
                    greater.Add(item);
                }
            }
            List<Model.ThucDon> sorted = quicksort(smaller);
            sorted.Add(pivotValue);
            sorted.AddRange(quicksort(greater));
            return sorted;
        }
    }
}
