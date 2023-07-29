


namespace Abstractions
{
    using System;
    using System.Collections.Generic;
    using System.Text;


    public interface ICompany : IContact
    {
        public string Id { get; }

        public string Name { get; set; }
    }
}
