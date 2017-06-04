using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centures = int.Parse(Console.ReadLine());

            int years = centures * 100;
            uint days = (uint)(years * 365.2422);
            uint hours = 24 * days;
            ulong minutes = hours * 60;
            ulong seconds = 60 * minutes;
            decimal milliseconds = seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours" +
                              $" = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds" +
                              $" = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
