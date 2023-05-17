internal class Program
{
    private static void Main(string[] args)
    {
        //Program p = new Program();

        Console.WriteLine("1 - Add user\r\n2 - Show user by ID\r\n3 - Show user by Name\r\n4 - Delete user by ID\r\n5 - Delete user by Name\r\n6 - List all users\r\n7 - Exit");

        int userInput = int.Parse(Console.ReadLine());

        switch (userInput)
        {
            case 1:
                //Add user
                Console.WriteLine("");
                User newUser = new User();
                break;

            case 2:
            //Show user by ID

            case 3:
            //Show user by Name

            case 4:
            //Delete user by ID

            case 5:
            //Delete user by Name

            case 6:
            //List all users

            case 7:
                //Exit
                break;
        }

    }
}

class User
{
    public int id { get; set; }
    public string name { get; set; }
}