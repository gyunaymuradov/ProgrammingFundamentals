using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMaraton
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthOfMarathonInDays = int.Parse(Console.ReadLine());
            var numberOfRunners = long.Parse(Console.ReadLine());
            var averageNumberOfLaps = int.Parse(Console.ReadLine());
            var trackLength = long.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var donatedMoneyPerKm = decimal.Parse(Console.ReadLine());

            var totalParticipants = 0l;
            if (numberOfRunners <= trackCapacity * lengthOfMarathonInDays)
            {
                totalParticipants = numberOfRunners;
            }
            else
            {
                totalParticipants = trackCapacity * lengthOfMarathonInDays;
            }

            var donatedMoney = totalParticipants * trackLength * averageNumberOfLaps * donatedMoneyPerKm / 1000;

            Console.WriteLine($"Money raised: {donatedMoney:F2}");
        }
    }
}
