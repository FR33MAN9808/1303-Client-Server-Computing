using ClntSrvrWk1.Lessons.Week2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week1
{
    public class ObjectAndStruct
    {
        public void RunTest()
        {
            var inches = FeetToInches(13);
            Console.WriteLine($"13 feet is: {inches} inches.");
            string message = "this is our first program in C#";
            var message2 = "new message";

            Console.WriteLine(message);
            Console.WriteLine(message2);

            var arr = new int[] { 1, 2, 3, };
            bool isThisGood = true;
            if (isThisGood) 
            {
                Console.WriteLine("we're good");
            }
        }

        public void TestObjectAndStruct()
        {
            Program program = new Program();
            var p1 = new Point();
            p1.x = 10;
            p1.y = 12;
            this.Print(p1, "p1 after assignment");

            var a = 5;
            int b = 20;
            b = a;         // copies the actual value from a to b 

            Point p2 = p1; // copies the reference from p1 into p2
            this.Print(p2, "p2 after assignment");

            Point p3 = new Point();
            p3.x = 23;
            p3.y = 64;

            this.Print(p3, "p3 before assignment");
            p3 = p1;
            this.Print(p3, "p3 after assignment");

            Point p4 = new Point();

            p4 = null;
            this.Print(p4, "p4 assignment");
            if (p4 == null)
            {
                Console.WriteLine("p4 is null");
            }

            PointStruct ps1 = new PointStruct();
            ps1.x = 10;
            ps1.y = 15;

            PointStruct ps2;
            ps2.y = 20;
        }

        // Passing arguments to functions
        public void Print(Point p, string message)
        {
            if (p == null)
            {
                Console.WriteLine("Point refers to a null!");
                return;
            }
            Console.WriteLine($"{message}: x:{p.x} y:{p.y}");
        }

        public void PrintNumbers()
        {
            Console.WriteLine("this is a test");

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(" ");
                Console.Write(i);
            }

            Console.WriteLine("end of loop");

        }

        public int FeetToInches(int feet)
        {
            int inches = feet * 12;

            return inches;
        }
    }
}
