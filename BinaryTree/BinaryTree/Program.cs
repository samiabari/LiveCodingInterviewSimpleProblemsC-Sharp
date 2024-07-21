namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>();

            // Insert elements
            tree.Insert(50);
            tree.Insert(30);
            tree.Insert(20);
            tree.Insert(40);
            tree.Insert(70);
            tree.Insert(60);
            tree.Insert(80);

            // Print the tree
            Console.WriteLine("In-order traversal:");
            tree.InOrderTraverse(tree.Root);
            Console.WriteLine();

            Console.WriteLine("Pre-order traversal:");
            tree.PreOrderTraverse(tree.Root);
            Console.WriteLine();

            Console.WriteLine("Post-order traversal:");
            tree.PostOrderTraverse(tree.Root);
            Console.WriteLine();
        }
    }
}
