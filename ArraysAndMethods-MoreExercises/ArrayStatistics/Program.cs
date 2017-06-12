using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long sum = 0;
            long min = long.MaxValue;
            long max = long.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] >= max)
                {
                    max = arr[i];
                }
                if (arr[i] <= min)
                {
                    min = arr[i];
                }
            }
            double average = (double)sum / arr.Length;

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
