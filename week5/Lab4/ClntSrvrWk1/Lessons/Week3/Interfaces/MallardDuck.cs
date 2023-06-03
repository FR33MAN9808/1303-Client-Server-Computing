using System;

namespace ClntSrvrWk1.Lessons.Week3.Interfaces
{
    public class MallardDuck : Duck, IFlyable
    {
        public MallardDuck(int id, string name)
            : base(id, name)
        {
            age = 2;
        }

        public void Fly()
        {
            Console.WriteLine($"{this.id} - {this.name} flying ...");
        }
    }
}
