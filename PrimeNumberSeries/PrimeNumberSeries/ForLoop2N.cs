using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberSeries
{
    internal class ForLoop2N
    {
        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < n; i++)
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

            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                }
            }

            return list.ToArray();

        }
    }
}
