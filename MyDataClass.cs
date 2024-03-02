using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    public class MyDataClass
    {
        public class Person
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }
            public int Age { get; set; }
            public string EmailAddress { get; set; }
        }
    }
}