using System;
using System.Net;

namespace Exercise29_InputSanitization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your comment: ");
            string? userInput = Console.ReadLine();

            // Handle null input
            userInput ??= string.Empty;

            // Encode HTML special characters
            string sanitizedInput = WebUtility.HtmlEncode(userInput);

            Console.WriteLine("\nOriginal Input:");
            Console.WriteLine(userInput);

            Console.WriteLine("\nSanitized Input:");
            Console.WriteLine(sanitizedInput);

            Console.WriteLine("\nInput sanitized successfully.");
        }
    }
}