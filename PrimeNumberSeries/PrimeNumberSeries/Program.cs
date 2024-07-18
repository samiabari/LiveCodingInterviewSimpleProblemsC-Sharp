namespace PrimeNumberSeries
{
    internal class Program
    {
       


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = ForLoop2N.Series(n);
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

            int[] v = ForLoop2N.Series(n);
            foreach (int i in v)
            {
                Console.WriteLine(i);
            }
        }
    }
}
