using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacciNumber(n));
        }

        static int GetFibonacciNumber(int number)
        {
            var a = 0;
            var b = 1;
            for (int i = 0; i < number; i++)
            {
                var c = a;
                a = b;
                b = c + a;
            }
            return b;
        }
    }
}
