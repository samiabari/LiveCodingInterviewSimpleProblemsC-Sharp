using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal static class ReverseWithLinq
    {
        public static string Reverse(string s)
        {
         
            s = new string(s.Reverse().ToArray());
            return s;
        }
    }
}
