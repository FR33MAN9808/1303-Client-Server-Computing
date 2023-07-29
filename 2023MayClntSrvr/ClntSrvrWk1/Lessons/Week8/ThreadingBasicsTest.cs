namespace ClntSrvr.Lessons.Week8
{
    using System;
    using System.Threading;

    public class ThreadingBasicsTest
    {
        public void Test1()
        {
            var threadTest = new ThreadingBasics();
            threadTest.BasicThreadExecution();

            ThreadingBasics._val1 = 5;
            threadTest._val2 = 7;

            ThreadUnsafe.Go();
        }

        public void Test2() 
        {
            Thread t1 = new Thread(PrintLog);
            t1.Start("hi there - from t1");
        }

        public static void PrintLog(object messageObject)
        {
            string message = (string)messageObject;
            Console.WriteLine(message);
        }

        public void Test3()
        {
            try
            {
                Thread t1 = new Thread(TryPrintLogWithExceptionHandling);
                t1.Start("");
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.ToString());
            }
        }

        /// <summary>
        /// this will not catch the exception and the main thread will not know 
        /// of the exception either
        /// </summary>
        /// <param name="messageObject"></param>
        /// <exception cref="NullReferenceException"></exception>
        public static void TryPrintLog(object messageObject)
        {
            string message = (string)messageObject;
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new NullReferenceException();
            }

            Console.WriteLine(message);
        }

        public static void TryPrintLogWithExceptionHandling(object messageObject)
        {
            try
            {
                string message = (string)messageObject;
                if (string.IsNullOrWhiteSpace(message))
                {
                    throw new NullReferenceException();
                }

                Console.WriteLine(message);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.ToString());   
            }
        }

        // Thread Pool
    }
}
