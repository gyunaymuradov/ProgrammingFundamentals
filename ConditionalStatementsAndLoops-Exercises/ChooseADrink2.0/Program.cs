using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            var drink = string.Empty;
            var totalPrice = 0.0;

            if (profession == "Athlete")
            {
                drink = "Water";
                totalPrice = 0.70 * quantity;
            } 
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
                totalPrice = 1.00 * quantity;
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
                totalPrice = 1.70 * quantity;
            }
            else
            {
                drink = "Tea";
                totalPrice = 1.20 * quantity;
            }

            Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
        }
    }
}
