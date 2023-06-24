using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvr.Lessons.Week6
{
    public class BTNode<T>
    {
        public T Data { get; set; }
        
        public BTNode<T> Left { get; set; }

        public BTNode<T> Right { get; set; }    
    }
}
