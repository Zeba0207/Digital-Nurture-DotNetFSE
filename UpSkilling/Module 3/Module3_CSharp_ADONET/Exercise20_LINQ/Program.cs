using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise20_LINQ
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Marks { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id = 101, Name = "Zeba", Marks = 92 },
                new Student { Id = 102, Name = "Rahul", Marks = 65 },
                new Student { Id = 103, Name = "Ayesha", Marks = 81 },
                new Student { Id = 104, Name = "Kiran", Marks = 55 },
                new Student { Id = 105, Name = "Sneha", Marks = 75 }
            };

            // Filter students with marks >= 75
            var topStudents = students.Where(s => s.Marks >= 75);

            Console.WriteLine("Students with Marks >= 75");

            foreach (var student in topStudents)
            {
                Console.WriteLine($"{student.Id} - {student.Name} - {student.Marks}");
            }

            Console.WriteLine();

            // Project only student names
            var studentNames = students.Select(s => s.Name);

            Console.WriteLine("Student Names");

            foreach (var name in studentNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}