using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            decimal volume = 0m;
            string biggestKegName = string.Empty;
            decimal biggestKegVolume = decimal.MinValue;

            for (int j = 0; j < n; j++)
            {
                string model = Console.ReadLine();
                decimal radius = decimal.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = (decimal)Math.PI * radius * radius * height;

                if (volume > biggestKegVolume)
                {
                    biggestKegVolume = volume;
                    biggestKegName = model;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}
