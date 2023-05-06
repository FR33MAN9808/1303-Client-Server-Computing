using System;
using _1303Day2.Assignment_1;

namespace _1303Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.TestReadLine();
            UserInput userInput = new UserInput();
            int option = userInput.GetUserChoice();
            Console.WriteLine(option);
        }

        public void TestReadLine()
        {
            Console.WriteLine("Enter one or more lines - press CTRL + Z to exit: ");
            string line;

            do
            {
                Console.Write(" ==> ");
                line = Console.ReadLine();
                if (line != null)
                {
                    Console.WriteLine($"{line}");
                }

            } while (line != null);
        }
    }
}
