using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var excludeLetter = char.Parse(Console.ReadLine());

            for (int i = firstLetter; i <= secondLetter; i++)
            {
                if (i != excludeLetter)
                {
                    for (int j = firstLetter; j <= secondLetter; j++)
                    {
                        if (j != excludeLetter)
                        {
                            for (int k = firstLetter; k <= secondLetter; k++)
                            {
                                if (k != excludeLetter)
                                {
                                    var result = $"{(char)i}{(char)j}{(char)k} ";
                                    Console.Write(result);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
