using ClntSrvrWk1.Lessons.Week4.ObjectType;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClntSrvrWk1.Lessons.Week5
{
    public class TestGenericStack
    {
        public void Test1()
        {
            var stack1 = new GenericStack<int>(5);

            var stack2 = new GenericStack<string>(10);
            stack2.Push("123");

            var stack3 = new GenericStack<Car>(12);
            var car1 = new Car(Color.GREEN);
            stack3.Push(car1);

            // stack2.Push(car1);
        }

        public void Test2()
        {
            int x = 5;
            int y = 19;

            GenericSwap<int>(ref x, ref y);


            var c1 = new Car(Color.RED);
            var c2 = new Car(Color.GREEN);
            GenericSwap(ref c1, ref c2);
        }

        /// <summary>
        /// A generic method inside a non-generic class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void GenericSwap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public void Test_Framework_List()
        {
            var list = new List<int>();
            list.Add(10);
            list.Add(13);
            list.Add(19);
            list.Add(57);

            list.Remove(19);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // an example of using the index to access an item in the list
            for(int i = 0;  i < list.Count; i++)
            {
                Console.WriteLine(list.ElementAt(i));
            }

            var list2 = new List<Car>();
        }

        // an example of key / value pair object type whic is provided by the .Net framework
        public void Test_Framework_Dictionary()
        {
            var dicOfCars = new Dictionary<string, Car>();
            var c1 = new Car("1234", Color.RED);
            var c2 = new Car("5644", Color.RED);
            var c3 = new Car("2345", Color.RED);
            var c4 = new Car("1900", Color.RED);

            dicOfCars.Add(c1.GetVin(), c1);
            dicOfCars.Add(c2.GetVin(), c2);
            dicOfCars.Add(c3.GetVin(), c3);
            dicOfCars.Add(c4.GetVin(), c4);

            var item = dicOfCars["1900"];
        }
    }
}
