using ClntSrvr.Lessons.Week10;
using ClntSrvr.Lessons.Week7;
using ClntSrvr.Lessons.Week8;
using ClntSrvr.Lessons.Week9;
using ClntSrvrWk1.Lessons.Week2;
using System;
using System.Threading.Tasks;

namespace ClntSrvrWk1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var test = new StreamIntroduction();
            test.FileStreamExample();

            Console.WriteLine("main wating .. ");
            Console.ReadLine();
        }

        public void TestTasks()
        {
            try
            {
                var testTasks = new TaskDetails();
                testTasks.TaskWithReturnType();
                testTasks.TaskThatThrows();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
