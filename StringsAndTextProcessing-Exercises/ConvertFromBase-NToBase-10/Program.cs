using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase_NToBase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var targetBase = BigInteger.Parse(input[0]);
            var num = BigInteger.Parse(input[1]);

            var sumList = new List<BigInteger>();
            var index = 0;

            while (num > 0)
            {
                var digit = num % 10 * BigInteger.Pow(targetBase, index);
                index++;
                num /= 10;
                sumList.Add(digit);
            }
            BigInteger result = 0;
            foreach (var number in sumList)
            {
                result += number;
            }
            Console.WriteLine(result);
        }
    }
}
