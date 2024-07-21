using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ManualLinkList
{
    internal class LinkList<T>
    {
        Node<T> Head { set; get; }
        public LinkList() {
            this.Head = null;
        }

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Head == null)
            {
                Head = newNode;

            }
            else {
                Node<T> current=Head;
                while (current.Next != null)
                {
                    current=current.Next;
                }
                current.Next = newNode;
            }
        }

        public bool Remove(T data) {
            
            if (Head == null)
            {
                return false;
            }
            else {
                Node<T> current = Head;
                while (current.Next != null && !current.Next.Data.Equals(data))
                {
                    current = current.Next;
                }
                if (current.Next != null)
                {
                    current.Next = current.Next.Next;
                    return true;
                }
                return false;
            }
        }

        public void Traverse()
        {

            if (Head == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Node<T> current = Head;
                while (current != null)
                {
                    Console.Write(current.Data);
                    if (current.Next != null)
                    {
                        Console.Write("->");
                       
                    }
                    current = current.Next;
                }
            }
        }
    }
}
