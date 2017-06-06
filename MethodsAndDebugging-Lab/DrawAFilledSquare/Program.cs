using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            PrintTopAndBottom(n);
            PrintMiddle(n);
            PrintTopAndBottom(n);
        }

        static void PrintMiddle(int i)
        {
            for (int j = 1; j <= i - 2; j++)
            {
                Console.Write("-");
                for (int k = 1; k <= i - 1; k++)
                {
                    Console.Write(@"\/");
                }
                Console.Write("-");
                Console.WriteLine();
            }
        }

        static void PrintTopAndBottom(int i)
        {
            Console.WriteLine(new string('-', 2 * i));
        }
    }
}
