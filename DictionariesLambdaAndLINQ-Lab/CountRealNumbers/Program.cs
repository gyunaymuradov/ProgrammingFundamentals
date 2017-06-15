using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();

            var dict = new SortedDictionary<double, int>();

            foreach (var num in list)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }
            foreach (var num in dict.Keys)
            {
                Console.WriteLine($"{num} -> {dict[num]} times");
            }
        }
    }
}