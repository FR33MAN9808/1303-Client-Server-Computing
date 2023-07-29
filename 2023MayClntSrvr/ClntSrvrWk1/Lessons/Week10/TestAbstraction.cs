using System;
using System.Collections.Generic;
using System.Text;
using Abstractions;
using Models;

namespace ClntSrvr.Lessons.Week10
{
    public class TestAbstraction
    {
        public void TestAbstractModel()
        {
            var company1 = new Company("01", "MyCompany");
            var person1 = new Person("11", "Person1", "p1@mycompany.com");
            var person2 = new Person("11", "Person2", "p2@mycompany.com");
            var person3 = new Person("11", "Person3", "p3@mycompany.com");

            var list = new List<IContact>();
            
            list.Add(company1);
            list.Add(person1);  
            list.Add(person2);
            list.Add(person3);

            this.Print(list);
        }

        public void Print(List<IContact> list)
        {
            foreach (var contact in list) 
            {
                Console.WriteLine($"id: {contact.Id} name: {contact.Name}");
                if (contact is Person)
                {
                    var p1 = (Person) contact; // throws an exception if not possible
                    var p2 = contact as Person; // returns null if not possible
                    Console.WriteLine($"Email: {p1.EmailAddress}");
                }
            }
        }
    }
}
