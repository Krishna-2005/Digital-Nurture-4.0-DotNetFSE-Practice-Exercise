using System;
using System.Linq;
using EcommerceSearchFunction.Models;

namespace EcommerceSearchFunction
{
    class Program
    {
        // Linear Search
        static Product? LinearSearch(Product[] products, string name)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return product;
            }
            return null;
        }

        // Binary Search
        static Product? BinarySearch(Product[] products, string name)
        {
            int left = 0, right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = string.Compare(name, products[mid].ProductName, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                    return products[mid];
                else if (comparison < 0)
                    right = mid - 1;
                else
                    left = mid + 1;
            }
            return null;
        }

        static void Main(string[] args)
        {
            // sample product data
            Product[] products = new Product[]
            {
                new Product(1, "Laptop", "Electronics"),
                new Product(2, "Shoes", "Footwear"),
                new Product(3, "Watch", "Accessories"),
                new Product(4, "Phone", "Electronics"),
                new Product(5, "Bag", "Accessories"),
            };

            Console.WriteLine("Enter product name to search:");
            string input = Console.ReadLine() ?? "";

            // Linear Search
            Console.WriteLine("\nLinear Search:");
            var result1 = LinearSearch(products, input);
            if (result1 != null)
                Console.WriteLine($"Found: {result1.ProductName} (Category: {result1.Category})");
            else
                Console.WriteLine("Product not found.");

            // Binary Search
            Console.WriteLine("\nBinary Search:");
            var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
            var result2 = BinarySearch(sortedProducts, input);
            if (result2 != null)
                Console.WriteLine($"Found: {result2.ProductName} (Category: {result2.Category})");
            else
                Console.WriteLine("Product not found.");
        }
    }
}
