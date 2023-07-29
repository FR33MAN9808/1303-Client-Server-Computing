using Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public abstract class Contact : IContact
    {
        public string Id { get; }

        public string Name { get; set; }

        public Contact(string id, string name)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentNullException("Company Id is required to create a company.");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Company name is required.");
            }

            this.Id = id;
            this.Name = name;
        }
    }
}
