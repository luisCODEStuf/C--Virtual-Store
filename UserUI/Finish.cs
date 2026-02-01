using Store.Models;
using Store.Payments;
using Store.UI.SubUI;

namespace Store.UI;

public class FinishUI
{
    private readonly FinishSubUI _finishSubUI;
    public  List<Product> Products = new List<Product>();
    
    public FinishUI(FinishSubUI FinishClass, List<Product> products)
    {
        _finishSubUI = FinishClass;
        Products = products;
    }

    public void ShowFinishMenu()
    {
        while (true)
        {
            Console.WriteLine("\n--- Finish Menu ---");
            Console.WriteLine("1. Payment Method");
            Console.WriteLine("2. Descount Coupons");
            Console.WriteLine("3. Confirm Purchase");
            Console.WriteLine("4. Back to Main Menu");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice)
            {
                case "1":
                    _finishSubUI.SetPaymentMethod();
                    break;
                case "2":
                    _finishSubUI.ApplyDiscount(_finishSubUI.TotalAmount(Products));
                    break;
                case "3":
                    _finishSubUI.ComfirmPurchase(Products);
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