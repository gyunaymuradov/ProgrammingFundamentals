using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var targetBase = BigInteger.Parse(input[0]);
            var numToConvert = BigInteger.Parse(input[1]);
            var newNumList = new List<BigInteger>();

            while (numToConvert > 0)
            {
                var remainder = numToConvert % targetBase;
                newNumList.Add(remainder);
                numToConvert /= targetBase;
            }
            newNumList.Reverse();
            var output = BigInteger.Parse(string.Join("", newNumList));
            Console.WriteLine(output);
        }
    }
}
