

using System.Text.Json;

namespace ConsoleApp1
{

    public class SomeFunctionality
    {
        public static void Run()
        {
            // Create an instance of the Person class
            MyDataClass.Person person = new MyDataClass.Person
            {
                Name = "John Doe",
                Age = 30,
                EmailAddress = "john.doe@example.com"
            };

            // Serialize the Person object to JSON
            string json = JsonSerializer.Serialize(person);
            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(json);

            // Deserialize the JSON back to a Person object
            MyDataClass.Person deserializedPerson = JsonSerializer.Deserialize<MyDataClass.Person>(json);
            Console.WriteLine("\nDeserialized Person object:");
            Console.WriteLine($"Name: {deserializedPerson.Name}");
            Console.WriteLine($"Age: {deserializedPerson.Age}");
            Console.WriteLine($"EmailAddress: {deserializedPerson.EmailAddress}");
        }
    }
}
