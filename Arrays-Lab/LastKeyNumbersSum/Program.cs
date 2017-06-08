using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKeyNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            long[] seq = new long[n];

            seq[0] = 1;

            for (int i = 1; i < n; i++)
            {
                int start = Math.Max(0, i - k);
                long sum = 0;

                for (int j = start; j < i; j++)
                {
                    sum += seq[j];
                }

                seq[i] = sum;
            }

            Console.WriteLine(string.Join(" ", seq));
        }
    }
}
