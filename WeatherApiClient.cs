using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WeatherApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public WeatherApiClient(string baseUrl)
        {
            this._httpClient = new HttpClient();
            this._baseUrl = baseUrl;
        }

        public async Task<string> GetWeatherData(double latitude, double longitude, DateTime startDate,
            DateTime endDate, string fields)
        {
            string url =
                $"{this._baseUrl}?latitude={latitude}&longitude={longitude}&start_date={startDate:yyyy-MM-dd}&end_date={endDate:yyyy-MM-dd}&hourly={fields}";

            try
            {
                HttpResponseMessage response = await this._httpClient.GetAsync(url);
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