using System.Text.Json;
using TronScanApi;

public class Program
{
    private static async Task Main(string[] args)
    {
        string url = $"https://apilist.tronscanapi.com/api/transaction-info?hash=853793d552635f533aa982b92b35b00e63a1c1add062c099da2450a15119bcb2";

        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Выполняем GET-запрос
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Вызывает исключение, если статус ответа не 2xx

                // Получаем содержимое ответа
                string responseBody = await response.Content.ReadAsStringAsync();
                var root = JsonSerializer.Deserialize<Root>(responseBody);

                root!.PrintTransactionRisk();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
        }
    }
}