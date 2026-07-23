using System;

namespace Exercise02_ValueVsReference
{
    class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }
    }

    internal class Program
    {
        static void ModifyValue(int number)
        {
            number = 100;
        }

        static void ModifyReference(Person person)
        {
            person.Name = "Bob";
        }

        static void Main(string[] args)
        {
            int value = 10;
            Person person = new Person("Alice");

            Console.WriteLine("Before Method Call:");
            Console.WriteLine("Value Type = " + value);
            Console.WriteLine("Reference Type = " + person.Name);

            ModifyValue(value);
            ModifyReference(person);

            Console.WriteLine("\nAfter Method Call:");
            Console.WriteLine("Value Type = " + value);
            Console.WriteLine("Reference Type = " + person.Name);
        }
    }
}