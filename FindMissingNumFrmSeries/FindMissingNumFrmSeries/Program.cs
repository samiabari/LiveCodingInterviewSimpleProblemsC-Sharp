namespace FindMissingNumFrmSeries
{
    internal class Program
    {
        public static int FindMissing(int[] ar, int n)
        {
            int expectedSum = n * (n + 1)/2;

            int actualSum = 0;

            foreach (int i in ar)
            {
                actualSum = actualSum + i;
            }

            int missingNumber = expectedSum - actualSum;
            return missingNumber;
        }
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 4, 5, 6 }; //3 is missing
            int range = 6; // 1-6 numbers.
            Console.WriteLine(FindMissing(ar, range));
        }
    }
}
