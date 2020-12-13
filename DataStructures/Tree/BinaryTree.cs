using System;
using System.Text;

namespace DataStructureReview
{
    public class BinaryTree
    {

        private Node head = null;

        private int count = 0;

        public Node Head { get { return head; } }

        public int Count { get { return count; } }

        public BinaryTree(int data)
        {
            head = new Node(data);
            count++;
        }

        public bool Insert(int data)
        {
            return Head.Add(data);
        }

        public bool Search(int value)
        {
            return Head.Exists(value);
        }

        public bool Remove(int value)
        {
            if (Head.Data == value)
            {
                var auxNode = new Node(0);
                auxNode.Left = Head;
                var result = head.Remove(value, auxNode);
                head = auxNode.Left;
                return result;

            }
            else
            {
                return head.Remove(value, null);
            }
        }

        public void PreOrder(Node node)
        {
            if (node == null) return;
            Console.Write($"{node.Data} ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void InOrder(Node node)
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.Write($"{node.Data} ");
            InOrder(node.Right);
        }

        public void PostOrder(Node node)
        {
            if (node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write($"{node.Data} ");
        }

    }
}