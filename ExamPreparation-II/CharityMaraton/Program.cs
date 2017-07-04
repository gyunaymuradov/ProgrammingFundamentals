using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CharityMaraton
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var totalRunners = int.Parse(Console.ReadLine());
            var averageLaps = int.Parse(Console.ReadLine());
            var lapLength = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            BigInteger totalLaps = 0;
            if (trackCapacity * marathonDays >= totalRunners)
            {
                totalLaps = totalRunners * averageLaps;
            }
            else
            {
                totalLaps = trackCapacity * marathonDays * averageLaps;
            }

            decimal moneyRaised = (decimal)((totalLaps * lapLength) / 1000) * moneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
