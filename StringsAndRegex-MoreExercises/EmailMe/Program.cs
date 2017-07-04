using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine();
            var pattern = @"([^@]+)";
            var matches = Regex.Matches(email, pattern);
            var leftSum = 0;
            var rightSum = 0;

            var left = matches[0].ToString();
            for (int i = 0; i < left.Length; i++)
            {
                leftSum += left[i];
            }

            var right = matches[1].ToString();
            for (int i = 0; i < right.Length; i++)
            {
                rightSum += right[i];
            }

            var result = leftSum - rightSum;
            if (result >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
