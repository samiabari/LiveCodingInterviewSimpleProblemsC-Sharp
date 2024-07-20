using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiiSeriesSolution
{
    internal class SeriesGenerator
    {
        public static long[] Generate(int n)
        {
            long[] series = new long[n];
            if (n >= 1)
            {
                series[0] = 0;
            }
            if(n>=2)
            {
                series[1] = 1;
            }
            for (int i = 2; i < n; i++)
            {
                series[i] = series[i - 2] + series[i - 1];
            }
            return series;
        }
    }
}
