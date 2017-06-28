using System;
using System.Linq;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            var text1 = input[0];
            var text2 = input[1];

            var distinctedText1 = text1.Distinct().ToArray();
            var distinctedText2 = text2.Distinct().ToArray();

            if (distinctedText1.Length == distinctedText2.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}