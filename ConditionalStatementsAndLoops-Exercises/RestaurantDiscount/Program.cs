using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            var hallName = string.Empty;
            var hallPrice = 0;
       
            if (groupSize > 0 && groupSize <= 50)
            {
                hallName = "Small Hall";
                hallPrice = 2500;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hallName = "Terrace";
                hallPrice = 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallName = "Great Hall";
                hallPrice = 7500;
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            var packagePrice = 0;
            var discount = 0.0;

            if (package == "Normal")
            {
                packagePrice = 500;
                discount = 0.05;
            }
            else if (package == "Gold")
            {
                packagePrice = 750;
                discount = 0.1;
            }
            else if (package == "Platinum")
            {
                packagePrice = 1000;
                discount = 0.15;
            }

            var totalPrice = packagePrice + hallPrice;
            var totalPriceAfterDiscount = totalPrice * (1 - discount);
            var pricePerPerson = totalPriceAfterDiscount / groupSize;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}
