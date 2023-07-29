using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public interface IDataStorage
    {
        void Create(object item);
        object Retrieve(int id);
        void Update(int id, object updatedItem);
        void Delete(int id);
        List<object> ListAll();
    }

    public interface IResizableStorage
    {
        void Resize(int newSize);
    }
}
