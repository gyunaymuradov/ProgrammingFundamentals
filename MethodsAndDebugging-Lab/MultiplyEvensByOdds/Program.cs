using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Math.Abs(int.Parse(Console.ReadLine()));

            var result = GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumOfOddDigits = GetSumOfOdds(number);
            int sumOfEvenDigits = GetSumOfEvens(number);

            return sumOfEvenDigits * sumOfOddDigits;
        }

        static int GetSumOfEvens(int number)
        {
            var sum = 0;
            while (number > 0)
            {
                var digit = number % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }

        static int GetSumOfOdds(int number)
        {
            var sum = 0;
            while (number > 0)
            {
                var digit = number % 10;
                if (digit % 2 == 1)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
