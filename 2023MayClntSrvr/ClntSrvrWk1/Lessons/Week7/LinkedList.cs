namespace ClntSrvr.Lessons.Week7
{
    /// <summary>
    /// Singly Linked List
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T>
    {
        private int count;

        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Tail { get; private set; }

        /// <summary>
        /// Add a node to the beginning of the list
        /// </summary>
        /// <param name="node"></param>
        public void AddHead(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = this.Head;

            this.Head = node;

            this.Head.Next = temp;
            // this.count++;
        }

        /// <summary>
        /// Add a node to the end of the list
        /// </summary>
        /// <param name="node"></param>
        public void AddTail(LinkedListNode<T> node) 
        { 
            if (this.count == 0)
            {
                this.Head = node;
            }
            else
            {
                this.Tail.Next = node;
            }

            this.Tail = node;
            this.count++;
        }

        /// <summary>
        /// Remove the node located at the head
        /// Before: Head --> 3 --> 5
        /// After:  Head --> 5
        /// </summary>
        public void RemoveHead()
        {
            this.Head = this.Head.Next;
            this.count--;

            if (this.count == 0)
            {
                this.Tail = null;
            }
        }

        /// <summary>
        /// Remove the node located at the tail
        /// </summary>
        public void RemoveTail()
        {

        }

        public bool Remove(T data)
        {
            LinkedListNode<T> current = this.Head;
            LinkedListNode<T> previous = null;
            
            while(current != null)
            { 
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            this.Tail = previous;
                        }

                        this.count--;
                    }
                    else
                    {
                        this.RemoveHead();
                    }

                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public int GetCount()
        {
            return this.count;
        }
    }
}
