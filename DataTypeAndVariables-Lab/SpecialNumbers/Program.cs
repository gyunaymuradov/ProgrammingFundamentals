using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int number = i;
                var sumOfDigits = 0;

                while (number > 0)
                {
                    var digit = number % 10;
                    sumOfDigits += digit;
                    number /= 10;
                }
                bool isSpecial = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
                
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
