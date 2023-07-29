
using ContactStorageDiskService;
using Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Models;

namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            // Create a new storage with initial size 5 and growth factor 2
            IStorage storage = new Storage(5, 2);

            // Test individual and company creation
            IContact individual1 = new Individual("ID001", "John Doe", "123 abots");
            IContact individual2 = new Individual("ID002", "Jane Smith", "4443 street");
            IContact company1 = new Company("CID001", "ABC Corp", "789 Center Ave");
            IContact company2 = new Company("CID002", "XYZ Inc", "456 Park Blvd");

            storage.Create(individual1);
            storage.Create(individual2);
            storage.Create(company1);
            storage.Create(company2);

            // Test retrieving contacts
            Console.WriteLine("Retrieving contacts...");
            IContact retrievedIndividual = storage.Retrieve("ID001");
            IContact retrievedCompany = storage.Retrieve("CID001");

            Console.WriteLine($"Retrieved Individual: {retrievedIndividual?.Name}");
            Console.WriteLine($"Retrieved Company: {retrievedCompany?.Name}");

            // Test updating a contact
            IContact updatedCompany = new Company("CID001", "Updated Corp", "123 Updated Ave");
            storage.Update("CID001", updatedCompany);
            IContact retrievedUpdatedCompany = storage.Retrieve("CID001");

            Console.WriteLine($"Updated Company: {retrievedUpdatedCompany?.Name}");

            // Test deleting a contact
            storage.Delete("ID001");
            Console.WriteLine("Contact with ID001 deleted.");

            // List all contacts
            Console.WriteLine("Listing all contacts:");
            var allContacts = storage.ListAll();
            foreach (var contact in allContacts)
            {
                Console.WriteLine($"ID: {contact.Id}, Name: {contact.Name}");
            }

            Console.ReadKey();
        }
    }
}
