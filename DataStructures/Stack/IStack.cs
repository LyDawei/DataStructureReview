namespace DataStructureReview
{
    public interface IStack<T>
    {
        void Pop();
        void Push(T item);
        T Top();

    }
}