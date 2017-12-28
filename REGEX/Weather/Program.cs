using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double> temperatureData = new SortedDictionary<string, double>();

            SortedDictionary<string, string> weatherData = new SortedDictionary<string, string>();

            while (true)
            {
                var forecast = Console.ReadLine();
                if (forecast == "end")
                {
                    break;
                }

                string pattern = @"(?<city>[A-Z]{2})(?<temp>\d+\.{1}\d+)(?<weather>[a-zA-Z]+)(?=\|)";

                MatchCollection results = Regex.Matches(forecast, pattern);

                foreach (Match item in results)
                {
                    var city = item.Groups["city"].Value;
                    var temperature = item.Groups["temp"].Value;
                    var weather = item.Groups["weather"].Value;

                    if (!weatherData.ContainsKey(city) && !temperatureData.ContainsKey(city))
                    {
                        weatherData.Add(city, weather);
                        temperatureData.Add(city, double.Parse(temperature));
                    }
    
                    if (weatherData.ContainsKey(city))
                    {
                        weatherData[city] = weather;
                    }

                    if (temperatureData.ContainsKey(city))
                    {
                        temperatureData[city] = double.Parse(temperature);
                    }

                }

            }

            foreach (var city in temperatureData.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{city.Key} => {city.Value:F2} => {weatherData[city.Key]}");
               
            }
        }
    }
}
