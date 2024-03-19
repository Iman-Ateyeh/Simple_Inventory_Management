using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Inventory
    {
        private List<Product> products;
        private int nextID;

        public void AddProduct(string name, double price, int quantity)
        {
            products.Add(new Product(nextID, name, price, quantity));
            Console.WriteLine($"{quantity} {name} were added successfully.");
            nextID++;
        }

        public void ViewAllProducts()
        {
            Console.WriteLine("\nAll products:");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.id}, Name: {product.name}, Price: {product.price}, Quantity: {product.quantity}");
            }
        }
    }
}
