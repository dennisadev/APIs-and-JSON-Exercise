using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void OpenWeatherTemp() 
        {
            var client = new HttpClient();
            var key = "";
            var city = "Providence";

            var weatherURL = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&units=imperial&appid={key}";
            var weatherResponse = client.GetStringAsync(weatherURL).Result;

            JObject response = JObject.Parse(weatherResponse);
            var temp = response["list"][0]["main"]["temp"];
            Console.WriteLine($"The tempature in {city} is {temp} Fahrenheit");

        }
    }
}
