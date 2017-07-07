using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            var ordersCount = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            var prices = new List<decimal>();

            for (int i = 0; i < ordersCount; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = long.Parse(Console.ReadLine());

                decimal price = pricePerCapsule * capsulesCount * DateTime.DaysInMonth(date.Year, date.Month);
                totalPrice += price;
                prices.Add(price);

            }
            foreach (var price in prices)
            {
                Console.WriteLine($"The price for the coffee is: ${price:F2}");

            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
