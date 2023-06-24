namespace ClntSrvr.Lessons.Week7
{
    public class LinkedListNode<T>
    {
        public T Data { get; set; }

        public LinkedListNode(T data)
        {
            this.Data = data;
        }

        public LinkedListNode<T> Next { get; set; }
    }
}
