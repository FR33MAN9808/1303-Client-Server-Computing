using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

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

        //public GenericStack()
        //{
        //    this._size = 5;
        //}

        public GenericStack(int size) 
        { 
            _size = size;
            data = new T[_size];
        }

        public void Push(T item)
        {
            data[++_position] = item;
        }

        public T Pop()
        {
            return data[--_position];
        }
    }
}
