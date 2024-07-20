using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDNLCMCounting
{
    public class LCMCalculator
    {
        public static int LCM(int a, int b, int gcd)
        {
            int lcm = (Math.Abs(a * b)) / gcd;
            return lcm;
        }
    }
}
