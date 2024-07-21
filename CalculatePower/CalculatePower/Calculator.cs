using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePower
{
    internal class Calculator
    {
        public static double PowerAuto(double x, int p)
        {
            double result = Math.Pow(x, p);
            return result;
        }


        public static double PowerMenual(double x, int p)
        {
            if (p == 0)
            {
                return 1;
            }
            double half = PowerMenual(x, p/2);
            if (p % 2 == 0)
            {
                return half * half;
            }
            else {
                return half * half * x;
            }
           
        }
    }
}
