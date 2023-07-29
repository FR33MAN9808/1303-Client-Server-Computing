
using System;
using System.Threading;

namespace ClntSrvr.Lessons.Week8
{
    public class ThreadingBasics
    {
        public static int _val1 = 1;    // class member but not instance member
        public int _val2;               // instance (object) member

        public void BasicThreadExecution()
        {
            Thread thread1 = new Thread(ThreadToWrite);
            thread1.Start();

            // main thread executing this
            for (int i = 0; i < 1000; i++) 
            {
                Console.Write("-");
            }

            thread1.Join();
        }

        // additional thread executing this
        public void ThreadToWrite()
        {
            for(int i = 0; i< 1000; i++) 
            {
                Console.Write("*");
                // Thread.Sleep(50);
                Thread.Yield(); // Thread.Sleep(0)
                
            }
            Console.Write(Thread.CurrentThread.ThreadState);
            Console.WriteLine("=====finished the loop here ======");
        }
    }

    public static class ThreadUnsafe
    {
        private static int _val1 = 1;
        private static int _val2 = 1;

        public static void Go()
        {
            if (ThreadUnsafe._val2 != 0)
            {
                var result = _val1 / _val2;
            }

            _val2 = 0;
        }
    }

    public static class ThreadSafe
    {
        private static int _val1 = 1;
        private static int _val2 = 1;
        private static readonly object _locker = new object();

        public static void Go()
        {
            lock (_locker)
            {
                if (_val2 != 0)
                {
                    var result = _val1 / _val2;
                }

                _val2 = 0;
            }
        }
    }

    public class ThreadExample2
    {
        private static int _x;
        private static readonly object _locker = new object();

        private void Increment()
        {
            lock (_locker)
            {
                _x++;
            }
        }

        private static void Assign(int y)
        {
            lock (_locker)
            {
                _x = y;
            }
        }
    }

    public class BankTransaction
    {
        private decimal bankFee = 12;
        private decimal savingsBalance;
        private decimal checkingBalance;
        private readonly object locker = new object();

        public BankTransaction(decimal savingsBalance, decimal checkingBalance)
        {
            this.savingsBalance = savingsBalance;
            this.checkingBalance = checkingBalance;
        }

        /// <summary>
        /// Atomicity
        /// Rollback
        /// </summary>
        /// <param name="amount"></param>
        public void TransferFromCheckingToSavings(decimal amount)
        {
            lock (this.locker)
            {
                if (this.checkingBalance >= amount + this.GetBankFee())
                {
                    this.savingsBalance += amount;
                    this.checkingBalance -= amount + this.GetBankFee();
                }
            }
        }

        private decimal GetBankFee()
        {
            // assume an exception is thrown here

            return this.bankFee;
        }
    }

    public class DeadLockExample
    {
        private readonly object locker1 = new object();
        private readonly object locker2 = new object();

        public void CreateDeadlock()
        {
            new Thread(() =>
            {
                lock (locker1)
                {
                    Thread.Sleep(1000);
                    lock (locker2); // Deadlock
                }
            }).Start();

            lock(locker2)
            {
                Thread.Sleep(1000);
                lock (locker1); // Deadlock
            }
        }
    }
}
