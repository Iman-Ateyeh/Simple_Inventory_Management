using InventoryManagement;
using System;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            while (true)
            {
                Console.WriteLine("\nInventory Management System");
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. View all products");
                Console.WriteLine("3. Edit a product");
                Console.WriteLine("4. Delete a product");
                Console.WriteLine("5. Search for a product");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        double priceValue = double.Parse(Console.ReadLine());
                        Console.WriteLine("Select currency:");
                        foreach (Currency currency in Enum.GetValues(typeof(Currency)))
                        {
                            Console.WriteLine($"{(int)currency}. {currency}");
                        }
                        Console.Write("Enter currency: ");
                        int currencyChoice = int.Parse(Console.ReadLine());
                        Currency selectedCurrency = (Currency)currencyChoice;
                        Price price = new Price(priceValue, selectedCurrency);
                        Console.Write("Enter product quantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        inventory.AddProduct(name, price, quantity);
                        break;
                    case 2:
                        inventory.ViewAllProducts();
                        break;
                    case 3:
                        inventory.EditProduct();
                        break;
                    case 4:
                        inventory.DeleteProduct();
                        break;
                    case 5:
                        inventory.SearchProduct();
                        break;
                    case 6:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                        break;
                }
            }
        }
    }
}
