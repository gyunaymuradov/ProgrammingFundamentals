using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split().Select(long.Parse).ToList();

            long counter = 1;
            long maxLength = 0;
            long num = 0;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                if (counter > maxLength)
                {
                    maxLength = counter;
                    num = numbers[i];
                }
                if (numbers[i] != numbers[i + 1])
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write($"{num} ");
            }
        }
    }
}