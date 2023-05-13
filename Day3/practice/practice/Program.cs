using practice;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Program program = new Program();

        var userArray = new User[10];
        for (int i = 0; i < userArray.Length; i++) 
        {
            userArray[i] = new User()
            {
                id = (i + 1),
                name = "placeholder" + (i + 1)
            };
        }

        program.printArray(userArray);
    }

    public void printArray(User[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"id:{arr[i].id}\nname:{arr[i].name}\n");
        }
    }
}