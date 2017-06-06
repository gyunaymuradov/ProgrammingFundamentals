using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(num1, num2, num3));
        }

        static int GetMax(int num1, int num2, int num3)
        {
            var biggestOfFirstTwo = Math.Max(num1, num2);
            var biggest = Math.Max(biggestOfFirstTwo, num3);
            return biggest;
        }
    }
}
