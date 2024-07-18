namespace QueueAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q=new Queue<int>(4);
            q.Enqueue(5);
            q.Enqueue(6);
            q.Enqueue(7);
            q.Enqueue(8);
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Peek());
        }
    }
}
