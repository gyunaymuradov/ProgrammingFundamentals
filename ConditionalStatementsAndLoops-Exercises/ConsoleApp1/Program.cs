using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _03.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool found = false;
            bool notFound = true;
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int i = n, j = n;
            int magic = int.Parse(Console.ReadLine());
            int counter = 0;
            string result = String.Empty;
            for (i = n; i <= m; i++)
            {
                for (j = n; j <= m; j++)
                    counter++;
                if (j + i == magic)
                {
                    found = true;
                    result = $"Number found! {i} + {j} = {magic}";
                }
                if (found == true)
                {
                    notFound = false;
                    continue;
                }
                else
                {
                    notFound = true;
                }
            }
            if (found == true)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magic}");
            }
        }
    }
}