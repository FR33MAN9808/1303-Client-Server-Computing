using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week3.AbstractClasses
{
    public class MallardDuck : Duck
    {
        public MallardDuck(int id, string name)
            : base(id, name)
        {
            age = 2;
        }

        public override int FieldId => this.GetId() + this.age;
    }
}
