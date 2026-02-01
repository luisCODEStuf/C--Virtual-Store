namespace Store.Models
{
    using Store.Payments;
    public class Order
    {
        public bool FinishOrder(IPayment paymentMethod,Cart cart,List<Product> products)
        {   

            paymentMethod.Pay();
            string comp = paymentMethod.ReturnComp(products);
            Console.WriteLine(comp);
            return true;
            /*poderiamos ter verificação de saldo etc.
             mas como ja fiz isso milhares de vezes, vou simplificar*/
        }
    }
}