using Store.Models;
using Store.UI;

namespace Store.UI;

public class MenuUI
{
    private readonly ProductsUI _productsUI;
    private readonly CartUI _cartUI;
    private readonly FinishUI _finishUI;

    public MenuUI(ProductsUI productsUI, CartUI cartUI, FinishUI finishUI)
    {
        _productsUI = productsUI;
        _cartUI = cartUI;
        _finishUI = finishUI;
    }

    public void ShowMainMenu()
    {
        while (true)
        {   
            Console.Clear();
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. Products");
            Console.WriteLine("2. Cart");
            Console.WriteLine("3. Finish");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice)
            {
                case "1":
                    _productsUI.ShowProductsMenu();
                    break;
                case "2":
                    _cartUI.ShowCartMenu();
                    break;
                case "3":
                    _finishUI.ShowFinishMenu();
                    break;
                case "4":
                    Console.WriteLine("Exiting the application. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}