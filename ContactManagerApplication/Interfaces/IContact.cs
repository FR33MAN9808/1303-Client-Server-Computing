using DataModel;
using System;
using System.Collections.Generic;
using System.Text;

 

namespace Abstractions
{
    public interface IContact
    {
        string Id { get; }
        string Name { get; set; }
        string Address { get; set; }
        List<ContactInfo> PhoneNumbers { get; set; }
        List<ContactInfo> Emails { get; set; }
    }

   
}
