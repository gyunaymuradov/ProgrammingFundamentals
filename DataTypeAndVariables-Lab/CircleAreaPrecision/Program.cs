using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaPrecision
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;

            Console.WriteLine($"{area:F12}");
        }
    }
}
