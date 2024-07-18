using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    internal class CheckVowelsForIfLoop
    {
        public static bool Check(char c)
        {
            if (c == 'A' || c == 'a')
            {
                return true;
            }
            else if (c == 'E' || c == 'e')
            {
                return true;
            }
            else if (c == 'I' || c == 'i')
            {
                return true;
            }
            else if (c == 'O' || c == 'o')
            {
                return true;
            }
            else if (c == 'U' || c == 'u')
            {
                return true;
            }
            else {
                return false;
            }
        }

        public static int Count(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                if (Check(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
