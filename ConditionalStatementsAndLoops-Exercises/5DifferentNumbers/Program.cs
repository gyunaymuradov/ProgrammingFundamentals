using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var diff = Math.Abs(a - b);

            if (diff >= 5)
            {
                for (int i = a; i < b; i++)
                {
                    for (int j = a; j < b; j++)
                    {
                        for (int k = a; k < b; k++)
                        {
                            for (int l = a; l < b; l++)
                            {
                                for (int m = a; m <= b; m++)
                                {
                                    if (a <= i && i < j && j < k && k < l && l < m && m <= b)
                                    {
                                        Console.WriteLine($"{i} {j} {k} {l} {m}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
