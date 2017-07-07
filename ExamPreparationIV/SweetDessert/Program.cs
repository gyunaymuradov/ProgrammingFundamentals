using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var cashAmount = decimal.Parse(Console.ReadLine());
            var numOfGuests = int.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berriesPricePerKg = decimal.Parse(Console.ReadLine());

            decimal costForSetOf6 = (bananaPrice * 2) + (eggPrice * 4) + (berriesPricePerKg * 0.2m);

            var portions = Math.Ceiling(numOfGuests / 6d);
            var totalCost = (decimal)portions * costForSetOf6;
            var count = 0;
            if (totalCost > cashAmount)
            {
                Console.WriteLine(
                    $"Ivancho will have to withdraw money - he will need {totalCost - cashAmount:F2}lv more.");
            }
            else
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalCost:F2}lv.");
            }
        }
    }
}
