using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClntSrvr.Lessons.Week9
{
    public class TaskDetails
    {
        public void TaskWithReturnType()
        {
            Task<int> task = Task.Run(() => { Console.WriteLine("foo"); return 5; });

            var result = task.Result; // block until task is finished and result is available

        }

        public void TaskThatThrows() 
        { 
            Task task = Task.Run(() => 
            { 
                Console.WriteLine("going to throw");
                // throw new NullReferenceException("throwing from the test task");
                throw new IndexOutOfRangeException("critical error!");
            });

            try
            {
                task.Wait();
            }
            catch (AggregateException ex) 
            {
                if (ex.InnerException is NullReferenceException)
                {
                    Console.WriteLine($"null ref exception was thrown in task: {ex.ToString()}");
                }
                else
                {
                    throw;
                }
            }
        }

        public Task<int> GetNumber(int baseNum, int number)
        {
            Task.Delay(1000);

            return Task.FromResult(baseNum + 10 / number);
        }

        public async Task<int> GetLongRunning(int baseNum, int number)
        {
            await Task.Delay(1000);

            return (baseNum + 10 / number);
        }

        public async Task GetLongRunningNoReturn(int baseNum, int number) 
        {

            var result = baseNum + number;        
        }
    }
}
