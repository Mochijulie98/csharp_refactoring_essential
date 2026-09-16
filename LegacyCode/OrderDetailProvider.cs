using System.Text.Json;

namespace LegacyCode;

public class OrderDetailProvider : IOrderDetailProvider
{
    private readonly HttpClient _httpClient = new HttpClient();

    public Order? FetchOrderDetails(int orderId)
    {
        var url = $"https://codemanship.co.uk/api/orders.php?orderId={orderId}";

        var response = _httpClient
            .GetAsync(url)
            .GetAwaiter()
            .GetResult();

        response.EnsureSuccessStatusCode();

        var json = response.Content
            .ReadAsStringAsync()
            .GetAwaiter()
            .GetResult();

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
            
        var order = JsonSerializer.Deserialize<Order>(json, options);
        return order;
    }
}