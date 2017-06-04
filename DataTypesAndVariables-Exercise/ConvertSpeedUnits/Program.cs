using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float metersPerSeconds = distanceInMeters / (seconds + minutes * 60f + hours * 60f * 60f);
            float kilometersPerHour = distanceInMeters / 1000f / (hours + minutes / 60f + seconds / 60f / 60f);
            float milesPerHour = (distanceInMeters / 1609f) / (hours + (minutes / 60f + seconds / 60f / 60f));

            Console.WriteLine($"{metersPerSeconds}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
