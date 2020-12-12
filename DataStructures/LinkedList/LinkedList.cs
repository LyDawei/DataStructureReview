using System.Text;

namespace DataStructureReview
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> head;


        public LinkedList()
        {
            head = null;
        }

        public void Push(T item)
        {
            var current = head;

            if (head == null)
            {
                head = new LinkedListNode<T>(item);
                return;
            }

            while (current.next != null)
            {
                current = current.next;
            }

            current.next = new LinkedListNode<T>(item);
        }



        public override string ToString()
        {
            var builder = new StringBuilder();

            var current = head;
            while (current.next != null)
            {
                builder.Append($"{current.data} -> ");
                current = current.next;
            }

            builder.Append("null");
            return builder.ToString();
        }
    }
}