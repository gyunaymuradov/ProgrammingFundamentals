using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpgradedMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productNames = Console.ReadLine().Split().ToArray();
            long[] productQuantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            long quantity = 0;
            while (true)
            {
                string[] product = Console.ReadLine().Split().ToArray();
                string productName = product[0];
                long quantityToOrder = 0;
                try
                {
                   quantityToOrder = long.Parse(product[1]);
                }
                catch
                {
                    break;
                }

                decimal totalPrice = 0;

                var index = Array.IndexOf(productNames, productName);
                decimal price = prices[index];

                try
                {
                    quantity = productQuantities[index];
                }
                catch
                {
                    quantity = 0;
                }
                if (quantity >= quantityToOrder)
                {
                    totalPrice = quantityToOrder * price;
                    Console.WriteLine($"{productName} x {quantityToOrder} costs {totalPrice:F2}");
                    productQuantities[index] -= quantityToOrder;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {productName}");
                }

            }
        }
    }
}
