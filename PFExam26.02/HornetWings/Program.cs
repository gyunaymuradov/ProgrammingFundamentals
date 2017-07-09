using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distanceInMetersPer1kWF = decimal.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());

            var distance = (wingFlaps / 1000) * distanceInMetersPer1kWF;
            var flapTimeInSeconds = wingFlaps / 100;
            var totalTimeInSeconds = flapTimeInSeconds + (wingFlaps / endurance) * 5;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{totalTimeInSeconds} s.");

        }
    }
}
