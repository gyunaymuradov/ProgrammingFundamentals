using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());

            var studioPrice = 0.0;
            var doublePrice = 0.0;
            var suitePrice = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;

                if (nightsCount > 7)
                {
                    studioPrice *= 0.95;
                }
            } 
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
                if (nightsCount > 14)
                {
                    doublePrice *= 0.9;
                }
            } 
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
                if (nightsCount > 14)
                {
                    suitePrice *= 0.85;
                }
            }
            
            var stayInStudio = studioPrice * nightsCount;
            var stayInDouble = doublePrice * nightsCount;
            var stayInSuite = suitePrice * nightsCount;

            if (month == "September" || month == "October")
            {
                if (nightsCount > 7)
                {
                    stayInStudio -= studioPrice;

                }
            }

            Console.WriteLine($"Studio: {stayInStudio:F2} lv.");
            Console.WriteLine($"Double: {stayInDouble:F2} lv.");
            Console.WriteLine($"Suite: {stayInSuite:F2} lv.");
        }
    }
}
