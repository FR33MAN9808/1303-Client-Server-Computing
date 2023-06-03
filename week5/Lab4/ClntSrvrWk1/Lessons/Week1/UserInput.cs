using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week1
{
    public class UserInput
    {
        public void TestUserInput()
        {
            TestReadLine();
        }

        public void TestReadLine()
        {
            Console.WriteLine("Enter one or more lines - press CTRL+Z followed by Enter to exit):");
            string line;

            do
            {
                Console.Write(" ==> ");
                line = Console.ReadLine();
                if (line != null)
                {
                    Console.WriteLine($" {line}");
                }

            } while (line != null);
        }
    }
}
