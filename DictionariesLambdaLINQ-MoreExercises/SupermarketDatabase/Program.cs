using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var productPriceQuantity = new Dictionary<string, Dictionary<double, int>>();
            var grandTotal = 0.0;

            while (line != "stocked")
            {
                var tokens = line.Split(' ');
                var product = tokens[0];
                var price = double.Parse(tokens[1]);
                var quantity = int.Parse(tokens[2]);

                if (!productPriceQuantity.ContainsKey(product))
                {
                    productPriceQuantity[product] = new Dictionary<double, int>();
                }
                if (!productPriceQuantity[product].ContainsKey(price))
                {
                    productPriceQuantity[product][price] = 0;
                }
                productPriceQuantity[product][price] += quantity;

                line = Console.ReadLine();
            }

            foreach (var product in productPriceQuantity)
            {
                var item = product.Key;
                var priceQuantity = product.Value;

                var price = priceQuantity.Keys.ToArray();
                var quantity = priceQuantity.Values.Sum();
                var totalPrice = price[price.Length - 1] * quantity;
                grandTotal += totalPrice;

                Console.WriteLine($"{item}: ${price[price.Length - 1]:F2} * {quantity} = ${totalPrice:F2}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");
        }
    }
}
