using Store.Models;
using System.Collections.Generic;

namespace Store.Models
{
    using Store.Payments;
    public class GenerateProducts
    {
        public List<Product> CreateSampleProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99m, Category = "Electronics" },
                new Product { Id = 2, Name = "Smartphone", Price = 499.99m, Category = "Electronics" },
                new Product { Id = 3, Name = "Tablet", Price = 299.99m, Category = "Electronics" },
                new Product { Id = 4, Name = "Gaming Laptop", Price = 1499.99m, Category = "Electronics" },
                new Product { Id = 5, Name = "Wireless Earbuds", Price = 199.99m, Category = "Accessories" },
                new Product { Id = 6, Name = "4K Monitor", Price = 399.99m, Category = "Electronics" },
                new Product { Id = 7, Name = "Mechanical Keyboard", Price = 129.99m, Category = "Accessories" },
                new Product { Id = 8, Name = "Gaming Mouse", Price = 89.99m, Category = "Accessories" },
                new Product { Id = 9, Name = "Smart TV", Price = 799.99m, Category = "Electronics" },
                new Product { Id = 10, Name = "Action Camera", Price = 299.99m, Category = "Electronics" },
                new Product { Id = 11, Name = "Fitness Tracker", Price = 149.99m, Category = "Wearables" },
                new Product { Id = 12, Name = "Electric Kettle", Price = 39.99m, Category = "Home Appliances" },
                new Product { Id = 13, Name = "Blender", Price = 59.99m, Category = "Home Appliances" },
                new Product { Id = 14, Name = "Coffee Maker", Price = 89.99m, Category = "Home Appliances" },
                new Product { Id = 15, Name = "Air Fryer", Price = 129.99m, Category = "Home Appliances" },
                new Product { Id = 16, Name = "Vacuum Cleaner", Price = 199.99m, Category = "Home Appliances" },
                new Product { Id = 17, Name = "Smart Thermostat", Price = 249.99m, Category = "Home Automation" },
                new Product { Id = 18, Name = "Security Camera", Price = 99.99m, Category = "Home Security" },
                new Product { Id = 19, Name = "Smart Light Bulb", Price = 19.99m, Category = "Home Automation" },
                new Product { Id = 20, Name = "Wireless Router", Price = 59.99m, Category = "Networking" },
                new Product { Id = 21, Name = "Gaming Chair", Price = 249.99m, Category = "Furniture" },
                new Product { Id = 22, Name = "Office Desk", Price = 199.99m, Category = "Furniture" },
                new Product { Id = 23, Name = "Bookshelf", Price = 149.99m, Category = "Furniture" },
                new Product { Id = 24, Name = "Desk Organizer", Price = 29.99m, Category = "Office Supplies" },
                new Product { Id = 25, Name = "Notebook", Price = 5.99m, Category = "Stationery" },
                new Product { Id = 26, Name = "Pen Set", Price = 9.99m, Category = "Stationery" },
                new Product { Id = 27, Name = "Art Supplies", Price = 29.99m, Category = "Stationery" },
                new Product { Id = 28, Name = "Board Game", Price = 39.99m, Category = "Toys" },
                new Product { Id = 29, Name = "Puzzle", Price = 19.99m, Category = "Toys" },
                new Product { Id = 30, Name = "Action Figure", Price = 14.99m, Category = "Toys" }
            };
        }
    }
}
/*

categories:
-Electronics
-Accessories
-Wearables
-Home Appliances
-Home Automation
-Home Security
-Networking
-Furniture
-Office Supplies
-Stationery
-Toys

*/