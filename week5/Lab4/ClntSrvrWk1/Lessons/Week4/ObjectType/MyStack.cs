using System;

namespace ClntSrvrWk1.Lessons.Week4.ObjectType
{
    public class MyStack<T>
    {
        private int size;
        private int position;
        private T[] items;

        public MyStack(int stackSize)
        {
            size = stackSize;
            items = new T[size];
            position = -1;
        }

        public void Push(T obj)
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

        public T Peak()
        {
            if (position == -1)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            return items[position];
        }
    }
}