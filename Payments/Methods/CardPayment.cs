using Store.Payments;
using Store.Models;

namespace Store.Payments.Methods
{
    public class CardPayment : IPayment
    {
        public void Pay()
        {
            // estamos sem implementação no momento
        }

        public string ReturnComp(List<Product> Products)
        {

            string ProductsStr ="";
           foreach(var p in Products)
            {
                ProductsStr += p.Name;
            }

            return "Pagamento via cartao realizado com sucesso! Itens comprados: " + ProductsStr;
        }
    }
}