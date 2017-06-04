using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            sbyte idCounts = sbyte.Parse(Console.ReadLine());

            long maxBorder = 0;
            long minBorder = 0;

            switch (numeralType)
            {
                case "sbyte":
                    maxBorder = sbyte.MaxValue;
                    minBorder = sbyte.MinValue;
                    break;
                case "int":
                    maxBorder = int.MaxValue;
                    minBorder = int.MinValue;
                    break;
                case "long":
                    maxBorder = long.MaxValue;
                    minBorder = long.MinValue;
                    break;
            }

            long thief = long.MinValue;
            for (int i = 0; i < idCounts; i++)
            {
                long currentId = long.Parse(Console.ReadLine());

                if (currentId <= maxBorder && currentId >= minBorder)
                {
                    if (currentId > thief)
                    {
                        thief = currentId;
                    }
                }
            }

            double sentence = 0;
            if (thief > 0)
            {
                sentence = (long)Math.Ceiling(thief / (double)sbyte.MaxValue);
            }
            else
            {
                sentence = (long)Math.Ceiling(thief / (double)sbyte.MinValue);
            }
            if (sentence > 1)
            {
                Console.WriteLine($"Prisoner with id {thief} is sentenced to {sentence} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thief} is sentenced to {sentence} year");
            }
        }
    }
}
