using EFCore.BulkExtensions;
using RetailInventory.Data;
using RetailInventory.Models;

namespace RetailInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AppDbContext();

            // Bulk Update
            var products = context.Products.ToList();

            foreach (var product in products)
            {
                product.Price += 100;
            }

            context.BulkUpdate(products);

            Console.WriteLine("Bulk Update Completed!");

            // Bulk Delete
            var deleteProducts = context.Products
                                        .Where(p => p.Price > 5000)
                                        .ToList();

            context.BulkDelete(deleteProducts);

            Console.WriteLine("Bulk Delete Completed!");

            Console.ReadKey();
        }
    }
}