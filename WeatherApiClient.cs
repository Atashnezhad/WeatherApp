using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WeatherApiClient
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://archive-api.open-meteo.com/v1/archive";

        public WeatherApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetWeatherData(double latitude, double longitude, DateTime startDate,
            DateTime endDate, string fields)
        {
            string url =
                $"{BaseUrl}?latitude={latitude}&longitude={longitude}&start_date={startDate:yyyy-MM-dd}&end_date={endDate:yyyy-MM-dd}&hourly={fields}";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Throw an exception if the status code indicates an error
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                // Handle request errors
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
    }
}