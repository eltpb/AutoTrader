namespace BankAPI
{
    public interface IPriceListener
    {
        void PriceTick(string productId, decimal price);
    }
}