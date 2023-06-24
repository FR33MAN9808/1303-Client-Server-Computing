using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week3.Interfaces
{
    public class RedheadDuck : Duck, IFlyable
    {
        public RedheadDuck(int id, string name)
            : base(id, name)
        {
        }

        public void Fly()
        {
            Console.WriteLine($"{this.id} - {this.name} flying ...");
        }
    }
}
