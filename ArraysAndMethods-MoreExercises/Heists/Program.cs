using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] prices = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long jewelsPrice = prices[0];
            long goldPrice = prices[1];
            long earningFromJewels = 0;
            int jewelsCounter = 0;
            long earningFromGold = 0;
            int goldCounter = 0;
            long totalExpenses = 0;
            while (true)
            {
                string[] information = Console.ReadLine().Split().ToArray();
                string loot = information[0];
                long heistExpense = 0;
                try
                {
                     heistExpense = long.Parse(information[1]);
                }
                catch
                {
                    break;
                }
                foreach (var currentChar in loot)
                {
                    if (currentChar == 37)
                    {
                        jewelsCounter++;
                        continue;
                    }
                    if (currentChar == 36)
                    {
                        goldCounter++;
                        continue;
                    }
                }

                earningFromJewels += jewelsPrice * jewelsCounter;
                earningFromGold += goldPrice * goldCounter;
                totalExpenses += heistExpense;

                jewelsCounter = 0;
                goldCounter = 0;
            }
            if (earningFromGold + earningFromJewels >= totalExpenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {earningFromGold + earningFromJewels - totalExpenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpenses - (earningFromJewels + earningFromGold)}.");
            }
        }
    }
}
