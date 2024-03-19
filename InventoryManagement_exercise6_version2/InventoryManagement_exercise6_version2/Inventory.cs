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

        public void AddProduct(string name, Price price, int quantity)
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

        public void EditProduct()
        {
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();
            Product product = products.Find(p => p.name == productName);
            if (product != null)
            {
                Console.WriteLine("What would you like to update?");
                Console.WriteLine("1. Name");
                Console.WriteLine("2. Price");
                Console.WriteLine("3. Quantity");
                Console.WriteLine("4. All of the above");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter new name: ");
                        product.name = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Enter new price: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.WriteLine("Select currency:");
                        foreach (Currency currency in Enum.GetValues(typeof(Currency)))
                        {
                            Console.WriteLine($"{(int)currency}. {currency}");
                        }
                        Console.Write("Enter currency: ");
                        int currencyChoice = int.Parse(Console.ReadLine());
                        Currency selectedCurrency = (Currency)currencyChoice;
                        product.price = new Price(price, selectedCurrency);
                        break;
                    case 3:
                        Console.Write("Enter new quantity: ");
                        product.quantity = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("Enter new name: ");
                        product.name = Console.ReadLine();
                        Console.Write("Enter new price: ");
                        double newPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine("Select currency:");
                        foreach (Currency currency in Enum.GetValues(typeof(Currency)))
                        {
                            Console.WriteLine($"{(int)currency}. {currency}");
                        }
                        Console.Write("Enter currency: ");
                        int newCurrencyChoice = int.Parse(Console.ReadLine());
                        Currency newSelectedCurrency = (Currency)newCurrencyChoice;
                        product.price = new Price(newPrice, newSelectedCurrency);

                        Console.Write("Enter new quantity: ");
                        product.quantity = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void DeleteProduct()
        {
            Console.WriteLine("\nDeleting a product:");
            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();
            Product product = products.Find(p => p.name == productName);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}
