using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            var leavingTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            long stepsNeeded = long.Parse(Console.ReadLine()) % 86400;
            long timeInSecondsForEachStep = long.Parse(Console.ReadLine()) % 86400;

            long totalNeededTimeInSeconds = stepsNeeded * timeInSecondsForEachStep;
            TimeSpan ts = TimeSpan.FromSeconds(totalNeededTimeInSeconds);
            var arrivalTime = leavingTime + ts;

            Console.WriteLine($"Time Arrival: {arrivalTime:HH:mm:ss}");

        }
    }
}