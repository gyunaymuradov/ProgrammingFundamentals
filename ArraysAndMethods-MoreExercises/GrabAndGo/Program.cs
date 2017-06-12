using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GrabAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int numToSearch = int.Parse(Console.ReadLine());

            long sum = 0;
            bool occurrenceFound = false;
            for (long i = 0; i < arr.Length; i++)
            {
                if (arr[i] == numToSearch)
                {
                    sum = 0;
                    for (long j = i - 1; j >= 0; j--)
                    {
                        sum += arr[j];
                        occurrenceFound = true;
                    }
                }
            }
            if (occurrenceFound)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}