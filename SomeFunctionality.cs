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
                name = "John Doe",
                age = 30,
                emailAddress = "john.doe@example.com"
            };

            // Serialize the Person object to JSON
            string json = JsonSerializer.Serialize(person);
            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(json);

            // Deserialize the JSON back to a Person object
            MyDataClass.Person deserializedPerson = JsonSerializer.Deserialize<MyDataClass.Person>(json);
            Console.WriteLine("\nDeserialized Person object:");
            Console.WriteLine($"Name: {deserializedPerson.name}");
            Console.WriteLine($"Age: {deserializedPerson.age}");
            Console.WriteLine($"EmailAddress: {deserializedPerson.emailAddress}");
        }
    }
}