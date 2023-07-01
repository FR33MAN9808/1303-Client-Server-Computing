using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading

namespace ClntSrvrWk1.Lessons.Week5
{
    /// <summary>
    /// A generic Stack class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericStack<T>
    {
        private int _size;
        private int _position;
        private T[] data;
        private object _lock = new object();

        public GenericStack(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(size), "Size must be greater than zero.");
            }

            _size = size;
            data = new T[_size];
        }

        public void Push(T item)
        {
            lock (_lock)
            {
                if (_position >= _size)
                {
                    throw new InvalidOperationException("Stack is full.");
                }

                data[_position++] = item;
            }
        }

        public T Pop()
        {
            lock (_lock)
            {
                if (_position <= 0)
                {
                    throw new InvalidOperationException("Stack is empty.");
                }

                return data[--_position];
            }
        }
    }
}
