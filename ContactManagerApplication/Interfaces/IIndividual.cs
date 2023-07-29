using DataModel;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Abstractions
{
    public interface IIndividual : IContact
    {
        public string Id { get; }

        public string Name { get; set; }

        List<IContact> RelatedContacts { get; set; }
    }
}
