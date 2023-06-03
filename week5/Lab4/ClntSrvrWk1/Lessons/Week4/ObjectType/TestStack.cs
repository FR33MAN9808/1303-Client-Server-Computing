using System;

namespace ClntSrvrWk1.Lessons.Week4.ObjectType
{
    public class TestStack
    {
        public void Test1() 
        {
            var stack = new MyStack(5);

            stack.Push("book1");
            stack.Push("paper1");
            stack.Push("paper2");
            stack.Push("paper3");
            stack.Push("paper4");
            stack.Push("paper5");

            var s1 = stack.Pop();

            var intStack = new MyStack(5);
            intStack.Push(12);
            intStack.Push(13);
            var i = intStack.Pop();

            Console.WriteLine($"i: {i.GetType()}");
            Console.WriteLine($"s1: {s1.GetType()}");

        }
    }
}
