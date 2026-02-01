using Store.UI;
using Store.UI.SubUI;
using Store.Models;

namespace Store;

public class Program
{
        public static void Main(string[] args)
    {  
        var cartModel = new Cart();
        var cart = new CartUI(cartModel);
        List<Product> products = new List<Product>();
       var app = new MenuUI(new ProductsUI(cartModel),cart, new FinishUI(new FinishSubUI(),cartModel.Products));
       app.ShowMainMenu();
    }
}