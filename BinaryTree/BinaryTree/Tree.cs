using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinaryTree
{
    internal class Tree<T> where T: IComparable<T> 
    {
        public Node<T> Root {  get; set; }

        public Tree()
        {
            this.Root = null;
        }

        public void Insert(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
            }
            else 
            {
                InsertRecord(Root, data);
            }
               
        }

        public void InsertRecord(Node<T> root, T data)
        {
            if (data.CompareTo(root.Value) < 0)
            {
                if (root.Left == null)
                {
                    root.Left = new Node<T>(data);
                }
                else
                {
                    InsertRecord(root.Left, data);
                }
            }
            else 
            {
                if (root.Right == null)
                {
                    root.Right = new Node<T>(data);
                }
                else
                {
                    InsertRecord(root.Right, data);
                }
            }
        }


        public void InOrderTraverse(Node<T> node) 
        {
            if (node != null)
            {
                InOrderTraverse(node.Left);
                Console.WriteLine(node.Value);
                InOrderTraverse(node.Right);
            }
        }


        public void PreOrderTraverse(Node<T> node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                PreOrderTraverse(node.Left);

                PreOrderTraverse(node.Right);
            }
        }

        public void PostOrderTraverse(Node<T> node)
        {
            if (node != null)
            {
                PostOrderTraverse(node.Left);

                PostOrderTraverse(node.Right);
                Console.WriteLine(node.Value);
            }
        }

        public bool Search(T d)
        {
            return SearchNode(Root, d);
        }

        private bool SearchNode(Node<T> root, T d)
        {
            if (root == null)
            {
                return false;
            }
            if (d.CompareTo(root.Value) == 0)
            {
                return true;
            }
            else if (d.CompareTo(root.Value) < 0)
            {
              return  SearchNode(root.Left, d);
            }
            else 
            {
               return SearchNode(root.Right, d);
            }

        }


        private Node<T> Find(Node<T> root, T d)
        {
          
            if (root == null||d.CompareTo(root.Value) == 0)
            {
                return root;
            }
            else if (d.CompareTo(root.Value) < 0)
            {
                return Find(root.Left, d);
            }
            else
            {
                return Find(root.Right, d);
            }

        }
        public void Delete(Node<T> node)
        {
            if (node != null)
            {
                PostOrderTraverse(node.Left);

                PostOrderTraverse(node.Right);
                Console.WriteLine(node.Value);
            }
        }

        public void Update(Node<T> node)
        {
            if (node != null)
            {
                PostOrderTraverse(node.Left);

                PostOrderTraverse(node.Right);
                Console.WriteLine(node.Value);
            }
        }




        public void Delete(T data)
        {
            Root = DeleteRec(Root, data);
        }

        private Node<T> DeleteRec(Node<T> root, T data)
        {
            if (root == null)
            {
                return root;
            }

            if (data.CompareTo(root.Value) < 0)
            {
                root.Left = DeleteRec(root.Left, data);
            }
            else if (data.CompareTo(root.Value) > 0)
            {
                root.Right = DeleteRec(root.Right, data);
            }
            else
            {
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }

                root.Value = MinValue(root.Right);
                root.Right = DeleteRec(root.Right, root.Value);
            }

            return root;
        }

        private T MinValue(Node<T> node)
        {
            T minv = node.Value;
            while (node.Left != null)
            {
                minv = node.Left.Value;
                node = node.Left;
            }
            return minv;
        }
    }
}
