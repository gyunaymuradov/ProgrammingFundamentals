using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productNames = Console.ReadLine().Split().ToArray();
            long[] productQuantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] prices = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            while (true)
            {
                string product = Console.ReadLine();

                if (product == "done")
                {
                    break;
                }

                var index = Array.IndexOf(productNames, product);

                Console.WriteLine($"{product} costs: {prices[index]}; Available quantity: {productQuantities[index]}");
            }
        }
    }
}
