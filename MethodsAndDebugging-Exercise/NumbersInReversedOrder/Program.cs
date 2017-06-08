using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = decimal.Parse(Console.ReadLine());

            var reversedNumber = ReverseNumDigits(number);

            Console.WriteLine(reversedNumber);
        }

        static decimal ReverseNumDigits(decimal number)
        {
            var numToString = number.ToString();
            var result = string.Empty;
            for (int i = numToString.Length - 1; i >= 0; i--)
            {
                result += numToString[i];
            }
            return decimal.Parse(result);
        }
    }
}
