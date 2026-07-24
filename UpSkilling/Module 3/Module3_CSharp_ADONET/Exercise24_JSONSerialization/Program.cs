using System;
using System.IO;
using System.Text.Json;

namespace Exercise24_JSONSerialization
{
    public class User
    {
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public string Email { get; set; } = "";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create User object
            User user = new User
            {
                Name = "Zeba",
                Age = 20,
                Email = "zeba@gmail.com"
            };

            // File path
            string filePath = "user.json";

            // Serialize object to JSON
            string json = JsonSerializer.Serialize(user, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            // Save JSON to file
            File.WriteAllText(filePath, json);

            Console.WriteLine("User object serialized successfully.");
            Console.WriteLine();

            Console.WriteLine("JSON File Content:");
            Console.WriteLine(File.ReadAllText(filePath));

            Console.WriteLine();

            // Deserialize JSON back to object
            string jsonData = File.ReadAllText(filePath);

            User? deserializedUser = JsonSerializer.Deserialize<User>(jsonData);

            Console.WriteLine("Deserialized User Details");

            Console.WriteLine($"Name  : {deserializedUser?.Name}");
            Console.WriteLine($"Age   : {deserializedUser?.Age}");
            Console.WriteLine($"Email : {deserializedUser?.Email}");
        }
    }
}