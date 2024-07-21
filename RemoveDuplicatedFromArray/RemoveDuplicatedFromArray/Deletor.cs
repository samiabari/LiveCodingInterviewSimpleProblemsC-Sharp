using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatedFromArray
{
    internal class Deletor
    {
        public static char[] Remove(string s)
        {
            char[] c = s.ToCharArray();

            HashSet<char> h= new HashSet<char>(c);
            return h.ToArray();
        }
    }
}
