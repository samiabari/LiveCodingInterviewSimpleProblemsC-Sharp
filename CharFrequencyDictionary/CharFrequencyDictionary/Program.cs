namespace CharFrequencyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dict = DictionaryImplement.CountFreq("Samia");
            DictionaryImplement.Print(dict);
        }
    }
}
