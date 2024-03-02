using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    public class MyDataClass
    {
        public class Person
        {
            [JsonPropertyName("name")] public string name { get; set; }
            public int age { get; set; }
            public string emailAddress { get; set; }
        }

        public class WeatherObject
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
            public double generationtime_ms { get; set; }
            public int utc_offset_seconds { get; set; }
            public string timezone { get; set; }
            public string timezone_abbreviation { get; set; }
            public double elevation { get; set; }
            public Hourly_units hourly_units { get; set; }
            public Hourly hourly { get; set; }
        }

        public class Hourly_units
        {
            public string time { get; set; }
            public string temperature_2m { get; set; }
            public string relativehumidity_2m { get; set; }
            public string dewpoint_2m { get; set; }
            public string apparent_temperature { get; set; }
            public string precipitation { get; set; }
            public string rain { get; set; }
            public string snowfall { get; set; }
        }

        public class Hourly
        {
            public string[] time { get; set; }
            public double[] temperature_2m { get; set; }
            public int[] relativehumidity_2m { get; set; }
            public double[] dewpoint_2m { get; set; }
            public double[] apparent_temperature { get; set; }
            public double[] precipitation { get; set; }
            public double[] rain { get; set; }
            public double[] snowfall { get; set; }
        }
    }
}