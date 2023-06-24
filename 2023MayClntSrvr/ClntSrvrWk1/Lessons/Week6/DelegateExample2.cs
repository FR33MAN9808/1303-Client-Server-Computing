using System;
using System.Collections.Generic;
using System.Text;

namespace ClntSrvr.Lessons.Week6
{
    public class DelegateExample2
    {
        private string prefix = "% complete: ";

        public void ProgressReporter(int percentComplete)
        {
            Console.WriteLine($"{this.prefix}{percentComplete}");
        }
    }
}
