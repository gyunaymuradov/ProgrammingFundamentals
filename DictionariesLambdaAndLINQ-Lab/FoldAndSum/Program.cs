using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = arr.Length / 4;

            int[] leftSide = arr.Take(k).Reverse().ToArray();
            int[] rightSide = arr.Reverse().Take(k).ToArray();
            int[] centerPart = arr.Skip(k).Take(2 * k).ToArray();

            int[] arrOfSides = leftSide.Concat(rightSide).ToArray();

            List<int> result = new List<int>();

            for (int i = 0; i < centerPart.Length; i++)
            {
                result.Add(arrOfSides[i] + centerPart[i]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}