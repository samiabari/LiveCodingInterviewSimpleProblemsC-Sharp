﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzzWriter
    {
        public static void Generator(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else {
                    Console.Write(i);
                }

                if (i != n)
                {
                    Console.Write(", ");
                }
                
            }
        }
    }
}
