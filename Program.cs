using System;
using System.IO;
using System.Text.Json;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Get the directory of the executable
            string executableDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Construct the full path to the JSON file
            string jsonFilePath = "C:\\Users\\atash\\RiderProjects\\ConsoleApp1\\app_settings.json";
            string parentDirectory = Directory.GetParent(Directory.GetParent(executableDirectory).FullName).FullName;
            try
            {
                // Read the JSON file contents as a string
                string json = File.ReadAllText(jsonFilePath);

                // Base URL of the weather API
                string baseUrl = "https://archive-api.open-meteo.com/v1/archive";

                // Initialize the WeatherApiClient
                WeatherApiClient weatherApiClient = new WeatherApiClient(baseUrl);

                // Specify the parameters for weather data retrieval
                double latitude = 37.8267;
                double longitude = -122.4233;
                DateTime startDate = DateTime.Now.AddDays(-7);
                DateTime endDate = DateTime.Now;
                string fields = "temperature_2m,precipitation";
                try
                {
                    // Call GetWeatherData asynchronously and wait for the result
                    string weatherData =
                        await weatherApiClient.GetWeatherData(latitude, longitude, startDate, endDate, fields);

                    // Print the response to the console
                    Console.WriteLine(weatherData);
                    // parse the JSON string to a MyDataClass.WeatherObject object
                    MyDataClass.WeatherObject weatherObject =
                        JsonSerializer.Deserialize<MyDataClass.WeatherObject>(weatherData);
                    // now save the parsed data in a new JSON file in the resources folder
                    string newJsonFilePath = Path.Combine(parentDirectory, "resources", "weather_data.json");
                    File.WriteAllText(newJsonFilePath, weatherData);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions related to file reading
                Console.WriteLine($"Error reading JSON file: {ex.Message}");
            }
        }
    }
}