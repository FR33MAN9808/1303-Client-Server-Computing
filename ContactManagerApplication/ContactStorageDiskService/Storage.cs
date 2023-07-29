namespace ContactStorageDiskService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Abstractions;
    using DataModel;

    public class Storage : IStorage
    {
        private IContact[] contacts;
        private int size;
        private int growthFactor;
        private int currentCount;

        public Storage(int size, int growthFactor)
        {
            this.size = size;
            this.growthFactor = growthFactor;
            this.contacts = new IContact[size];
            this.currentCount = 0;
        }

        public void Create(IContact contact)
        {
            if (currentCount >= size)
            {
                ResizeArray();
            }

            contacts[currentCount] = contact;
            currentCount++;
        }

        public IContact Retrieve(string id)
        {
            return contacts.FirstOrDefault(c => c != null && c.Id == id);
        }

        public void Update(string id, IContact updatedContact)
        {
            int index = Array.FindIndex(contacts, c => c.Id == id);
            if (index >= 0)
            {
                contacts[index] = updatedContact;
            }
        }

        public void Delete(string id)
        {
            int index = Array.FindIndex(contacts, c => c != null && c.Id == id);
            if (index >= 0)
            {
                contacts[index] = null;
            }
        }

        public List<IContact> ListAll()
        {
            return contacts.Where(c => c != null).ToList();
        }

        private void ResizeArray()
        {
            int newSize = size * growthFactor;
            IContact[] newContacts = new IContact[newSize];
            Array.Copy(contacts, newContacts, size);
            contacts = newContacts;
            size = newSize;
        }

      
    }

    
}
