using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberSeries
{
    internal class ForLoop2SqrtOfN
    {
        public static bool IsPrime(int n)
        {

            if (n <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }

                }
                return true;
            }

        }
        public static int[] Series(int n)
        {
            List<int> list = new List<int>();
            int c = 2, p=0;
            for (int i = 0; p < n; i++)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                    p++;
                }
                c++;
            }

            return list.ToArray();

        }
    }
}
