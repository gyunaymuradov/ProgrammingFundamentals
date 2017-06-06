using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var distanceOfFirstPair = GetDistance(x1, y1) + GetDistance(x2, y2);
            var distanceOfSecondPair = GetDistance(x3, y3) + GetDistance(x4, y4);

            var firstCoordinates = GetTheClosestToTheCenter(x1, y1);
            var secondCoordinates = GetTheClosestToTheCenter(x2, y2);
            var thirdCoordinates = GetTheClosestToTheCenter(x3, y3);
            var forthCoordinates = GetTheClosestToTheCenter(x4, y4);

            if (distanceOfFirstPair >= distanceOfSecondPair)
            {
                if (firstCoordinates <= secondCoordinates)
                {
                    Console.Write($"({x1}, {y1})");
                    Console.WriteLine($"({x2}, {y2})");
                }
                else
                {
                    Console.Write($"({x2}, {y2})");
                    Console.WriteLine($"({x1}, {y1})");
                }
            }
            else
            {
                if (thirdCoordinates <= forthCoordinates)
                {
                    Console.Write($"({x3}, {y3})");
                    Console.WriteLine($"({x4}, {y4})");
                }
                else
                {
                    Console.Write($"({x4}, {y4})");
                    Console.WriteLine($"({x3}, {y3})");
                }
            }
        }

        static double GetTheClosestToTheCenter(double a, double b)
        {
            return GetDistance(a, b);
        }

        static double GetDistance(double x, double y)
        {
            return Math.Pow(x, 2) + Math.Pow(y, 2);
        }
    }
}
