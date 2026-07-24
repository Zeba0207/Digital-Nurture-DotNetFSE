using System;
using System.Threading;

namespace Exercise27_Deadlock
{
    internal class Program
    {
        static readonly object lock1 = new object();
        static readonly object lock2 = new object();

        static void Thread1Work()
        {
            bool lock1Taken = false;
            bool lock2Taken = false;

            try
            {
                Monitor.TryEnter(lock1, 1000, ref lock1Taken);

                if (lock1Taken)
                {
                    Console.WriteLine("Thread 1 acquired Lock 1");

                    Thread.Sleep(500);

                    Monitor.TryEnter(lock2, 1000, ref lock2Taken);

                    if (lock2Taken)
                    {
                        Console.WriteLine("Thread 1 acquired Lock 2");
                        Console.WriteLine("Thread 1 completed its work.");
                    }
                    else
                    {
                        Console.WriteLine("Thread 1 could not acquire Lock 2.");
                    }
                }
            }
            finally
            {
                if (lock2Taken)
                    Monitor.Exit(lock2);

                if (lock1Taken)
                    Monitor.Exit(lock1);
            }
        }

        static void Thread2Work()
        {
            bool lock2Taken = false;
            bool lock1Taken = false;

            try
            {
                Monitor.TryEnter(lock2, 1000, ref lock2Taken);

                if (lock2Taken)
                {
                    Console.WriteLine("Thread 2 acquired Lock 2");

                    Thread.Sleep(500);

                    Monitor.TryEnter(lock1, 1000, ref lock1Taken);

                    if (lock1Taken)
                    {
                        Console.WriteLine("Thread 2 acquired Lock 1");
                        Console.WriteLine("Thread 2 completed its work.");
                    }
                    else
                    {
                        Console.WriteLine("Thread 2 could not acquire Lock 1.");
                    }
                }
            }
            finally
            {
                if (lock1Taken)
                    Monitor.Exit(lock1);

                if (lock2Taken)
                    Monitor.Exit(lock2);
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Thread1Work);
            Thread t2 = new Thread(Thread2Work);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("\nProgram Completed Successfully.");
        }
    }
}