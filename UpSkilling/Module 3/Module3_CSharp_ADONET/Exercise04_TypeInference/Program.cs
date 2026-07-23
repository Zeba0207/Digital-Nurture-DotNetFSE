using System;

namespace Exercise04_TypeInference
{
    class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 100;
            var text = "Hello C#";
            var student = new Student("Zeba");

            Console.WriteLine($"Value : {number}, Type : {number.GetType()}");
            Console.WriteLine($"Value : {text}, Type : {text.GetType()}");
            Console.WriteLine($"Value : {student.Name}, Type : {student.GetType()}");
        }
    }
}