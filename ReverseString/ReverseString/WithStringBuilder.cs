using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal static class WithStringBuilder
    {
        public static string Reverse(string s)
        {

            StringBuilder sb = new StringBuilder();
            for (int i=s.Length-1; i>=0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
    }
}
