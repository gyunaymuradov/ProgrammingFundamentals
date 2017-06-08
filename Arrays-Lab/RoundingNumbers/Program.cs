using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"{number[i]} => {Math.Round(number[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
