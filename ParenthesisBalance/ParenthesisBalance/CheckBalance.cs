using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParenthesisBalance
{
    internal class CheckBalance
    {
        public static bool Check(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else if (s[i] == ')' || s[i] == '}' || s[i] == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else {
                        
                        char c=stack.Pop();
                        if (s[i] == ')' && c != '(')
                        { 
                            return false;
                        }
                        else if(s[i] == '}' && c != '{')
                        {
                            return false;
                        }
                        else if (s[i] == ']' && c != '[')
                        {
                            return false;
                        }
                    }
                }
                
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
