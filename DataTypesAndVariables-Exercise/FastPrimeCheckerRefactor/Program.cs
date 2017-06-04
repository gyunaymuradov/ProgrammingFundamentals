using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeCheckerRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int numbers = 2; numbers <= n; numbers++)
            {
                bool isPrime = true;

                for (int i = 2; i <= Math.Sqrt(numbers); i++)
                {
                    if (numbers % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{numbers} -> {isPrime}");
            }
        }
    }
}
