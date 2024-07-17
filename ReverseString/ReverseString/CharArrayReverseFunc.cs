using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal static class CharArrayReverseFunc
    {
        public static string Reverse(string s) 
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
          //  return chars.ToString(); // cannot convert properly

            s=new string(chars);
            return s;
        }
    }
}
