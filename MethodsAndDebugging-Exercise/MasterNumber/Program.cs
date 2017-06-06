using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && SumOfDigitsDivisableBy7(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool ContainsEvenDigit(long number)
        {
            bool containsEvenDigit = false;
            while (number > 10)
            {
                long digit = number % 10;
                if (digit % 2 == 0)
                {
                    containsEvenDigit = true;
                    break;
                }
                number /= 10;
            }
            return containsEvenDigit;
        }

        static bool SumOfDigitsDivisableBy7(long number)
        {
            bool divisableBy7 = false;
            long sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 7 == 0)
            {
                divisableBy7 = true;
            }
            return divisableBy7;
        }

        static bool IsPalindrome(long number)
        {
            bool isPalindrome = false;
            var temp = number;
            long newNumber = 0;
            while (number > 0)
            {
                long digit = number % 10;
                newNumber = (newNumber * 10) + digit;
                number /= 10;
            }
            if (newNumber == temp)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }
    }
}
