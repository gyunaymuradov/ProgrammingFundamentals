using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?<day>[\d]{2})(\.|-|\/)(?<month>[A-Z]{1}[a-z]{2})\1(?<year>\d{4})";
            var input = Console.ReadLine();
            var result = Regex.Matches(input, regex);

            foreach (Match date in result)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }


        }
    }
}
