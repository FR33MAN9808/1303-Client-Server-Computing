using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
    public interface IContact
    {
        public string Id { get; }

        public string Name { get; set; }
    }
}
