using Newtonsoft.Json.Linq;
using System.Net.Http;
using System;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("------------------------Exercise 1------------------------");

            int numQoutes = 5;
            
            for (int i = 0; i < numQoutes; i++)
            {
                RonVSKanyeAPI.KanyeQoute();
                RonVSKanyeAPI.RonQoute();
            }

            //Exercise 2
            Console.WriteLine("------------------------Exercise 2------------------------");

            OpenWeatherMapAPI.OpenWeatherTemp();



        }
    }
}
