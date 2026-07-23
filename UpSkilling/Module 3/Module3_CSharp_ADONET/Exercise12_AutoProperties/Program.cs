using System;

namespace Exercise12_AutoProperties
{
    class Product
    {
        // Auto-implemented property
        public string Name { get; set; }

        // Backing field
        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                    _price = value;
                else
                    Console.WriteLine("Price cannot be negative.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.Name = "Laptop";
            product.Price = 55000;

            Console.WriteLine("Product Name : " + product.Name);
            Console.WriteLine("Price        : " + product.Price);

            Console.WriteLine();

            Console.WriteLine("Trying to set a negative price...");
            product.Price = -1000;

            Console.WriteLine("Current Price: " + product.Price);
        }
    }
}