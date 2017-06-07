using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactorTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var factorial = GetFactorial(n);
            var zeroesCount = GetZeroesCount(factorial);

            Console.WriteLine(zeroesCount);

        }

        static long GetZeroesCount(BigInteger factorial)
        {
            long zeroesCounter = 0;
            while (factorial % 10 == 0)
            {
                factorial /= 10;
                zeroesCounter++;
            }
            return zeroesCounter;
        }

        static BigInteger GetFactorial(long n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
