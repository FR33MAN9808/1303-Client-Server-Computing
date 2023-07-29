using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
    public interface IPerson : IContact
    {
        public string EmailAddress { get; }
    }
}
