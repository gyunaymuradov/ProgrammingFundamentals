using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var numOfItems = int.Parse(Console.ReadLine());

            var itemPlural = string.Empty;
            var totalPrice = 0.0;

            for (int i = 0; i < numOfItems; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());

                var decreasingItemCount = itemCount;
                if (itemCount > 1)
                {
                    itemPlural = itemName + "s";
                }
                else
                {
                    itemPlural = itemName;
                }

                totalPrice += itemCount * itemPrice;

                if (itemCount >= 0)
                {
                    Console.WriteLine($"Adding {itemCount} {itemPlural} to cart.");
                }
            }
            Console.WriteLine($"Subtotal: ${totalPrice:F2}");
            if (totalPrice <= budget)
            {
                Console.WriteLine($"Money left: ${(budget - totalPrice):F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(budget - totalPrice):F2} more.");
            }
        }
    }
}
