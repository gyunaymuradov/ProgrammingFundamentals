using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var counter = 1;
            var longestRep = 0;
            var endIndex = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    counter++;

                    if (counter > longestRep)
                    {
                        longestRep = counter;
                        endIndex = i + 1;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            for (int j = endIndex - longestRep + 1;  j <= endIndex; j++)
            {
                Console.Write(arr[j] + " ");
            }
        }
    }
}