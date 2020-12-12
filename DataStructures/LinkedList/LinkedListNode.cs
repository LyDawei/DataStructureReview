namespace DataStructureReview
{
    public class LinkedListNode<T>
    {

        public T data { get; set; }
        public LinkedListNode<T> next { get; set; }

        public LinkedListNode() => next = null;

        public LinkedListNode(T data)
        {
            this.data = data;
            next = null;
        }

        public override string ToString()
        {
            return $"data: {data}\nnext: {next.data}";
        }

    }
}