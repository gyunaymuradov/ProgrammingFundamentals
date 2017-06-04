using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            long tempNumber;
            var line = Console.ReadLine();
            var number = long.TryParse(line, out tempNumber);

            if (!number)
            {
                Console.WriteLine("Rainy");
                return;
            }
            if (tempNumber <= sbyte.MaxValue && tempNumber >= sbyte.MinValue)
            {

                Console.WriteLine("Sunny");
            }
            else if (tempNumber <= int.MaxValue && tempNumber >= int.MinValue)
            {
                Console.WriteLine("Cloudy");
            }
            else if (tempNumber <= long.MaxValue && tempNumber >= long.MinValue)
            {
                Console.WriteLine("Windy");
            }
        }
    }
}