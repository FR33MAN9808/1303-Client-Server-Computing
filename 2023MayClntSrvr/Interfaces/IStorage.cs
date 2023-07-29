using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
    /// <summary>
    /// Create, Retrieve, Update, Delete 
    /// </summary>
    public interface IStorage
    {
        void Add(ICompany company);
        ICompany GetCompany();
        void Update(ICompany company);
        void Delete(ICompany company);
        
        void Add(IPerson person);
        IPerson GetPerson();
        void Delete(IPerson person);
        void Update(IPerson person);
    }
}
