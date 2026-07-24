using System;
using System.IO;
using System.Text;

namespace Exercise25_FileStreamMemoryStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "sample.txt";

            // Create a sample file
            File.WriteAllText(filePath,
                "Welcome to Cognizant.\nLearning C# File Handling.");

            // -----------------------------
            // Read using FileStream
            // -----------------------------
            Console.WriteLine("Reading File using FileStream\n");

            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fs.Length];

                fs.Read(buffer, 0, buffer.Length);

                string content = Encoding.UTF8.GetString(buffer);

                Console.WriteLine(content);
            }

            Console.WriteLine();

            // -----------------------------
            // Write using MemoryStream
            // -----------------------------
            Console.WriteLine("Writing to MemoryStream\n");

            using (MemoryStream ms = new MemoryStream())
            {
                byte[] data = Encoding.UTF8.GetBytes("Learning MemoryStream in C#");

                ms.Write(data, 0, data.Length);

                Console.WriteLine($"Bytes Written : {ms.Length}");

                ms.Position = 0;

                byte[] output = ms.ToArray();

                Console.WriteLine("MemoryStream Content:");
                Console.WriteLine(Encoding.UTF8.GetString(output));
            }
        }
    }
}