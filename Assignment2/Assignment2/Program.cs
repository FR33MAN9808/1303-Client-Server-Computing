internal class Program
{
    private static void Main(string[] args)
    {
        Program p = new Program();

        Console.WriteLine("1 - Add user\r\n2 - Show user by ID\r\n3 - Show user by Name\r\n4 - Delete user by ID\r\n5 - Delete user by Name\r\n6 - List all users");


    }
}

class User
{
    public int id;
    public string name;
}