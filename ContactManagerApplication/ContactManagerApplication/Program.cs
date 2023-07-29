using ContactStorageDiskService;
using Abstractions;
using Abstractions;
using Models;
using System;
using System.Collections.Generic;

namespace ContactManagerApplication
{
    internal class Program
    {
        private IStorage contactStorage = new Storage(10, 2);
        static void Main(string[] args)
        {
            //user input
            int choice;
            Program program = new Program();
            do
            {
                //starting menu
                Console.WriteLine("Welcome to Contact Manager Service");
                Console.WriteLine("********************");
                Console.WriteLine("Please Choose an option:\n1) Create a new Contact\n2) Search for a Contact\n3) List all Contacts" +
                    "\n4) Save and Load from Server\n5) Quit Application");
                Console.WriteLine("********************");
                //get input
                string input = Console.ReadLine();
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            program.createContact();
                            break;
                        case 2:
                            program.searchContact();
                            break;
                        case 3:
                            program.listAllContacts();
                            break;
                        case 4:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;

                        case 5:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                };

            } while (choice != 5);
        }

        public void createContact()
        {
            int choice;
            do
            {
                Console.WriteLine("********************");
                Console.WriteLine("Choose an option for Contact Creation");
                Console.WriteLine("1) Company\n2) An individual\n3) Quit");
                Console.WriteLine("********************");
                string input = Console.ReadLine();
                if (int.TryParse(input, out choice)) 
                {
                    switch (choice)
                    {
                        case 1:
                            createCompanyContact();
                            break;
                        case 2:
                            createIndividualContact();
                            break;
                        case 3:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                
            } while (choice != 3);
        }

        public void createCompanyContact()
        {
            Console.WriteLine("Company ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Company Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Company Address:");
            string address = Console.ReadLine();
            IContact companyContact = new Company(id, name, address);

            contactStorage.Create(companyContact);

            Console.WriteLine("Company Contact created successfully!");
        }

        public void createIndividualContact()
        {
            Console.WriteLine("ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Address:");
            string address = Console.ReadLine();

            IContact individualContact = new Individual(id, name, address);

            contactStorage.Create(individualContact);

            Console.WriteLine("Individual Contact created successfully!");
        }

        public void searchContact()
        {
            Console.WriteLine("Enter the ID of the Contact to search:");
            string idToSearch = Console.ReadLine();
            IContact contact = contactStorage.Retrieve(idToSearch);
            if (contact != null)
            {
                Console.WriteLine("Contact Found:");
                Console.WriteLine($"ID: {contact.Id}, Name: {contact.Name}, Address: {contact.Address}");
            }
            else
            {
                Console.WriteLine("Contact not found!");
            }
        }

        public void listAllContacts()
        {
            List<IContact> allContacts = contactStorage.ListAll();
            if (allContacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
            }
            else
            {
                Console.WriteLine("All Contacts:");
                foreach (var contact in allContacts)
                {
                    Console.WriteLine($"ID: {contact.Id}, Name: {contact.Name}");
                }
            }
        }




    }
}
