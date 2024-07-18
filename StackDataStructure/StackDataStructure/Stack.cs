using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStructure
{
    public class Stack<T>
    {
        static T[] elements;
        static int top;
        static int max;
        public Stack(int size) { 
            elements=new T[size];
            top = -1;
            max = size;
        }

        public  void Push(T item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("over flow");
                return;
            }
            top++;
            elements[top]=item;
        }

        public  T Pop()
        {
            if (top == - 1)
            {
                Console.WriteLine("underflow");
                return default(T);
            }
            T itemReturn = elements[top];
            --top;
            return itemReturn;
        }
        public  T Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("empty");
                return default(T);
            }
            
            return elements[top];
        }

        public void Print()
        {
            if (top == -1)
            {
                Console.WriteLine("empty");
               
            }

            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}
