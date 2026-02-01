using Store.Payments;
using Store.Models;

namespace Store.Payments.Methods
{
    public class PixPayment : IPayment
    {
        public void Pay()
        {
            // estamos sem implementação real de pagamento ,nesse caso via Pix
        }

        public string ReturnComp(List<Product> Products)
        {   
            string ProductsStr ="";
           foreach(var p in Products)
            {
                ProductsStr += p.Name;
            }

            return "Pagamento via Pix realizado com sucesso.itens comprados: " + ProductsStr;
        }
    }
}