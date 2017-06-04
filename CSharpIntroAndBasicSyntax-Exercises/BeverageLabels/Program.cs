using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContentPer100ml = int.Parse(Console.ReadLine());
            var sugarContentPer100ml = int.Parse(Console.ReadLine());

            double totalEnergyContent = (double)volume / 100 * energyContentPer100ml;
            double totalSugarConent = (double)volume / 100 * sugarContentPer100ml;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{totalEnergyContent}kcal, {totalSugarConent}g sugars");
        }
    }
}
