using Store.Models;
using Store.UI.SubUI;

namespace Store.UI;

public class ProductsUI
{
    private readonly ProductsSubUI _productsSubUI;
    private  Cart _cart ;

    public ProductsUI(Cart cart)
    {
        _productsSubUI = new ProductsSubUI();
        _cart = cart;
    }

    public void ShowProductsMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Products Menu ---");
            Console.WriteLine("1. List All Products");
            Console.WriteLine("2. List Products by Category");
            Console.WriteLine("3. Search Product");
            Console.WriteLine("4. Back to Main Menu");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice)
            {
                case "1":
                    _productsSubUI.ListProducts();
                    break;
                case "2":
                    Console.Write("Enter category: ");
                    _productsSubUI.ListProductsByCategory();
                    break;
                case "3":
                    Console.Write("Enter product name or ID to search: ");
                    _productsSubUI.Search(_cart);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}