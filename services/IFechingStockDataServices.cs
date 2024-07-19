namespace services;

public interface IFechingStockDataServices
{
    Task<string> gettingStockPrice(string comp);
}