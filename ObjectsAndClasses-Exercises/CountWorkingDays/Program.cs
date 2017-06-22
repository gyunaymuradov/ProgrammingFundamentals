using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = Console.ReadLine();
            var end = Console.ReadLine();

            var startDate = DateTime.ParseExact(start, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(end, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var holidays = new[]
                {
                    "01.01", "03.03", "01.05", "06.05",
                    "24.05", "06.09", "22.09", "01.11", "24.12", "25.12", "26.12"
                }
                .Select(a => DateTime.ParseExact(a, "dd.MM", CultureInfo.InvariantCulture)).ToArray();

            var workingDaysCounter = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                var isSaturdayOrSunday = currentDate.DayOfWeek == DayOfWeek.Sunday ||
                                         currentDate.DayOfWeek == DayOfWeek.Saturday;
                var officialHoliday = holidays.Any(a => a.Day == currentDate.Day && a.Month == currentDate.Month);  
                if (!isSaturdayOrSunday && !officialHoliday)
                {
                    workingDaysCounter++;
                }
            }
            Console.WriteLine(workingDaysCounter);
        }
    }
}
