using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b[0x]*[0-9A-F]+\b";
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, regex);
            var result = matches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
