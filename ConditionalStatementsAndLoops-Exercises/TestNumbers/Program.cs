using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSumBoundary = int.Parse(Console.ReadLine());
            var counter = 0;
            var sum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    var multiplication = 3 * (i * j);
                    sum += multiplication;
                    counter++;

                    if (sum >= maxSumBoundary)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSumBoundary}");
                        return;
                    }
                }
            }
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
        }
    }
}
