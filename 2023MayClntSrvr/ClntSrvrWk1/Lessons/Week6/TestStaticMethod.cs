using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvr.Lessons.Week6
{
    public static class TestStaticMethod
    {
        const int variableRate = 2;

        public static int CalculateInterest(int baseRate)
        {
            return (baseRate + 1 + variableRate);
        }
    }
}
