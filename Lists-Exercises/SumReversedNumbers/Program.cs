using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var sum = 0;
            foreach (var num in list)
            {
                var reversedNum = 0;
                var currentNum = num;
                while (currentNum > 0)
                {
                    var lastDigit = currentNum % 10;
                    reversedNum = (reversedNum * 10) + lastDigit;
                    currentNum /= 10;
                }
                sum += reversedNum;
            }
            Console.WriteLine(sum);
        }
    }
}
