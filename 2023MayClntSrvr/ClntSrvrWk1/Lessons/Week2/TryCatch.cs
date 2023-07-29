using System;

namespace ClntSrvrWk1.Lessons.Week2
{
    public class TryCatch
    {
        public void RunTest1(bool pleaseThrow = false)
        {
            try
            {
                string message = pleaseThrow ? null : "testMessage";
                var et = new ExceptionThrowing("234", message);
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
            finally
            {
                Console.WriteLine("finally block executed");
            }
        }

        public void RunTest2()
        {
            var et = new ExceptionThrowing("234", null);
            Console.WriteLine("after returning from test");
        }

        public void RunTestWithFinally()
        {
            // does not throw
            RunTest1();
            // throws
            RunTest1(true);
        }
    }
}
