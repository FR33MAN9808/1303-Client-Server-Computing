namespace Models
{
    using System;
    using Abstractions;

    public class Company : Contact, ICompany
    {
        public Company(string id, string name)
            :base(id, name)
        {

        }
    }
}
