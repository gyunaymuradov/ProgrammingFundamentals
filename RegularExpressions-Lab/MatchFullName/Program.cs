using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regex = @"\b[A-Z]{1}[a-z]+\s{1}[A-Z]{1}[a-z]+\b";

            MatchCollection matchedText = Regex.Matches(input, regex);

            foreach (Match m in matchedText)
            {
                Console.Write($"{m} ");
            }
            Console.WriteLine();
        }
    }
}
