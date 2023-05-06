using System;

namespace _1303_week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program was called with");
            Console.WriteLine("Chuanche Liu 000462312");
            for (int i =0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

            Program program = new Program();
            program.PrintNumbers();
            int inches = program.FeetToInches(3);
            Console.WriteLine($"3 feet is : {inches} inches.");
            string message = "This is our first message";
            var message2 = "new message";

            var a = 5;
            var arr = new int[] { 1, 2, 3 };
            bool isThisGood = true;

            var p1 = new Point();
            p1.x = 10;
            p1.y = 12;

            int b = 20;
            b = a;

            Point p2 = p1;
        }
        public void PrintNumbers() 
        {
            Console.WriteLine("this is a test");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(" ");
                Console.Write(i);
            }

            Console.WriteLine(" end of loop");
        }
        public int FeetToInches(int feet) 
        {
            int inches = feet * 12;
             return inches;
        }
    }
}
