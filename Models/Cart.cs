using System.Collections.Generic;
namespace Store.Models
{
    public class Cart
    {   

        public List<Product> Products = new List<Product>();
        public decimal TotalPrice()
        {
            decimal total = 0;
            foreach (var product in Products)
            {
                total += product.Price;
            }
            return total;
        }
    }
}