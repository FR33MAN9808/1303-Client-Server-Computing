using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week4.ObjectType
{
    public class TestEnum
    {
        public void Test1()
        {
            // this is assigned to when created
            // in this case the value is Unknown
            Color c1;
            Color c2 = Color.BLUE;

            var car = new Car(Color.RED);

            // Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(car.GetColor());

        }
    }
}
