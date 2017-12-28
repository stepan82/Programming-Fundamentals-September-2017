using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string, long>> dataPopulation = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var tokens = Console.ReadLine().Split('|').ToArray();
                if (tokens[0] == "report")
                {
                    break;
                }
                string cityName = tokens[0];
                string countryName = tokens[1];
                int population = int.Parse(tokens[2]);

                if (!dataPopulation.ContainsKey(countryName))
                {
                    dataPopulation.Add(countryName, new Dictionary<string, long>());
                }

                dataPopulation[countryName].Add(cityName, population);
            }

            var ordered = dataPopulation.OrderByDescending(c => c.Value.Values.Sum());
            foreach (var country in ordered)
            {
                var orderedCities = country.Value.OrderByDescending(c => c.Value);
                Console.WriteLine("{0} (total population: {1})", country.Key, country.Value.Sum(c => c.Value));

                Dictionary<string, long> citiesData = country.Value;

                foreach (var city in orderedCities)
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
