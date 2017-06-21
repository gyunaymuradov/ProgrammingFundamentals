using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class Program
    {
        public class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new SortedDictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                var currentSale = ReadSale();
                if (!dict.ContainsKey(currentSale.Town))
                {
                    dict[currentSale.Town] = 0;
                }
                dict[currentSale.Town] += currentSale.Price * currentSale.Quantity;
            }

            foreach (var town in dict)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:F2}");
            }

        }

        static Sale ReadSale()
        {
            var tokens = Console.ReadLine().Split(' ').ToList();
            return new Sale
            {
                Town = tokens[0],
                Product = tokens[1],
                Price = decimal.Parse(tokens[2]),
                Quantity = decimal.Parse(tokens[3])
            };
        }
    }
}
