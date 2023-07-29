using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class Storage : IDataStorage, IResizableStorage
    {
        private object[] data;
        private int size;
        private int growthFactor;
        private int count;

        public Storage(int size, int growthFactor)
        {
            this.size = size;
            this.growthFactor = growthFactor;
            data = new object[size];
            count = 0;
        }

        public void Create(object item)
        {
            if (count >= size)
                Resize(size * growthFactor);

            data[count] = item;
            count++;
        }

        public object Retrieve(int id)
        {
            if (id >= 0 && id < count)
                return data[id];

            return null; // Or throw an exception indicating invalid ID
        }

        public void Update(int id, object updatedItem)
        {
            if (id >= 0 && id < count)
                data[id] = updatedItem;
            else
                throw new ArgumentException("Invalid ID");
        }

        public void Delete(int id)
        {
            if (id >= 0 && id < count)
            {
                for (int i = id; i < count - 1; i++)
                    data[i] = data[i + 1];

                data[count - 1] = null;
                count--;
            }
            else
                throw new ArgumentException("Invalid ID");
        }

        public List<object> ListAll()
        {
            return new List<object>(data.Take(count));
        }

        public void Resize(int newSize)
        {
            object[] newData = new object[newSize];
            Array.Copy(data, newData, count);
            data = newData;
            size = newSize;
        }
    }
}
