using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoadPolyFloatVsDoubleVsDecimal
{
    internal class MethodOverload
    {
        public static void Add(float a, float b)
        {
            float c=a*b;
        }
        public static void Add(decimal a, decimal b)
        {
            decimal c = a * b;
        }
        public static void Add(double a, double b)
        {
            decimal c = Convert.ToDecimal(a * b);
           
        }
       
    }
}
