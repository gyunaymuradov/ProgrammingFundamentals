using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle1 = ReadCircle();
            var circle2 = ReadCircle();

            var result = DoTheyIntersect(circle1, circle2);
            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool DoTheyIntersect(Circle circle1, Circle circle2)
        {
            var xOnPow = Math.Pow(circle1.Center.X - circle2.Center.X, 2);
            var yOnPow = Math.Pow(circle1.Center.Y - circle2.Center.Y, 2);
            var distance = Math.Sqrt(xOnPow + yOnPow);
            if (distance <= circle1.Radius + circle2.Radius)
            {
                return true;
            }
            return false;
        }

        static Circle ReadCircle()
        {
            var line = Console.ReadLine().Split(' ').ToList();
            var x = int.Parse(line[0]);
            var y = int.Parse(line[1]);
            var radius = int.Parse(line[2]);
            var center = new Point
            {
                X = x,
                Y = y
            };
            return new Circle
            {
                Center = center,
                Radius = radius
            };
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }
}
