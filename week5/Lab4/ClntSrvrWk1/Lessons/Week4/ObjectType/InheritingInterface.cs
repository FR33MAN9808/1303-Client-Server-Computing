using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week4.ObjectType
{
    public interface Interface1
    {
        void Display();
    }

    public interface Interface2 : Interface1
    {
        void Serialize();
    }
}
