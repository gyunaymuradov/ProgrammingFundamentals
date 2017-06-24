using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var carsDict = new Dictionary<string, Dictionary<string, int>>();
            var trucksDict = new Dictionary<string, Dictionary<string, int>>();
            while (input != "End")
            {
                var tokens = input.Split(' ');
                var type = tokens[0].ToLower();
                var model = tokens[1];
                var color = tokens[2];
                var hp = int.Parse(tokens[3]);

                if (type == "car")
                {
                    carsDict[model] = new Dictionary<string, int>();
                    carsDict[model][color] = hp;
                }
                else
                {
                    trucksDict[model] = new Dictionary<string, int>();
                    trucksDict[model][color] = hp;
                }
                input = Console.ReadLine();
            }
            var line = Console.ReadLine();
            while (line != "Close the Catalogue")
            {
                if (carsDict.ContainsKey(line))
                {
                    var colorHp = carsDict[line].ToList();
                    var color = colorHp[0];
                    Console.WriteLine("Type: Car");
                    Console.WriteLine($"Model: {line}");
                    Console.WriteLine($"Color: {color.Key}");
                    Console.WriteLine($"Horsepower: {color.Value}");
                }
                else
                {
                    var colorHp = trucksDict[line].ToList();
                    var color = colorHp[0];
                    Console.WriteLine("Type: Truck");
                    Console.WriteLine($"Model: {line}");
                    Console.WriteLine($"Color: {color.Key}");
                    Console.WriteLine($"Horsepower: {color.Value}");
                }
                line = Console.ReadLine();
            }
            double totalHpOfCars = carsDict.Values.Sum(a => a.Values.Sum());
            double totalHpOfTrucks = trucksDict.Values.Sum(a => a.Values.Sum());
            double averageHpCars = totalHpOfCars / carsDict.Keys.Count;
            if (carsDict.Keys.Count == 0)
            {
                averageHpCars = 0;
            }
            double averageHpTrucks = totalHpOfTrucks / trucksDict.Keys.Count;
            if (trucksDict.Keys.Count == 0)
            {
                averageHpTrucks = 0;
            }
            Console.WriteLine($"Cars have average horsepower of: {averageHpCars:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHpTrucks:F2}.");
        }
    }
}
