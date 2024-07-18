namespace StackDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            Stack<int> s = new Stack<int>(size);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Print();
            s.Peek();
            s.Pop();
            s.Pop();
            s.Print();
        }
    }
}
