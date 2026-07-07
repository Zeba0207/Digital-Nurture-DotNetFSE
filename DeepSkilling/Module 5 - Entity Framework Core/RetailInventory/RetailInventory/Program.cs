using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.DTOs;

namespace RetailInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            var products = context.Products
                .Include(p => p.Category)
                .Select(p => new ProductDTO
                {
                    Name = p.Name,
                    Price = p.Price,
                    CategoryName = p.Category.Name
                })
                .ToList();

            Console.WriteLine("Product DTOs:");
            Console.WriteLine();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - ₹{product.Price} - {product.CategoryName}");
            }

            Console.ReadKey();
        }
    }
}