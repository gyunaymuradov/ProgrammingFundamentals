using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var num = new List<int>();

            for (int i = 0; i < count; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                num.Add(currentNum);
            }

            Console.WriteLine($"Sum = {num.Sum()}");
            Console.WriteLine($"Min = {num.Min()}");
            Console.WriteLine($"Max = {num.Max()}");
            Console.WriteLine($"Average = {num.Average()}");
        }
    }
}