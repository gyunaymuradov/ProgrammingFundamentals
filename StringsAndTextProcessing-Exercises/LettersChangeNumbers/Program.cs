using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            decimal totalSum = 0;
            foreach (var str in input)
            {
                str.Trim();
                totalSum += Calculate(str);

            }

            Console.WriteLine($"{totalSum:F2}");
        }

        static decimal Calculate(string str)
        {
            decimal number = decimal.Parse(str.Substring(1, str.Length - 2));
            var arr = str.ToCharArray();
            var firstLet = arr[0];
            var lastLet = arr[arr.Length - 1];
            var firstLettersPosition = (int)firstLet % 32;
            var lastLettersPosition = (int)lastLet % 32;
            decimal sum = 0;

            if (char.IsUpper(firstLet))
            {
                sum += number / firstLettersPosition;
            }
            else
            {
                sum += number * firstLettersPosition;
            }
            if (char.IsUpper(lastLet))
            {
                sum -= lastLettersPosition;
            }
            else
            {
                sum += lastLettersPosition;
            }
            return sum;
        }
    }
}
