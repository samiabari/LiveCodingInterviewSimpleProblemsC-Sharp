using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapIntegerVariableValues
{
    internal static class WithoutThirdVariable
    {
        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b=a-b; 
            a = a-b;
        }
    }
}
