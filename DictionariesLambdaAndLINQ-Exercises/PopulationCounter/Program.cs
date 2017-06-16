using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var countryCityPopulation = new Dictionary<string, Dictionary<string, long>>();

            while (line != "report")
            {
                var tokens = line.Split('|');
                var city = tokens[0];
                var country = tokens[1];
                var population = long.Parse(tokens[2]);

                if (!countryCityPopulation.ContainsKey(country))
                {
                    countryCityPopulation[country] = new Dictionary<string, long>();
                }
                if (!countryCityPopulation[country].ContainsKey(city))
                {
                    countryCityPopulation[country][city] = 0;
                }
                countryCityPopulation[country][city] += population;

                line = Console.ReadLine();
            }
            var orderedCountries = countryCityPopulation.OrderByDescending(a => a.Value.Values.Sum());

            foreach (var country in orderedCountries)
            {
                var orderedCities = country.Value.OrderByDescending(b => b.Value);
                var currentCountry = country.Key;
                var cityPopulation = country.Value;
                
                var totalPopulation = cityPopulation.Sum(a => a.Value);
                Console.WriteLine($"{currentCountry} (total population: {totalPopulation})");
                foreach (var currentCity in orderedCities)
                {
                    Console.WriteLine($"=>{currentCity.Key}: {currentCity.Value}");
                }
            }
        }
    }
}