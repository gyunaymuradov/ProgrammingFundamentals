using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var uniqueSymbols = new List<char>();
            var text = input.ToCharArray();
            var result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsDigit(text[i]))
                {
                    if (!uniqueSymbols.Contains(text[i]))
                    {
                        uniqueSymbols.Add(text[i]);
                    }
                    // aSd2&5s@1
                    var symbols = new StringBuilder();
                    while (i < text.Length && !char.IsDigit(text[i]))
                    {
                        symbols.Append(text[i]);
                        i++;
                    }

                    var num = new StringBuilder();
                    while (i < text.Length && char.IsDigit(text[i]))
                    {
                        num.Append(text[i]);
                        i++;
                    }
                    // aSd2&5s@1
                    var parsedNum = int.Parse(num.ToString());
                    var multipliedString = new StringBuilder();
                    for (int j = 0; j < parsedNum; j++)
                    {
                        multipliedString.Append(symbols);
                    }
                    result.Append(multipliedString);
                }
                i--;
            }
            Console.WriteLine($"Unique symbols used: {result.ToString().ToLower().Distinct().Count()}");
            Console.WriteLine(result.ToString().ToUpper());
        }
    }
}
