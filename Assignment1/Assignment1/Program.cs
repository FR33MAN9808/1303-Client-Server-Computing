using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetUserChoice();
        }

        public int GetUserChoice()
        {
            string userChoice;

            do
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i} - Option{i}");
                };

                Console.Write("Please select one option from above: ");
                userChoice = Console.ReadLine();
                int numChoice = Convert.ToInt32(userChoice);

                if (numChoice > 0 && numChoice < 11)
                {
                    Console.WriteLine($"{numChoice} - Option{numChoice}");
                    return 0;
                }
                else
                {
                    Console.WriteLine("ERROR: Choose an option from 1 to 10");
                }

            } while (userChoice != null);

            return 0; 
        }
    }
}
