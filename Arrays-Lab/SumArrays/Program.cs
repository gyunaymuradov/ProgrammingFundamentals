using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrayB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] result = new int[Math.Max(arrayA.Length, arrayB.Length)];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = arrayA[i % arrayA.Length] + arrayB[i % arrayB.Length];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
