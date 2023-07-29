using Abstractions;
using DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactStorageDiskService
{
    public interface IStorage
    {
        void Create(IContact contact);
        IContact Retrieve(string id);
        void Update(string id, IContact updatedContact);
        void Delete(string id);
        List<IContact> ListAll();
    }
}
