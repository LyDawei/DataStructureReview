using System.Text;

namespace DataStructureReview
{
    public class Queue<T> : IQueue<T>
    {
        private T[] collection;
        private int back;

        public int Length { get { return collection.Length; } }

        public Queue(int capacity = 10)
        {
            collection = new T[capacity];
            back = 0;
        }

        public T PopFront()
        {
            var retVal = collection[0];
            var _collection = new T[Length];
            for (var i = 0; i < Length - 1; i++)
            {
                _collection[i] = collection[i + 1];
            }

            collection = _collection;
            return retVal;
        }

        public void Push(T item)
        {
            if (back == Length - 1)
            {
                throw new System.Exception("Queue is at capacity.");
            }

            collection[back] = item;
            back++;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.Append("[");

            for (var i = 0; i < Length; i++)
            {
                builder.Append($"{collection[i]} ");
            }

            builder.Append("]");
            return builder.ToString();
        }


    }
}