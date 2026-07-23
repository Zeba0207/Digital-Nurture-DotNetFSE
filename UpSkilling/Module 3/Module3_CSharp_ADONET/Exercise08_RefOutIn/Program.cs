using System;

namespace Exercise08_RefOutIn
{
    internal class Program
    {
        // ref parameter
        static void Increment(ref int number)
        {
            number++;
        }

        // out parameter
        static void GetValues(out int a, out int b)
        {
            a = 100;
            b = 200;
        }

        // in parameter
        static void Display(in int value)
        {
            Console.WriteLine("Value received using 'in' : " + value);
        }

        static void Main(string[] args)
        {
            int x = 10;

            Console.WriteLine("Before ref: " + x);
            Increment(ref x);
            Console.WriteLine("After ref: " + x);

            int num1, num2;
            GetValues(out num1, out num2);
            Console.WriteLine("\nOut Values:");
            Console.WriteLine("num1 = " + num1);
            Console.WriteLine("num2 = " + num2);

            Console.WriteLine();
            Display(in x);
        }
    }
}