using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week5
{
    public class StackAndHeap
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int Factorial(int x) 
        { 
            if (x == 0)
            {
                return 1;
            }

            return x * Factorial(x - 1);
        }
    }
}
