using System;
using System.Text;

namespace DataStructureReview
{
    public class LinkedList<T> : ILinkedList<T>
    {
        private LinkedListNode<T> head;
        private int count;
        public int Count { get { return count; } }


        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public void Remove(int position)
        {
            if (head == null)
            {
                return;
            }

            LinkedListNode<T> before = null;
            var current = head;
            while (position > 0)
            {

                before = current;
                current = current.next;
                position--;
            }

            before.next = current.next.next;
            current.next = null;
            count--;
        }

        public void Insert(T item, int position)
        {
            if (position > count || head == null)
            {
                PushBack(item);
                return;
            }

            if (position == 0)
            {
                PushFront(item);
                return;
            }

            LinkedListNode<T> before = null;
            var current = head;


            while (position > 0)
            {
                Console.WriteLine("test");
                before = current;
                current = current.next;
                position--;
            }

            before.next = new LinkedListNode<T>(item);

            before.next.next = current;
            count++;
        }



        public T Pop()
        {
            if (head == null || head.next == null)
            {
                throw new System.Exception("Nothing to remove. List is empty.");
            }

            var before = head;
            var current = head.next;

            while (current.next != null)
            {
                before = current;
                current = current.next;
            }
            count--;
            before.next = null;
            return before.data;
        }

        public void PushFront(T item)
        {
            var newNode = new LinkedListNode<T>(item);
            var current = head;
            newNode.next = current;
            head = newNode;

            count++;
        }

        public void PushBack(T item)
        {
            var current = head;

            if (head == null)
            {
                head = new LinkedListNode<T>(item);
                count++;
                return;
            }
            current = Traverse(current);
            current.next = new LinkedListNode<T>(item);
            count++;
        }

        private LinkedListNode<T> Traverse(LinkedListNode<T> node)
        {
            if (node.next == null)
            {
                return node;
            }
            return Traverse(node.next);
        }

        private LinkedListNode<T> TraverseTo(LinkedListNode<T> node, int pos)
        {
            if (pos == 0)
            {
                return node;
            }
            return TraverseTo(node, pos--);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append($"Number of items: {count}\n");

            var current = head;

            if (count == 1)
            {
                builder.Append($"{current.data} -> ");
            }

            // 2 1 null
            while (current.next != null)
            {
                builder.Append($"{current.data} -> ");
                current = current.next;
            }

            builder.Append($"{current.data} -> null");
            return builder.ToString();
        }


    }
}