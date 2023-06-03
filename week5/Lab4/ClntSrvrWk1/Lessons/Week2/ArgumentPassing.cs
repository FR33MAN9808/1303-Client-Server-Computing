using System;

namespace ClntSrvrWk1.Lessons.Week2
{
    public class ArgumentPassing
    {
        public void RunTest()
        {
            var n = 0;
            this.Increment(n);
            Console.WriteLine(n);

            this.Increment(ref n);
            Console.WriteLine(n);

            this.Increment2(out n);
            Console.WriteLine(n);
        }

        // argument is passed by value
        // i has a default value of 5. i is an optional parameter.
        public void Increment(int i = 5)
        {
            i = i + 1;
            if (i > 10)
            {
                Console.WriteLine("i cannot be incremented");
            }
            Console.WriteLine(i);
        }

        // argument is passed by reference
        // ref x is very similar to the C++ following notations
        // *x pointer
        // &x address-of
        public void Increment(ref int i)
        {
            i = i + 1;
            if (i > 10)
            {
                Console.WriteLine("i cannot be incremented");
            }
            Console.WriteLine(i);
        }

        public void Increment2(out int i)
        {
            i = 100;
            Console.WriteLine(i);
        }
    }
}
