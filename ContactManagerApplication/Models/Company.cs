namespace Models
{
    using System;
    using System.Collections.Generic;
    using Abstractions;
    using DataModel;

    public class Company : ICompany
    {
        public string Id { get; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<ContactInfo> PhoneNumbers { get; set; }
        public List<ContactInfo> Emails { get; set; }
        public List<IContact> RelatedContacts { get; set; }

        public Company(string id, string name, string address)
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
            this.Address = address;
            this.PhoneNumbers = new List<ContactInfo>();
            this.Emails = new List<ContactInfo>();
            this.RelatedContacts = new List<IContact>();
        }
    }
}
