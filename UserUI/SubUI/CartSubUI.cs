using Store.Models;

namespace Store.UI.SubUI;

public class CartSubUI
{
    private List<Product> cartItems = new List<Product>();

    public void SetList(Cart cart)
    {
        cartItems = cart.Products;
    }
    
    public void RemoveFromCart()
    {
        string Result = Console.ReadLine() ?? string.Empty;   
        var productId = cartItems.FirstOrDefault(p => p.Id.ToString() == Result);

        if (productId != null)
        {
            cartItems.Remove(productId);
            Console.WriteLine($"{productId.Name} has been removed from your cart.");
        }
        else
        {
            Console.WriteLine($"No product found in cart with ID: {productId}");
        }
    }
    public void AddToCart()
    {   
        string Result = Console.ReadLine() ?? string.Empty;
        var generateProducts = new GenerateProducts();
        var products = generateProducts.CreateSampleProducts();
        var product = products.FirstOrDefault(p => p.Id.ToString() == Result);

        if (product != null)
        {
            cartItems.Add(product);
            Console.WriteLine($"{product.Name} has been added to your cart.");
        }
        else
        {
            Console.WriteLine($"No product found with ID: {Result}");
        }
    }

    public void ViewCart()
    {
        if (cartItems.Count == 0)
        {
            Console.WriteLine("Your cart is empty.");
            return;
        }

        Console.WriteLine("Items in your cart:");
        foreach (var item in cartItems)
        {
            Console.WriteLine($"[{item.Id}] {item.Name} - R$ {item.Price:F2} \n");
        }

        decimal total = cartItems.Sum(p => p.Price);
        Console.WriteLine($"Total: R$ {total:F2}");
    }

    public void ClearCart()
    {
        cartItems.Clear();
        Console.WriteLine("Your cart has been cleared.");
    }
}