using System;

namespace DataStructureReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Binary Tree");

            var tree = new BinaryTree(45);

            tree.Insert(25);
            tree.Insert(15);
            tree.Insert(5);
            tree.Insert(35);
            tree.Insert(77);
            tree.Insert(88);
            tree.Insert(55);
            tree.Insert(65);

            Console.WriteLine("In Order:");
            tree.InOrder(tree.Head);

            Console.WriteLine("=======================");

            Console.WriteLine("PreOrder:");
            tree.PreOrder(tree.Head);

            Console.WriteLine("=======================");
            Console.WriteLine("PostOrder:");
            tree.PostOrder(tree.Head);

        }
    }
}
