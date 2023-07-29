using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ClntSrvr.Lessons.Week9
{
    public class TaskBasics
    {
        public void RunTesks()
        {
            Task.Run( () => { Console.WriteLine("foo on taks"); } );
            new Thread(() => Console.WriteLine("foo on thread")).Start();

            Task task = Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("foo task is running");

            });
            
            Console.WriteLine($"completed? {task.IsCompleted}");
            task.Wait(); // blocks until task is complete
            Console.WriteLine($"is task completed? {task.IsCompleted}");

            Task task2 = Task.Factory.StartNew(() => 
            { 
                Console.WriteLine("task from factory"); 
            },
            TaskCreationOptions.LongRunning);
        }
    }
}
