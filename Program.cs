using System.Text.Json.Nodes;
using static System.Net.WebRequestMethods;

namespace OpenWeatherMap
{
     class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var key = "cb6ec932ee52a1172b1432786c0245d4\r\n";
            var city = "Birmingham";

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={API key}";
            var response = client.GetAsync(weatherURL).Result;

            JsonObject formattedResponse = JsonObject.Parse(response);

        }
    }
}
