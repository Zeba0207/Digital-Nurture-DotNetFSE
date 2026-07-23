using System;

namespace Exercise09_LocalFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 15;
            int number2 = 25;

            // Local Function
            int Add(int a, int b)
            {
                return a + b;
            }

            // Local Function
            int Multiply(int a, int b)
            {
                return a * b;
            }

            int sum = Add(number1, number2);
            int product = Multiply(number1, number2);

            Console.WriteLine("First Number : " + number1);
            Console.WriteLine("Second Number: " + number2);
            Console.WriteLine("Sum          : " + sum);
            Console.WriteLine("Product      : " + product);
        }
    }
}