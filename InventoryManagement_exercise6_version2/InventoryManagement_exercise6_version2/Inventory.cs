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
        private int nextId;

        public void AddProduct(string name, double price, int quantity)
        {
            products.Add(new Product(nextId, name, price, quantity));
            Console.WriteLine($"{quantity} {name} were added successfully.");
            nextId++;
        }



    }
}
