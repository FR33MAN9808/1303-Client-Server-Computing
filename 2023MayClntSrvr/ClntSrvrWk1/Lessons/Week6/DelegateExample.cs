using ClntSrvrWk1.Lessons.Week3.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvr.Lessons.Week6
{
    public class DelegateExample
    {
        public delegate int TransformInt(int x);

        public void TestDelegateFunctionality()
        {
            // using an object method through a delegate
            TransformInt transform1 = this.Square;
            int result1 = transform1(5);

            transform1.Invoke(4);
            
            // this does not compile
            // TransformInt transform2 = this.Square2;

            TransformInt transform3 = this.CalculateArea;
            int result3 = transform3(3);

            int[] values = new int[] { 3, 5, 7, 9 };
            var results1 = this.TransformArray(values, transform3);

            var results2 = this.TransformArray(values, transform1);

            // using a static method through a delegate
            TestStaticMethod.CalculateInterest(4);

            TransformInt transform4 = TestStaticMethod.CalculateInterest;
            int result4 = transform4(5);
            transform4 += this.Square;
            transform4 += this.CalculateArea;

            transform4(17);
        }

        public int Square(int side)
        {
            return side * side;
        }

        public int Square2()
        {
            return 4;
        }

        public int CalculateArea(int n)
        {
            return n * n;
        }

        public int[] TransformArray(int[] values, TransformInt transformer)
        {
            var results = new int[values.Length];
            for (int i = 0; i < values.Length; i++) 
            {
                results[i] = transformer(values[i]);
            }

            return results;
        }
    }
}
