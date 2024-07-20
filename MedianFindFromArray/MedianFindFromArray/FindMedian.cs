using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianFindFromArray
{
    internal class FindMedian
    {
        public static int[] Merge(int[] a, int[] b)
        {
            int[] merged=new int[a.Length+b.Length];
            a.CopyTo(merged, 0);
            b.CopyTo(merged, a.Length);
            Array.Sort(merged);
            return merged;
        }

        public static double CheckMedian(int[] m)
        {
            int l = m.Length;
            if (l % 2 == 1)
            {

                return m[l / 2];
            }
            else {
                int mid1 = (l / 2) - 1;
                int mid2=l/2;
                double med=(m[mid1]+m[mid2])/2.0;
                return med;
            }
        }
    }
}
