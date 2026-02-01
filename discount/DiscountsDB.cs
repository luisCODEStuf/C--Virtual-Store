
namespace Store.Discounts.Database;

public class DiscountsDB
{   
    Dictionary<int,decimal> discountsList =new Dictionary<int, decimal>
        {
            { 120934, 0.10m }, 
            { 212394, 0.15m }, 
            { 393748, 0.05m }, 
            { 419843, 0.20m }, 
            { 523401, 0.12m }  
        };
    public Dictionary<int, decimal> GetDiscounts()
    {
        return discountsList;
    }
    public decimal GetDiscountByCode(int code)
    {
        if (discountsList.TryGetValue(code, out decimal discount))
        {
            return discount;
        }
        return 0m; 
    }
}