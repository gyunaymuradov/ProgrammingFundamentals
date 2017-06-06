using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine();

            switch (figureType)
            {
                case "triangle":
                    var triangleSide = double.Parse(Console.ReadLine());
                    var height = double.Parse(Console.ReadLine());

                    var triangleArea = GetTriangleArea(triangleSide, height);

                    Console.WriteLine($"{triangleArea:F2}");
                    break;
                case "square":
                    var squareSide = double.Parse(Console.ReadLine());

                    var squareaArea = GetSquareArea(squareSide);

                    Console.WriteLine($"{squareaArea:F2}");
                    break;
                case "rectangle":
                    var width = double.Parse(Console.ReadLine());
                    var rectangleHeight = double.Parse(Console.ReadLine());

                    var rectangleArea = GetRectangleArea(width, rectangleHeight);

                    Console.WriteLine($"{rectangleArea:F2}");
                    break;
                case "circle":
                    var radius = double.Parse(Console.ReadLine());

                    var circleArea = GetCircleArea(radius);

                    Console.WriteLine($"{circleArea:F2}");
                    break;
            }
        }

        static double GetCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        static double GetRectangleArea(double width, double rectangleHeight)
        {
            return width * rectangleHeight;
        }

        static double GetSquareArea(double squareSide)
        {
            return squareSide * squareSide;
        }

        static double GetTriangleArea(double triangleSide, double height)
        {
            return triangleSide * height / 2;
        }
    }
}
