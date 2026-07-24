using System;
using System.Collections.Generic;

namespace Exercise19_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a List
            List<string> fruits = new List<string>();

            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Mango");
            fruits.Add("Orange");

            Console.WriteLine("List of Fruits:");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Remove an item
            fruits.Remove("Banana");

            Console.WriteLine("\nAfter Removing Banana:");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Create a Dictionary
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(101, "Zeba");
            students.Add(102, "Rahul");
            students.Add(103, "Ayesha");

            Console.WriteLine("\nStudent Dictionary:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }

            // Remove an entry
            students.Remove(102);

            Console.WriteLine("\nAfter Removing Student ID 102:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }
        }
    }
}