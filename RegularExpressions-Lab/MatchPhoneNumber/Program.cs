using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            var number = Console.ReadLine();
            var allMatches = Regex.Matches(number, regex);

            var result = allMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", result));
/*
            var listOfNumbers = new List<Match>();
            foreach (Match m in allMatches)
            {
                listOfNumbers.Add(m);
            }
            Console.WriteLine(string.Join(", ", listOfNumbers));*/
        }
    }
}
