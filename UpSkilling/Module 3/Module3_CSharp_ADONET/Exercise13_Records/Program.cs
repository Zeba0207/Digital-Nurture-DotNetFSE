using System;

namespace Exercise13_Records
{
    // Record with init-only properties
    public record Employee
    {
        public int Id { get; init; }
        public string Name { get; init; } = "";
        public string Department { get; init; } = "";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an immutable record
            Employee employee1 = new Employee
            {
                Id = 101,
                Name = "Zeba",
                Department = "Information Technology"
            };

            Console.WriteLine("Original Employee");
            Console.WriteLine($"ID         : {employee1.Id}");
            Console.WriteLine($"Name       : {employee1.Name}");
            Console.WriteLine($"Department : {employee1.Department}");

            Console.WriteLine();

            // Create a modified copy using with expression
            Employee employee2 = employee1 with
            {
                Department = "Software Development"
            };

            Console.WriteLine("Modified Employee");
            Console.WriteLine($"ID         : {employee2.Id}");
            Console.WriteLine($"Name       : {employee2.Name}");
            Console.WriteLine($"Department : {employee2.Department}");

            Console.WriteLine();

            Console.WriteLine("Original Employee After Modification");
            Console.WriteLine($"ID         : {employee1.Id}");
            Console.WriteLine($"Name       : {employee1.Name}");
            Console.WriteLine($"Department : {employee1.Department}");
        }
    }
}