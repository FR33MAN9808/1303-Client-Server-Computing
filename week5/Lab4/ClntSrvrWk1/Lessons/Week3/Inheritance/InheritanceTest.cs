using ClntSrvrWk1.Lessons.Week3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week3.Inheritance
{
    public class AbstractClassTest
    {
        public void Test1() 
        {
            var duck5 = new Duck(0, "Eric");
            var duck1 = new Duck(12, "a duck");
            var redhead1 = new RedheadDuck(13, "redhead1", "light");
            var mallard1 = new MallardDuck(14, "mallard1");

            // base class, parent class or superclass
            // derived class, child class or subclass

            this.Display1(duck1);
            this.Display1(redhead1);
            this.Display1(mallard1);

            this.Display2(redhead1);
            // this.Display2(duck1); Compile ERROR!!!

            Duck duck2 = redhead1; // Upcast
            Console.WriteLine(duck2 == redhead1);

            Console.WriteLine(duck2.GetInfo());
            Console.WriteLine(redhead1.ColorTone);
            // Console.WriteLine(duck2.ColorTone); Compile ERROR!!!

            RedheadDuck redhead2 = (RedheadDuck) duck2; // Downcast

            // the as operator
            var duck3 = new Duck(15, "Gene");
            MallardDuck mallard2 = duck3 as MallardDuck; 

            // The is operator
            if (mallard2 is Duck) 
            {
                Console.WriteLine("mallard2 is a duck!");
            }
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
