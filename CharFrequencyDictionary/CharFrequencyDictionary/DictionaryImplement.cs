using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharFrequencyDictionary
{
    internal class DictionaryImplement
    {

        public static Dictionary<char, int> CountFreq(string s)
        {
           
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            return dict;
        }

        public static void Print(Dictionary<char, int> dict)
        {
            foreach (char item in dict.Keys)
            {
                Console.WriteLine("key: "+item+" & Freq: " + dict[item]);
            }
        }
      
    }
}
