namespace FibonachiiSeriesSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] ser = SeriesGenerator.Generate(10);

            foreach (long i in ser)
            {
                Console.WriteLine(i);
            }
        }
    }
}
