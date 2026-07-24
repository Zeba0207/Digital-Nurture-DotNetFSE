using System;

namespace Exercise21_PatternMatching
{
    internal class Program
    {
        static void DisplayInformation(object obj)
        {
            // Pattern Matching using 'is'
            if (obj is int number)
            {
                Console.WriteLine($"Integer Value : {number}");
            }
            else if (obj is string text)
            {
                Console.WriteLine($"String Value : {text}");
            }
            else if (obj is double value)
            {
                Console.WriteLine($"Double Value : {value}");
            }
            else
            {
                Console.WriteLine("Unknown Type");
            }

            // Pattern Matching using switch
            Console.WriteLine("Switch Result:");

            switch (obj)
            {
                case int n:
                    Console.WriteLine($"{n} is an Integer");
                    break;

                case string s:
                    Console.WriteLine($"\"{s}\" is a String");
                    break;

                case double d:
                    Console.WriteLine($"{d} is a Double");
                    break;

                default:
                    Console.WriteLine("Unsupported Type");
                    break;
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            DisplayInformation(100);

            DisplayInformation("Zeba");

            DisplayInformation(98.75);

            DisplayInformation(true);
        }
    }
}