namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckAnagramChar.Check("silent", "listen"));
            Console.WriteLine(CheckAnagramDict.Check("silent", "listen"));
        }
    }
}
