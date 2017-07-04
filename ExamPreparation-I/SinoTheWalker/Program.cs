using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaveTime = Console.ReadLine().Split(':');
            var hours = int.Parse(leaveTime[0]);
            var minutes = int.Parse(leaveTime[1]);
            var seconds = int.Parse(leaveTime[2]);

            var steps = long.Parse(Console.ReadLine());
            var timeForStep = long.Parse(Console.ReadLine());

            long timeInSeconds = steps * timeForStep % 86400;
            long totalTimeInSeconds = timeInSeconds + hours * 60 * 60 + minutes * 60 + seconds;

            var ts = TimeSpan.FromSeconds(totalTimeInSeconds);
            
            Console.WriteLine($"Time Arrival: {ts.Hours:D2}:{ts.Minutes:D2}:{ts.Seconds:D2}");
        }
    }
}