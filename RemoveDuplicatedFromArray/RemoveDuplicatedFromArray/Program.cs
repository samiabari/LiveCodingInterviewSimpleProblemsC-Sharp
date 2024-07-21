namespace RemoveDuplicatedFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] c = Deletor.Remove("Samia");
            foreach (char ch in c)
            {
                Console.WriteLine(ch);
            }
           
        }
    }
}
