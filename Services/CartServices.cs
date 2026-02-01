using Store.Models;

namespace Store.Services;
public class CartServices
{   
    //bools because we may have future validations
    public bool AddProduct(Cart cart, Product product)
    {
        cart.Products.Add(product);
        return true;
    }

    public bool RemoveProduct(Cart cart, Product product)
    {
        cart.Products.Remove(product);
        return true;
    }

}