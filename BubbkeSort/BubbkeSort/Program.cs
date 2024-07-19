namespace BubbkeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 4, 6, 2, 7, 3, 5, 11, 8, 10 };
            Bubble.Sort(a);
            foreach(int i in a)
                Console.WriteLine(i);
        }
    }
}
