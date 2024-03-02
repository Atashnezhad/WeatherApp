﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
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