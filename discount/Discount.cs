using Store.Discounts.Database;
namespace Store.Discounts
{
    public class Discount
    {
        public decimal ApplyDiscount(decimal price, int Code)
        {
            DiscountsDB discountsDB = new DiscountsDB();
            var discountPercentage = discountsDB.GetDiscountByCode(Code);

            return price - (price * discountPercentage);
        }
    }
}