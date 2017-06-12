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
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var counter = 1;
            var highestRep = 0;
            var repeatedParameter = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    counter++;

                    if (counter > highestRep)
                    {
                        highestRep = counter;
                        repeatedParameter = arr[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < highestRep; i++)
            {
                Console.Write(repeatedParameter + " ");
            }
        }
    }
}
