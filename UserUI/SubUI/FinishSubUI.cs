using Store.Payments;
using Store.Payments.Methods;
using Store.Discounts.Database;
using Store.Models;

namespace Store.UI.SubUI;

public class FinishSubUI
{   
    private IPayment _paymentMethod ;

    private decimal _totalAmount;

        public void SetPaymentMethod()
    {
        Console.WriteLine("Select a payment method:");
        Console.WriteLine("1. Credit Card");
        Console.WriteLine("2. Pix");
        Console.WriteLine("3. Ticket Payment");

        string choice = Console.ReadLine() ?? string.Empty;

        switch (choice)
        {
            case "1":
                Console.WriteLine("You have selected Credit Card as your payment method.");
            _paymentMethod = new CardPayment();
                break;
                
            case "2":
                Console.WriteLine("You have selected Pix as your payment method.");
                _paymentMethod = new PixPayment();
                break;
            case "3":
                Console.WriteLine("You have selected Ticket Payment as your payment method.");
                _paymentMethod = new TicketPayment();
                break;
            default:
                Console.WriteLine("Invalid selection. Please try again.");
                break;
        }
    } 
    
    public  decimal TotalAmount(List<Product> Products)
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }
        Console.WriteLine($"Total amount: R$ {total:F2}");
        _totalAmount = total;
        return total;
    }
    public decimal ApplyDiscount(decimal totalAmount)
    {
        Console.WriteLine("Do you have a discount code? (yes/no)");
        string hasCode = Console.ReadLine() ?? string.Empty;

        if (hasCode.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Please enter your discount code:");
            string discountCode = Console.ReadLine() ?? string.Empty;
            DiscountsDB discountsDB = new DiscountsDB();
            int.TryParse(discountCode, out int discountCodeInt);
            var discountCodes = discountsDB.GetDiscountByCode(discountCodeInt);

            if (discountCodes > 0)
            {
                decimal discountAmount = totalAmount * discountCodes;
                decimal newTotal = totalAmount - discountAmount;
                Console.WriteLine($"Discount applied! You saved R$ {discountAmount:F2}. New total is R$ {newTotal:F2}.");
                return newTotal;
            }
            else
            {
                Console.WriteLine("Invalid discount code. No discount applied.");
            }
        }
        return totalAmount;
    }

    public void ComfirmPurchase(List<Product> Products)
    {
        Console.WriteLine("Do you want to confirm the purchase? (yes/no)");
        string confirm = Console.ReadLine() ?? string.Empty;
        if(Products.Count == 0)
        {
            Console.WriteLine("No products selected for purchase.");
            return;
        }
        if(_paymentMethod != null)
        {
            
        if (confirm.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {   
            _paymentMethod.Pay();
            Console.WriteLine(_paymentMethod.ReturnComp(Products));
        }
        else
        {
            Console.WriteLine("Purchase cancelled.");
        }

        }
        else
        {
            Console.WriteLine("please select a payment method before");
        } 
    }
}