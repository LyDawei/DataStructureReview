namespace DataStructureReview
{
    public interface ILinkedList<T>
    {
        void Remove(int position);
        void Insert(T item, int position);
        T Pop();
        void PushFront(T item);
        void PushBack(T item);

    }
}