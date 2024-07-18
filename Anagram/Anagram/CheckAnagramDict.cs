using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    internal class CheckAnagramDict
    {
        public static bool Check(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            

            Dictionary<char, int> c1= new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (c1.ContainsKey(c))
                {
                    c1[c]++;
                }
                else {
                    c1.Add(c, 1);
                }
            }
            foreach (char c in t)
            {
                if (c1.ContainsKey(c))
                {
                    c1[c]--;
                    if (c1[c] < 0)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }


            return true;
        }
    }
}
