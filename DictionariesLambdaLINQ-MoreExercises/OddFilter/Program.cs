using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var list = new List<int>();

            foreach (var num in arr)
            {
                if (num % 2 == 0)
                {
                    list.Add(num);
                }
            }
            var average = list.Average();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > average)
                {
                    list[i] += 1;
                }
                else
                {
                    list[i] -= 1;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
