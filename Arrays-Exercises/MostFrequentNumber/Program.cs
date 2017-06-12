using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var counter = 0;
            var highestCount = 0;
            long repeatedNum = 0;

            for (long i = 0; i < numbers.Length; i++)
            {
                for (long j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                        if (counter > highestCount)
                        {
                            highestCount = counter;
                            repeatedNum = numbers[i];
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                    
                }
            }
            Console.WriteLine(repeatedNum);
        }
    }
}
