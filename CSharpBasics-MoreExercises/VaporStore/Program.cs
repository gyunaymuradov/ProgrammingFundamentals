using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialBudget = double.Parse(Console.ReadLine());
            var game = Console.ReadLine();

            var currentPrice = 0.0;
            var currentBudget = initialBudget;

            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        currentPrice = 39.99;
                        break;
                    case "CS: OG":
                        currentPrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        currentPrice = 19.99;
                        break;
                    case "Honored 2":
                        currentPrice = 59.99;
                        break;
                    case "RoverWatch":
                        currentPrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        currentPrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        game = Console.ReadLine();
                        continue;
                }
                if (currentPrice > currentBudget)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (currentBudget >= currentPrice)
                {
                    Console.WriteLine($"Bought {game}");
                    currentBudget -= currentPrice;
                }
                if (currentBudget == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                game = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${(initialBudget - currentBudget):F2}. Remaining: ${currentBudget:F2}");
        }
    }
}