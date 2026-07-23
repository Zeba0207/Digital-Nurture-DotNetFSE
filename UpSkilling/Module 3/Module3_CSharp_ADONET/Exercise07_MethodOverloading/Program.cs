using System;

namespace Exercise07_MethodOverloading
{
    internal class Program
    {
        // Method with two integers
        static int CalculateTotal(int a, int b)
        {
            return a + b;
        }

        // Method with three doubles
        static double CalculateTotal(double a, double b, double c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            int total1 = CalculateTotal(10, 20);
            double total2 = CalculateTotal(10.5, 20.3, 30.2);

            Console.WriteLine("Total (2 Integers): " + total1);
            Console.WriteLine("Total (3 Doubles): " + total2);
        }
    }
}