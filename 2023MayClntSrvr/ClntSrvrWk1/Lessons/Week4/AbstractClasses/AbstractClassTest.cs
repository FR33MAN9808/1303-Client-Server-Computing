using ClntSrvrWk1.Lessons.Week3.Interfaces;
using System;

namespace ClntSrvrWk1.Lessons.Week3.AbstractClasses
{
    public class AbstractClassTest
    {
        public void Test1() 
        {
            // var duck1 = new Duck(12, "a duck");
            var mallard1 = new MallardDuck(14, "mallard1");

            this.Display1(mallard1);
        }

        /// <summary>
        /// if called by passing a subclass it is 
        /// automatically converting the subclass to the base class
        /// </summary>
        /// <param name="duck"></param>
        public void Display1(Duck duck)
        {
            Console.WriteLine($"Duck: {duck.GetInfo()}");
        }

        public void Display2(RedheadDuck redhead)
        {
            Console.WriteLine($"Duck: {redhead.GetInfo()}");
        }
    }
}
