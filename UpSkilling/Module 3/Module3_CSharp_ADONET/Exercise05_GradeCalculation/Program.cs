using System;

namespace Exercise05_GradeCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your score (0-100): ");
            int score = Convert.ToInt32(Console.ReadLine());

            // Using if-else
            if (score >= 90)
                Console.WriteLine("Grade (if-else): A");
            else if (score >= 80)
                Console.WriteLine("Grade (if-else): B");
            else if (score >= 70)
                Console.WriteLine("Grade (if-else): C");
            else if (score >= 60)
                Console.WriteLine("Grade (if-else): D");
            else
                Console.WriteLine("Grade (if-else): F");

            // Using switch with pattern matching
            string grade = score switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                >= 0 => "F",
                _ => "Invalid Score"
            };

            Console.WriteLine("Grade (switch): " + grade);
        }
    }
}