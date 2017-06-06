using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            PrintFirstHalfOfTriangle(n);
            PrintSecondHalfOfTheTriangle(n);
        }

        static void PrintSecondHalfOfTheTriangle(int i)
        {
            for (int j = 1; j < i; j++)
            {
                for (int k = 1; k <= i - j; k++)
                {
                    Console.Write($"{k} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintFirstHalfOfTriangle(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                for (int k = 1; k <= j; k++)
                {
                    Console.Write($"{k} ");
                }
                Console.WriteLine();
            }
        }
    }
}