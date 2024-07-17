namespace SwapIntegerVariableValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 2;
            WithTempVariable.Swap(ref a,ref b);
            Console.WriteLine("a: " + a + " and b: " + b);

            a = 5;
            b = 6;
            WithoutThirdVariable.Swap(ref a, ref b);
            Console.WriteLine("a: " + a + " and b: " + b);
            
            a = 5;
            b = 6;
            WithTupleDeconstruction.Swap(ref a, ref b);
            Console.WriteLine("a: " + a + " and b: " + b);
            
            a = 5;
            b = 6;
            WithXOR.Swap(ref a, ref b);
            Console.WriteLine("a: " + a + " and b: " + b);
        }
    }
}
