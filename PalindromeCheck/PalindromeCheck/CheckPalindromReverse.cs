using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck
{
    internal class CheckPalindromReverse
    {
        public static bool Check(string s)
        {
            if (s == null)
            {
                return false;
            }

            string rev = new string(s.Reverse().ToArray());

         
             for (int i = 0; i < s.Length / 2; i++)
             {
                    if (s[i] != rev[i])
                    {
                        return false;
                    }
             }
           

            return true;

        }
    }
}
