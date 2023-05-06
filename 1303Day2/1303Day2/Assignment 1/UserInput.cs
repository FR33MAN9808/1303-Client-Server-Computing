using System;
using System.Collections.Generic;
using System.Text;

namespace _1303Day2.Assignment_1
{
    internal class UserInput
    {
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
                    return numChoice;
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
