using System;

namespace Exercise22_Tuples
{
    internal class Program
    {
        // Method returning a tuple
        static (int Id, string Name) GetStudent()
        {
            return (101, "Zeba");
        }

        static void Main(string[] args)
        {
            // Deconstructing the tuple
            (int id, string name) = GetStudent();

            Console.WriteLine("Student Details");
            Console.WriteLine($"ID   : {id}");
            Console.WriteLine($"Name : {name}");

            Console.WriteLine();

            // Accessing tuple using property names
            var student = GetStudent();

            Console.WriteLine("Accessing Tuple Directly");
            Console.WriteLine($"ID   : {student.Id}");
            Console.WriteLine($"Name : {student.Name}");
        }
    }
}