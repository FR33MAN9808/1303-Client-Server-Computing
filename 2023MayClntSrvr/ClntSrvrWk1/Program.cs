using ClntSrvr.Lessons.Week7;
using System;

namespace ClntSrvrWk1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var test = new DelegateExample();
            // test.TestDelegateFunctionality();

            var test = new Program();
            test.AddNodeToHead_ShouldAdd();
        }

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
