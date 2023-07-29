using Abstractions;

namespace Models
{
    public class Person : Contact, IPerson
    {
        public string EmailAddress { get; }

        public Person(string id, string name, string emailAddress)
            : base(id, name) 
        { 
            this.EmailAddress = emailAddress;
        }
    }
}
