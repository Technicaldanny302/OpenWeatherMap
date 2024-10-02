using Newtonsoft.Json.Linq;
using System;
using System.IO;
using OpenWeatherMap;
using System.Diagnostics.Metrics;

namespace OpenWeatherMap
{
     class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Please enter your zipcode");
            var  CityName = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?q={CityName}&appid={APIKey}&units=imperial";

            Console.WriteLine();

            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F in your location");
           
        }
    }
}
