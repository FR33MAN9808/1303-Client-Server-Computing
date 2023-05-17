using System;
using System.Xml.Linq;

internal class Program
{
    private static User[] users = new User[100];

    private static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Show user by ID");
            Console.WriteLine("3. Show user by Name");
            Console.WriteLine("4. Delete user by ID");
            Console.WriteLine("5. Delete user by Name");
            Console.WriteLine("6. List all users");
            Console.WriteLine("0. Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddUser();
                    break;
                case 2:
                    ShowUserByID();
                    break;
                case 3:
                    ShowUserByName();
                    break;
                case 4:
                    DeleteUserByID();
                    break;
                case 5:
                    DeleteUserByName();
                    break;
                case 6:
                    ListAllUsers();
                    break;
                case 0:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (choice != 0);
    }

    private static void AddUser()
    {
        Console.WriteLine("Enter user ID:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter user name:");
        string name = Console.ReadLine();

        User user = new User();
        user.ID = id;
        user.Name = name;

        users[id] = user;
    }

    private static void ShowUserByID()
    {
        Console.WriteLine("Enter user ID:");
        int id = int.Parse(Console.ReadLine());

        if (users[id] != null)
        {
            Console.WriteLine($"User ID: {users[id].ID}, Name: {users[id].Name}");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    private static void ShowUserByName()
    {
        Console.WriteLine("Enter user name:");
        string name = Console.ReadLine();

        bool userFound = false;

        for (int i = 0; i < users.Length; i++)
        {
            if (users[i] != null && users[i].Name == name)
            {
                Console.WriteLine($"User ID: {users[i].ID}, Name: {users[i].Name}");
                userFound = true;
            }
        }

        if (userFound == false)
        {
            Console.WriteLine("User not found.");
        }
    }

    private static void DeleteUserByID()
    {
        Console.WriteLine("Enter user ID:");
        int id = int.Parse(Console.ReadLine());
        if (users[id] != null)
        {
            users[id] = null;
            Console.WriteLine("User deleted.");
        }
        else
        {
            Console.WriteLine("User doesn't exist");
        }
    }

    private static void DeleteUserByName()
    {
        Console.WriteLine("Enter user Name:");
        string name = Console.ReadLine();

        bool userFound = false;

        for (int i = 0; i < users.Length; i++)
        {
            if (users[i] != null && users[i].Name == name)
            {
                users[i] = null;
                Console.WriteLine("User deleted.");
                userFound = true;
            }
        }

        if (userFound == false)
        {
            Console.WriteLine("User not found.");
        }
    }

    private static void ListAllUsers()
    {
        for (int i = 0; i < users.Length; i++)
        {
            if (users[i] != null)
            {
                Console.WriteLine($"User ID: {users[i].ID}, Name: {users[i].Name}");
            }
        }
    }
}

class User
{
    public int ID;
    public string Name;
}
