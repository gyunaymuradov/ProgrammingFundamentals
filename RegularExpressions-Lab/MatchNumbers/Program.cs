using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, regex);

            foreach (Match num in matches)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
