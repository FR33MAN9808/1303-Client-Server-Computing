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
                Console.WriteLine("1 -- A\n2 -- B\n3 -- C\n4 -- D\n5 -- E\n6 -- F\n7 -- G\n8 -- H\n9 -- I\n10 -- J");

                Console.Write("Please select one option from above: ");
                userChoice = Console.ReadLine();
                int numChoice = Convert.ToInt32(userChoice);

                if (numChoice > 0 && numChoice < 11)
                {
                    switch(numChoice)
                    {
                        case 1:
                            Console.WriteLine("A");
                            break;

                        case 2:
                            Console.WriteLine("B");
                            break;

                        case 3:
                            Console.WriteLine("C");
                            break;

                        case 4:
                            Console.WriteLine("D");
                            break;

                        case 5:
                            Console.WriteLine("E");
                            break;

                        case 6:
                            Console.WriteLine("F");
                            break;

                        case 7:
                            Console.WriteLine("G");
                            break;

                        case 8:
                            Console.WriteLine("H");
                            break;

                        case 9:
                            Console.WriteLine("I");
                            break;

                        case 10:
                            Console.WriteLine("J");
                            break;
                    }
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
