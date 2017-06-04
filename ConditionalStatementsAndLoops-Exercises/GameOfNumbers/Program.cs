using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicalNumber = int.Parse(Console.ReadLine());

            var counter = 0;
            var sum = 0;
            var lastCombo = string.Empty;
            var found = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;
                    sum = i + j;

                    if (sum == magicalNumber)
                    {
                        lastCombo = $"{i} + {j}"; // saves last combination
                        found = sum;
                    }
                }
            }
            if (found < magicalNumber)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
            }
            else 
            {
                Console.WriteLine($"Number found! {lastCombo} = {magicalNumber}");
            }
        }
    }
}