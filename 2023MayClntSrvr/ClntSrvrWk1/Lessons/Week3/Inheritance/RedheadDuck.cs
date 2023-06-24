using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week3.Inheritance
{
    public class RedheadDuck : Duck
    {
        public string ColorTone { get; }
        public RedheadDuck(int id, string name, string colorTone)
            : base(id, name)
        {
            this.ColorTone = colorTone;
        }
    }
}
