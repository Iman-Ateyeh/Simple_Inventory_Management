using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Product
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private double Price { get; set; }
        private int Quantity { get; set; }
       


        public  Product(int id, string name, double price, int quantity)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price; 
            this.Quantity = quantity;
        }

    }
}
