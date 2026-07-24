using System;
using System.Threading;

namespace Exercise26_RaceCondition
{
    internal class Program
    {
        // Shared counter
        static int counter = 0;

        // Lock object
        static readonly object lockObject = new object();

        static void IncrementCounter()
        {
            for (int i = 1; i <= 1000; i++)
            {
                lock (lockObject)
                {
                    counter++;
                }
            }
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(IncrementCounter);
            Thread thread2 = new Thread(IncrementCounter);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine($"Final Counter Value : {counter}");
        }
    }
}