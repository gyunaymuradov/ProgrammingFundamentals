using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();

            GetLastDigitName(number);
        }

        static void GetLastDigitName(string number)
        {
            var num = Math.Abs(long.Parse(number));
            var lastDigit = num % 10;
            var lastDigitName = string.Empty;
            if (lastDigit == 0)
            {
                lastDigitName = "zero";
            }
            else if (lastDigit == 1)
            {
                lastDigitName = "one";
            }
            else if (lastDigit == 2)
            {
                lastDigitName = "two";
            }
            else if (lastDigit == 3)
            {
                lastDigitName = "three";
            }
            else if (lastDigit == 4)
            {
                lastDigitName = "four";
            }
            else if (lastDigit == 5)
            {
                lastDigitName = "five";
            }
            else if (lastDigit == 6)
            {
                lastDigitName = "six";
            }
            else if (lastDigit == 7)
            {
                lastDigitName = "seven";
            }
            else if (lastDigit == 8)
            {
                lastDigitName = "eight";
            }
            else if (lastDigit == 9)
            {
                lastDigitName = "nine";
            }
            Console.WriteLine(lastDigitName);
        }
    }
}
