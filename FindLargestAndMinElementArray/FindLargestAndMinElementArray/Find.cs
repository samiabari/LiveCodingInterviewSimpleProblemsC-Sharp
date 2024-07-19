using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLargestAndMinElementArray
{
    internal class Find
    {
        public static int Max(int[] a)
        {
            int max = -99999999;
            foreach (int i in a)
            {
                if (max < i)
                {
                    max = i;
                }
            }
            return max;
        }
        public static int Min(int[] a)
        {
            int min = 99999999;
            foreach (int i in a)
            {
                if (min > i)
                {
                    min = i;
                }
            }
            return min;
        }
    }
}
