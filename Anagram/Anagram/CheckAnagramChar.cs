using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    internal class CheckAnagramChar
    {
        public static bool Check(string s, string t)
        {
            if(s.Length!=t.Length)
                return false;
            char[] c1 = s.ToCharArray();
            Array.Sort(c1);
            char[] c2 = t.ToCharArray();
            Array.Sort(c2);

            for (int i = 0; i < c2.Length; i++)
            {
                if (c1[i] != c2[i])
                    return false;
            }

            return true;
        }
    }
}
