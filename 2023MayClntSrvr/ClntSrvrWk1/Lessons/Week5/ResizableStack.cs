using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week5
{
    public class ResizableStack<T> : GenericStack<T>
    {
        public ResizableStack(int size) : base(size)
        {
        }
    }
}
