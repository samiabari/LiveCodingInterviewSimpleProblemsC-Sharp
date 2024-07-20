using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecifyFibonacciOrNot
{
    internal class FibonacciChecker
    {
        public static bool SequenceChecker(long num)
        {
            long sq1 = (5 * num * num) + 4;
            long sq2 = (5 * num * num) - 4;
            if (IsPerfectSqr(sq1) || IsPerfectSqr(sq2))
            {
                return true;
            }
            else {
                return false;
            }
        }

        public static bool IsPerfectSqr(long sq)
        {
            long root = (long)Math.Sqrt(sq);
            return root * root == sq;
        }
    }
}
