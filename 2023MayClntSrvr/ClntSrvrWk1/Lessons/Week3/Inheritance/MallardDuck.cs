using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week3.Inheritance
{
    public class MallardDuck : Duck
    {
        public MallardDuck(int id, string name)
            : base(id, name)
        {
            age = 2;
        }
    }
}
