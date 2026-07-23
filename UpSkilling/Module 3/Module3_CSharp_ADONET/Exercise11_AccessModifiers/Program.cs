using System;

namespace Exercise11_AccessModifiers
{
    class Person
    {
        public string Name = "Zeba";          // Accessible everywhere
        private int Age = 20;                 // Accessible only within Person
        protected string City = "Tenali";     // Accessible in derived classes

        public void ShowAge()
        {
            Console.WriteLine("Age : " + Age);
        }
    }

    class Student : Person
    {
        public void Display()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("City : " + City);

            // Console.WriteLine(Age); // Not allowed (private)
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine("Accessing from Derived Class:");
            student.Display();

            Console.WriteLine();

            Console.WriteLine("Accessing from Main:");
            Console.WriteLine("Name : " + student.Name);

            // Console.WriteLine(student.City); // Not allowed (protected)

            student.ShowAge();
        }
    }
}