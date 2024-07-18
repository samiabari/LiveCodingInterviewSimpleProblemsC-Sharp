namespace FindIsPrime
{
    internal class Program
    {
        public static bool IsPrime(int n)
        {
            if (n <= 0)
            {
                return false;
            }
            else {
                for (int i = 2; i <n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
              
                }
                return true;
            }
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(10));
            Console.WriteLine(IsPrime(5));
        }
    }
}
