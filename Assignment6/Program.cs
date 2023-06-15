using System;
using System.Collections.Generic;
using Assignment6;

class Program
{
    delegate void DisplayDelegate(User user);

    static void Main(string[] args)
    {
        List<User> users = new List<User>
        {
            new RegularUser { Name = "John Doe", Username = "johndoe", Email = "johndoe@example.com" },
            new RegularUser { Name = "Jane Smith", Username = "janesmith", Email = "janesmith@example.com" },
            new RegularUser { Name = "Mike Johnson", Username = "mikejohnson", Email = "mikejohnson@example.com" },
            new RegularUser { Name = "Sarah Adams", Username = "sarahadams", Email = "sarahadams@example.com" },
            new RegularUser { Name = "David Brown", Username = "davidbrown", Email = "davidbrown@example.com" },
            new EliteUser { Name = "Emily Davis", Username = "emilydavis", Email = "emilydavis@example.com" },
            new EliteUser { Name = "Michael Clark", Username = "michaelclark", Email = "michaelclark@example.com" },
            new EliteUser { Name = "Olivia Evans", Username = "oliviaevans", Email = "oliviaevans@example.com" },
            new EliteUser { Name = "James Green", Username = "jamesgreen", Email = "jamesgreen@example.com" },
            new EliteUser { Name = "Sophia Harris", Username = "sophiaharris", Email = "sophiaharris@example.com" }
        };

        Display(users, DisplayUser);
    }

    static void DisplayUser(User user)
    {
        Console.WriteLine($"Name: {user.Name}");
        Console.WriteLine($"Username: {user.Username}");
        Console.WriteLine($"Email: {user.Email}");
        Console.WriteLine();
    }

    static void Display(List<User> users, DisplayDelegate displayDelegate)
    {
        foreach (User user in users)
        {
            displayDelegate(user);
        }
    }
}