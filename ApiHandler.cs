using System.Net.Http;
using System.Text.Json;
using System.Collections.Generic; // Add this for List<T> usage

namespace ConsoleApp1
{
    public class ApiHandler
    {
        // constructor
        public ApiHandler()
        {
            // You can initialize any resources or settings here
            // For example, you might configure HttpClient settings
            Console.WriteLine("ApiHandler instance created");
        }

        public async Task<List<MyDataClass.Person>> GetPersonsFromApi(string apiUrl)
        {
            List<MyDataClass.Person> persons = null;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    persons = JsonSerializer.Deserialize<List<MyDataClass.Person>>(json);
                }
                else
                {
                    Console.WriteLine($"Failed to retrieve data. Status code: {response.StatusCode}");
                }
            }

            return persons;
        }
    }
}