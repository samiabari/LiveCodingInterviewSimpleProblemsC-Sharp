using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapIntegerVariableValues
{
    internal static class WithTempVariable
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a= b;
            b= temp;

        }

    }
}
