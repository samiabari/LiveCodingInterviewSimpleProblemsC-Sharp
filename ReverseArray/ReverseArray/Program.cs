namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int start = 0;
            int end = arr.Length-1;
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end]= temp;
                start++;
                end--;
            }

            foreach (int i in arr)
            { 
                Console.WriteLine(i);
            }
        }
    }
}
