using System;

namespace Exercise18_RequiredModifier
{
    class Student
    {
        public required int Id { get; set; }

        public required string Name { get; set; }

        public string Course { get; set; } = "Information Technology";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Id = 101,
                Name = "Zeba"
            };

            Console.WriteLine("Student Details");
            Console.WriteLine("ID      : " + student.Id);
            Console.WriteLine("Name    : " + student.Name);
            Console.WriteLine("Course  : " + student.Course);
        }
    }
}