using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] arr = new int[1001];

            foreach (var integer in integersList)
            {
                arr[integer]++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.WriteLine($"{i} -> {arr[i]}");
                }
            }
        }
    }
}