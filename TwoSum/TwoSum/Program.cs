namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = TwoSumChecker.Check([2, 7, 11, 15], 9);
            foreach (int a in ar)
            {
                Console.WriteLine(a);
            }
            
        }
    }
}
