using System;

namespace ClntSrvrWk1.Lessons.Week4.ObjectType
{
    public class TestStack
    {
        public static int[] testArr = new int[10000];

        public void Test1()
        {
            var stack = new MyStack();
            
            stack.Push("book1");
            stack.Push("paper1");
            stack.Push("paper2");
            stack.Push("paper3");
            stack.Push("paper4");
            // stack.Push("paper5");

            var s1 = stack.Pop();

            var intStack = new MyStack();
            intStack.Push(12);
            intStack.Push(13);
            var i = intStack.Pop();

            Console.WriteLine($"i: {i.GetType()}");
            Console.WriteLine($"s1: {s1.GetType()}");

        }

        public void Test2()
        {
            var stack = new MyStack();

            stack.Push(new Car(Color.GREEN));
            var c1 = stack.Pop();
        }

        public void Test3()
        {
            var stack = new MyStack();

            stack.Push(new Car(Color.GREEN));
            stack.Push("test3");
            stack.Push(123);

            var o1 = stack.Pop();
            var o2 = stack.Pop();
            var o3 = stack.Pop();
        }
    }
}