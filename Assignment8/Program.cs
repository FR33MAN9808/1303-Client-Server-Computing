using System;
using Assignment8;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        var storage = new Storage(10, 2);

        // Test Create
        storage.Create("Entry 1");
        storage.Create("Entry 2");

        // Test ListAll
        ListAllEntries(storage);

        // Test Retrieve
        var retrievedEntry = (string)storage.Retrieve(0);
        Console.WriteLine($"Retrieved Entry: {retrievedEntry}");

        // Test Update
        storage.Update(1, "Updated Entry 2");
        ListAllEntries(storage);

        // Test Delete
        storage.Delete(0);
        ListAllEntries(storage);
    }

    private static void ListAllEntries(Storage storage)
    {
        Console.WriteLine("All Entries:");
        var entries = storage.ListAll();
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
}
