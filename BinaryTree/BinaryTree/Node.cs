using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Node<T>
    {
        public T Value { set; get; }
        public Node<T> Left { set; get; }
        public Node<T> Right { set; get; }

        public Node(T data)
        {
            this.Value = data;
            this.Left = null;
            this.Right = null;
        }
    }
}
