using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"(?<city>[A-Z]{2})(?<averageTemp>\d+\.\d+)(?<weatherType>[A-Za-z]+)\|");
            var dictOfCities = new Dictionary<string, City>();
            while (input != "end")
            {
                var weatherMatch = regex.Match(input);

                if (!weatherMatch.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var city = weatherMatch.Groups["city"].Value;
                var avgTemp = double.Parse(weatherMatch.Groups["averageTemp"].Value);
                var weatherType = weatherMatch.Groups["weatherType"].Value;

                dictOfCities[city] = new City();
                dictOfCities[city].AverageTemp = avgTemp;
                dictOfCities[city].WeatherType = weatherType;

                input = Console.ReadLine();
            }
            var sortedDict = dictOfCities.OrderBy(a => a.Value.AverageTemp).ToDictionary(a => a.Key, a => a.Value);

            foreach (var cities in sortedDict)
            {
                var city = cities.Key;
                var weatherInfo = cities.Value;

                Console.WriteLine($"{city} => {weatherInfo.AverageTemp:F2} => {weatherInfo.WeatherType}");
            }
        }
    }

    class City
    {
        public double AverageTemp { get; set; }
        public string WeatherType { get; set; }
    }
}
