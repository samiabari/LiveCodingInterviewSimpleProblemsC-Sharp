namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ForLoop.Reverse("For Loop"));
            Console.WriteLine(CharArrayReverseFunc.Reverse("Reverse Func"));
            Console.WriteLine(ReverseWithLinq.Reverse("With Linq"));
            Console.WriteLine(WithStringBuilder.Reverse("StringBuilder"));
            Console.WriteLine(RecursiveWay.Reverse("Recursive"));
            Console.WriteLine(WithStack.Reverse("Stack"));
        }
    }
}
