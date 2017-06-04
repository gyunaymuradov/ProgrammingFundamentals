using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            double convertedUnit = 0;
            string metricUnit = string.Empty;

            switch (imperialUnit)
            {
                case "miles":
                    convertedUnit = 1.6 * value;
                    metricUnit = "kilometers";
                    break;
                case "inches":
                    convertedUnit = 2.54 * value;
                    metricUnit = "centimeters";
                    break;
                case "feet":
                    convertedUnit = 30 * value;
                    metricUnit = "centimeters";
                    break;
                case "yards":
                    convertedUnit = 0.91 * value;
                    metricUnit = "meters";
                    break;
                case "gallons":
                    convertedUnit = 3.8 * value;
                    metricUnit = "liters";
                    break;
            }
            Console.WriteLine($"{value} {imperialUnit} = {convertedUnit:F2} {metricUnit}");
        }
    }
}
