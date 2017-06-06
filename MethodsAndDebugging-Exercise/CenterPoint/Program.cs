using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            PrintTheClosestPoint(x1, y1, x2, y2);

        }

        static void PrintTheClosestPoint(double x1, double y1, double x2, double y2)
        {
            if (GetDistance(x1, y1) <= GetDistance(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
                return;
            }
            Console.WriteLine($"({x2}, {y2})");

        }

        static double GetDistance(double x, double y)
        {
            return Math.Pow(x, 2) + Math.Pow(y, 2);
        }
    }
}
