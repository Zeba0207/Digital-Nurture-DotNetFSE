using System;

namespace Exercise17_NullConditionalChaining
{
    class Contact
    {
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Contact contact1 = new Contact
            {
                Name = "Zeba",
                PhoneNumber = "9876543210"
            };

            Contact? contact2 = null;

            Console.WriteLine("Contact 1");
            Console.WriteLine("Name  : " + (contact1?.Name ?? "Not Available"));
            Console.WriteLine("Phone : " + (contact1?.PhoneNumber ?? "Not Available"));

            Console.WriteLine();

            Console.WriteLine("Contact 2");
            Console.WriteLine("Name  : " + (contact2?.Name ?? "Not Available"));
            Console.WriteLine("Phone : " + (contact2?.PhoneNumber ?? "Not Available"));

            Console.WriteLine();

            Contact contact3 = new Contact();

            Console.WriteLine("Contact 3");
            Console.WriteLine("Name  : " + (contact3?.Name ?? "Not Available"));
            Console.WriteLine("Phone : " + (contact3?.PhoneNumber ?? "Not Available"));
        }
    }
}