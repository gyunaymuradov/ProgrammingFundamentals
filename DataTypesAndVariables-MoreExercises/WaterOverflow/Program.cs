using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int totalLiters = 0;

            for (int i = 0; i < lines; i++)
            {
                int quantity = int.Parse(Console.ReadLine());

                totalLiters += quantity;

                if (totalLiters > byte.MaxValue)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalLiters -= quantity;
                }
            }
            Console.WriteLine(totalLiters);
        }
    }
}
