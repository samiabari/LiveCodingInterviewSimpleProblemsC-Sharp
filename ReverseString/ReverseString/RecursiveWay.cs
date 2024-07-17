using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal static class RecursiveWay
    {
        public static string Reverse(string s)
        {

           if(s.Length<=1)
                return s;

            return s[s.Length-1]+Reverse(s.Substring(0, s.Length-1));
        }
    }
}
