namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            while(true)
            {
                if (!double.TryParse(Console.ReadLine(), out double numa))
                {
                    Console.WriteLine("Wrong");
                    continue;
                }
                if (!double.TryParse(Console.ReadLine(), out double numb))
                {
                    Console.WriteLine("Wrong");
                    continue;
                }
                string op=Console.ReadLine();

                if (op == "+")
                {
                    result = numa + numb;
                }
                else if (op == "-")
                {
                    result = numa - numb;
                }
                else if (op == "*")
                {
                    result = numa * numb;
                }
                else if (op == "/")
                {
                    if (numb == 0)
                    {
                        Console.WriteLine("invalid");
                    }
                    else
                    {
                        result = numa / numb;
                    }

                }
                else if (op == "%")
                {
                    if (numb == 0)
                    {
                        Console.WriteLine("invalid");
                    }
                    else
                    {
                        result = numa % numb;
                    }
                }
                else 
                {
                    Console.WriteLine("invalid op");
                }

                Console.WriteLine("Result: "+result);
            }
        }
    }
}
