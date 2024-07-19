using Newtonsoft.Json.Linq;

namespace services;

public class FechingStockDataServices : IFechingStockDataServices
{

    private IHttpClientFactory httpClientFactory;

    public FechingStockDataServices(IHttpClientFactory _httpClientFactory)
    {
        this.httpClientFactory = _httpClientFactory;
    }

    public async Task<string> gettingStockPrice(string comp)
    {
        string Comp_symple = "";

        using (HttpClient cli = httpClientFactory.CreateClient())
        {

            HttpRequestMessage msg2 = new HttpRequestMessage(HttpMethod.Get,
                "https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords=" + comp +
                "&apikey=L9UTMSALX53PE0Q9");

            HttpResponseMessage res = await cli.SendAsync(msg2);


            string responseBody = await res.Content.ReadAsStringAsync();

            JObject json = JObject.Parse(responseBody);

            Comp_symple = json["bestMatches"][0]["1. symbol"].ToString();

        }

        return Comp_symple;

    }
}