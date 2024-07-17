using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal static class WithStack
    {
        public static string Reverse(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char el in s)
            {
                stack.Push(el);
            }

            char[] c=new char[s.Length];
            for (int i=0; i< s.Length; i++)
            {
                c[i] = stack.Pop();
            }
            string rev=new string(c);
            return rev;
        }
    }
}
