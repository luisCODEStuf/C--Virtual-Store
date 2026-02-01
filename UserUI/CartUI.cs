using Store.Models;
using Store.UI.SubUI;

namespace Store.UI;

public class CartUI
{
    private readonly CartSubUI _cartSubUI;

    public CartUI(Cart cart)
    {
        _cartSubUI = new CartSubUI();
        _cartSubUI.SetList(cart);
    }

    public void ShowCartMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Cart Menu ---");
            Console.WriteLine("1. View Cart Items");
            Console.WriteLine("2. Remove Item from Cart");
            Console.WriteLine("3. clear");
            Console.WriteLine("4. Back to Main Menu");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice)
            {
                case "1":
                    _cartSubUI.ViewCart();
                    break;
                case "2":
                    Console.Write("Enter product ID to remove: ");
                    _cartSubUI.RemoveFromCart();
                    break;
                case "3":
                    _cartSubUI.ClearCart();
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