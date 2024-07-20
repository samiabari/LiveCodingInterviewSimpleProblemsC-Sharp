namespace MedianFindFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2, 4 };
            int[] m = FindMedian.Merge(nums1, nums2);
            Console.WriteLine(FindMedian.CheckMedian(m));
        }
    }
}
