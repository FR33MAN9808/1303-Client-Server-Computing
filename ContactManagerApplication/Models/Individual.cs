using Abstractions;
using DataModel;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;


namespace Models
{
    public class Individual : IIndividual
    {
        public string Id { get; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<ContactInfo> PhoneNumbers { get; set; }
        public List<ContactInfo> Emails { get; set; }
        public List<IContact> RelatedContacts { get; set; }

        

        public Individual(string ID, string name, string address)
        {
            this.Id = ID;
            this.Name = name;
            this.Address = address;
            this.PhoneNumbers = new List<ContactInfo>();
            this.Emails = new List<ContactInfo>();
            this.RelatedContacts = new List<IContact>();
        }
    }
}
