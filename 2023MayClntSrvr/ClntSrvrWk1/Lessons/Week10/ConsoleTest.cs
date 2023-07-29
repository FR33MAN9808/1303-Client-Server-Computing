using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvr.Lessons.Week10
{
    public class ConsoleTest
    {
        public void TestConsoleProperties()
        {
            Console.WriteLine("Test console properties");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("========================");
            Console.CursorLeft -= 5;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("||");

            Console.CursorTop -= 1;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("123");
        }
    }
}
