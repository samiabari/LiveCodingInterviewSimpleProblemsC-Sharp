using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal static class ForLoop
    {
        public static string Reverse(string s)
        {
            string reverse = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse += s[i];
            }
            return reverse;
        }
    }
}
