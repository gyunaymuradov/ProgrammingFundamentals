using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var input1 = input[0];
            var input2 = input[1];

            var minLength = Math.Min(input1.Length, input2.Length);
            BigInteger totalSum = 0;
            for (int i = 0; i < minLength; i++)
            {
                var multiplication = input1[i] * input2[i];
                totalSum += multiplication;
            }
            var longestString = string.Empty;
            if (input1.Length > input2.Length)
            {
                longestString = input1;
            }
            else
            {
                longestString = input2;
            }
            for (int i = minLength; i < longestString.Length; i++)
            {
                totalSum += longestString[i];
            }
            Console.WriteLine(totalSum);
        }
    }
}
