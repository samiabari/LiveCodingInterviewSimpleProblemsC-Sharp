using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountVowels
{
    internal class CheckVowelsWithStringContains
    {
        public static bool Check(char c)
        {
            string vowels = "aeiouAEIOU";
            if (vowels.Contains(c))
            {
                return true;
            }
            return false;
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
