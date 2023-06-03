using System;

namespace ClntSrvrWk1.Lessons.Week4.ObjectType
{
    public class MyStack
    {
        private int size;
        private int position;
        private object[] items;

        public MyStack(int stackSize)
        {
            size = stackSize;
            items = new object[size];
            position = -1;
        }

        public void Push(object obj)
        {
            if (position == size - 1)
            {
                throw new InvalidOperationException("Stack overflow!");
            }
            items[++position] = obj;
        }

        public object Pop()
        {
            if (position == -1)
            {
                throw new InvalidOperationException("Stack underflow!");
            }
            return items[position--];
        }

        public object Peak()
        {
            if (position == -1)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            return items[position];
        }
    }
}