using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week3.Inheritance
{
    public class RubberDuck : Duck
    {
        
        public RubberDuck(int id , string name, string colorTone)
            : base(id , name) 
        {
        }

        public override void Fly() 
        {
            Console.WriteLine($"a rubberDuck can't fly :(");
        }
    }
}
