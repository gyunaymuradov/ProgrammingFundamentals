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
            var number = double.Parse(Console.ReadLine());

            Console.WriteLine(GetNumbersInReversedOrder(number));
        }

        static double GetNumbersInReversedOrder(double number)
        {
            var result = 0d;
            while (number > 0)
            {
                var lastDigit = number % 10;
                result = (result * 10) + lastDigit;
                number /= 10;
            }
            return result;
        }
    }
}
