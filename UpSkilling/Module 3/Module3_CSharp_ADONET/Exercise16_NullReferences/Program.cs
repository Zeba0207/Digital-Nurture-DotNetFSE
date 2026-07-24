using System;

namespace Exercise16_NullReferences
{
    class Person
    {
        public string? Name { get; set; }
        public string? City { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Object with values
            Person person1 = new Person
            {
                Name = "Zeba",
                City = "Tenali"
            };

            // Object with null values
            Person? person2 = null;

            Console.WriteLine("Person 1 Details");
            Console.WriteLine("Name : " + (person1.Name ?? "Not Available"));
            Console.WriteLine("City : " + (person1.City ?? "Not Available"));

            Console.WriteLine();

            Console.WriteLine("Person 2 Details");
            Console.WriteLine("Name : " + (person2?.Name ?? "Not Available"));
            Console.WriteLine("City : " + (person2?.City ?? "Not Available"));

            Console.WriteLine();

            if (person2 == null)
            {
                Console.WriteLine("Person2 object is null.");
            }
        }
    }
}