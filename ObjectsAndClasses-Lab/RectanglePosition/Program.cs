using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class Program
    {
        public class Rectangle
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Right
            {
                get { return Left + Width; }
            }

            public int Bottom
            {
                get { return Top + Height; }
            }
        }

        static void Main(string[] args)
        {
            var firstRectangleData = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var firstRectangle = new Rectangle
            {
                Left = firstRectangleData[0],
                Top = firstRectangleData[1],
                Width = firstRectangleData[2],
                Height = firstRectangleData[3]
            };

            var secondRectangleData = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondRectangle = new Rectangle
            {
                Left = secondRectangleData[0],
                Top = secondRectangleData[1],
                Width = secondRectangleData[2],
                Height = secondRectangleData[3]
            };

            bool isInside = CheckRectangle(firstRectangle, secondRectangle);
            if (isInside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }

        }

        static bool CheckRectangle(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            var leftIsValid = firstRectangle.Left >= secondRectangle.Left;
            var rightIsValid = firstRectangle.Right <= secondRectangle.Right;
            var topIsValid = firstRectangle.Top <= secondRectangle.Top;
            var bottomIsValid = firstRectangle.Bottom <= secondRectangle.Bottom;

            return leftIsValid && rightIsValid && topIsValid && bottomIsValid;
        }
    }
}
