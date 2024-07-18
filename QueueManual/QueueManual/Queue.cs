using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueManual
{
    public class Queue<T>
    {
        T[] elements;
        int start;
        int end;
        int max;
        public Queue(int size) {

            end = -1;
            start = 0;
            elements = new T[size];
            max= size;
        }

        public void Enqueue(T item)
        {
            if (end == max - 1)
            {
                Console.WriteLine("overflow");
                return;
            }
            end++;
            elements[end]= item;
            
        }

        public T Dequeue()
        {
            if (start > end)
            {
                Console.WriteLine("underflow");
                return default(T);
            }
            T returnData=elements[start];
            start++;
            return returnData;
        }

        public T Peek()
        {
            if (start > end)
            {
                Console.WriteLine("underflow");
                return default(T);
            }
            
            return elements[start];
        }

    }
}
