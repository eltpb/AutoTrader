namespace BankAPI
{
    public interface IExecutionClient
    {
        void Buy(string productId, int quantity);
        void Sell(string productId, int quantity);
    }
}
