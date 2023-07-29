namespace ClntSrvr.Lessons.Week7
{
    using System;

    public class LinkedListTest
    {
        private void AddNodeToHead_ShouldAdd()
        {
            var linkedList = new LinkedList<int>();

            linkedList.AddHead(new LinkedListNode<int>(2));

            var count = linkedList.GetCount();
            if (count != 1)
            {
                throw new Exception("Count should be 1");
            }
        }
    }
}
