using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDCounting
{
    internal class GCDorHCFCalculator
    {
        public static int GCDorHCF(int a, int b)
        {
            if (b > a)
            {
                int temp = a;
                a=b; 
                b=temp;
            }

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a=temp;
            }

            return a;
        }
    }
}
