namespace QueueManual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>(6);
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            q.Enqueue(6);
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Peek());
        }
    }
}
