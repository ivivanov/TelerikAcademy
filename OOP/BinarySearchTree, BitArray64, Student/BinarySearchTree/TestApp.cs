using System;

namespace BinarySearchTree
{
    class TestApp
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Insert(9);
            tree.Insert(7);
            tree.Insert(15);
            tree.Insert(6);
            tree.Insert(8);
            tree.Insert(10);
            tree.Insert(20);
            tree.Insert(21);
            tree.Insert(19);
            tree.PrintDFS();
            Console.WriteLine("Remove 15");
            tree.Remove(15);
            tree.PrintDFS();
        }
    }
}
