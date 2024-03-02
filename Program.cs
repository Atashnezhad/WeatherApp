using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // // Create an instance of the Person class
            // MyDataClass.Person person = new MyDataClass.Person
            // {
            //     Name = "John Doe",
            //     Age = 30,
            //     EmailAddress = "john.doe@example.com"
            // };
            //
            // // Serialize the Person object to JSON
            // string json = JsonSerializer.Serialize(person);
            // Console.WriteLine("Serialized JSON:");
            // Console.WriteLine(json);
            //
            // // Deserialize the JSON back to a Person object
            // MyDataClass.Person deserializedPerson = JsonSerializer.Deserialize<MyDataClass.Person>(json);
            // Console.WriteLine("\nDeserialized Person object:");
            // Console.WriteLine($"Name: {deserializedPerson.Name}");
            // Console.WriteLine($"Age: {deserializedPerson.Age}");
            // Console.WriteLine($"EmailAddress: {deserializedPerson.EmailAddress}");
            
            
            string apiUrl = "https://example.com/api/persons"; // Replace this with your actual API URL
            // make an instance of the ApiHandler class
            ApiHandler apiHandler = new ApiHandler();
            List<MyDataClass.Person> persons = await apiHandler.GetPersonsFromApi(apiUrl);

            if (persons != null)
            {
                foreach (MyDataClass.Person person in persons)
                {
                    Console.WriteLine($"Id: {person.Name}, Name: {person.Age}, Age: {person.EmailAddress}");
                }
            }

            
            
        }
    }
}