using System;

namespace Exercise03_PrimaryConstructors
{
    public class Person(string firstName, string lastName, int age)
    {
        public string FirstName { get; } = firstName;
        public string LastName { get; } = lastName;
        public int Age { get; } = age;

        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {FirstName} {LastName}");
            Console.WriteLine($"Age  : {Age}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Zeba", "Fathima", 20);
            person.DisplayInfo();
        }
    }
}