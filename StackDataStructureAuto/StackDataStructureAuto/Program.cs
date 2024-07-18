﻿namespace StackDataStructureAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s=new Stack<int>(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Count());
        }
    }
}
