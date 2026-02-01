using Store.Models;

namespace Store.Payments;

public interface IPayment
{
    void Pay();
    string ReturnComp(List<Product> Products);
}