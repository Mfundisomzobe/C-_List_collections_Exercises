using Searching_and_Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_and_filtering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>();

            products.AddRange(new Product[]
                                           {
                                            new Product(1, "Laptop", 999.99m, "Electronics"),
                                            new Product(2, "Coffee Mug", 12.99m, "Kitchen"),
                                            new Product(3, "Mouse", 24.99m, "Electronics"),
                                            new Product(4, "Book", 15.99m, "Education"),
                                            new Product(5, "Keyboard", 79.99m, "Electronics"),
                                            new Product(6, "Pen", 2.99m, "Office"),
                                            new Product(7, "Desk", 299.99m, "Furniture")
                                            });



            // Exercise 2.1: Find a product by name
            // TODO: Search for "Mouse" and display it
            Console.WriteLine("Products by Name");
            Console.WriteLine("--------------------");
            Product productSeach = products.FirstOrDefault(p => p.Name == "Mouse");
            Console.WriteLine(productSeach.Name);
            Console.WriteLine();



            // Exercise 2.2: Find all products in "Electronics" categoryand display them
            Console.WriteLine("Electrinics Products");
            Console.WriteLine("--------------------");
            var prod_Find = products.FindAll(p => p.Category == "Electronics");
            foreach (Product product in prod_Find)
            {
                Console.WriteLine(product.Name);
            }


            // Exercise 2.3: Check if a product exists
            // TODO: Check if a product with price > 1000 exists
            Console.WriteLine(" Check if a product exists");
            Console.WriteLine("---------------------------");
            var exists = products.Exists(p => p.Price > 1000);
            Console.WriteLine(exists);


            // Exercise 2.4: Get expensive products (price > 50)
            // TODO: Use Where() to get expensive products
            Console.WriteLine(" Get expensive products");
            Console.WriteLine("-------------------------");
            var ExpensiveProd = products.Where(p => p.Price > 50);
            foreach(Product product in ExpensiveProd)
            {
                Console.WriteLine(product.Name);
            }
            Console.WriteLine();

            // Exercise 2.5: Find product with highest price
            // TODO: Use Max() or OrderByDescending() + First()
            Console.WriteLine(" Get expensive products");
            Console.WriteLine("-------------------------");
            var HighestPrice = products.Max(p => p.Price);

            Console.WriteLine(HighestPrice);


            Console.ReadLine();
        }
    }
}
