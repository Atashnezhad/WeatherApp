using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // run the some functionality
            // SomeFunctionality.Run();

            // Create an instance of the AppSettings class
            // Read the JSON file
            string json = File.ReadAllText("appsettings.json");

            // Deserialize the JSON into an AppSettings object
            AppSettings appSettings = JsonSerializer.Deserialize<AppSettings>(json);

            // Access the connection string property
            string connectionString = appSettings.ConnectionStrings.DatabaseConnection;

            string apiUrl = connectionString; // Replace this with your actual API URL
            // make an instance of the ApiHandler class
            ApiHandler apiHandler = new ApiHandler();
            List<MyDataClass.Person> persons = await apiHandler.GetPersonsFromApi(apiUrl);

            if (persons != null)
            {
                foreach (MyDataClass.Person person in persons)
                {
                    Console.WriteLine($"Id: {person.name}, Name: {person.age}, Age: {person.emailAddress}");
                }
            }
        }
    }
}