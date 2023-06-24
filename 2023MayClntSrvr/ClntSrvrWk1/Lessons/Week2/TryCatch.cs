using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvrWk1.Lessons.Week2
{
    public class TryCatch
    {
        public void RunTest1()
        {
            try
            {
                var et = new ExceptionThrowing("234", null);
                Console.WriteLine("after returning from test");
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine($"Please enter a valid value - {ane.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in RunTest(): {ex}");
            }
        }

        public void RunTest2()
        {
            var et = new ExceptionThrowing("234", null);
            Console.WriteLine("after returning from test");
        }
    }
}
