using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetwen2Points
{
    class Program
    {
        public class Point
        {
            public int X { get; set; }

            public int Y { get; set; }

        }
        static void Main(string[] args)
        {
            var firstPointCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var firstPoint = new Point
            {
                X = firstPointCoordinates[0],
                Y = firstPointCoordinates[1]
            };

            var secondPointCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondPoint = new Point
            {
                X = secondPointCoordinates[0],
                Y = secondPointCoordinates[1]
            };

            var distance = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine($"{distance:F3}");
        }
        static double CalcDistance(Point p1, Point p2)
        {
            var squareX = Math.Pow(p1.X - p2.X, 2);
            var squareY = Math.Pow(p1.Y - p2.Y, 2);
            var result = Math.Sqrt(squareY + squareX);
            return result;
        }
    }
}
