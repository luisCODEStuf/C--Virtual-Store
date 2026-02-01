using Store.Payments;
using Store.Models;

namespace Store.Payments.Methods
{
    public class TicketPayment : IPayment
    {
        public void Pay()
        {
            // estamos sem implementação no momento
        }

        public string ReturnComp(List<Product> Products)
        {
            string ProductsStr = "";
           foreach(var p in Products)
            {
                ProductsStr += p.Name;
            }
            return $"Boleto gerado com sucesso! numero do boleto: {CreateTicketNumber()}. Itens comprados: {ProductsStr}";
        }
        
        private string CreateTicketNumber()
        {
            var rdn = new Random();
            return rdn.Next(100000000, 999999999).ToString();
        }
    }
}