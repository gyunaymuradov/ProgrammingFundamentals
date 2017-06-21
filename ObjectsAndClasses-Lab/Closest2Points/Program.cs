using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exx
{
    class Program
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var pointCoordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                var currentPoint = new Point
                {
                    X = pointCoordinates[0],
                    Y = pointCoordinates[1]
                };
                points.Add(currentPoint);
            }
            var minDistance = double.MaxValue;
            Point p1 = null;
            Point p2 = null;

            for (int i = 0; i < points.Count; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];
                    var distance = CalcDistance(firstPoint, secondPoint);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        p1 = firstPoint;
                        p2 = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"({p1.X}, {p1.Y})");
            Console.WriteLine($"({p2.X}, {p2.Y})");
        }

        static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            var firstPointOnPow = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var secondPointOnPow = Math.Pow(firstPoint.Y - secondPoint.Y, 2);
            var result = Math.Sqrt(firstPointOnPow + secondPointOnPow);
            return result;
        }
    }
}
