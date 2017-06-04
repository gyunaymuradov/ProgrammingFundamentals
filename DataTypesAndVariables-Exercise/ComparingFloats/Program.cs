using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            bool areEqual = false;
            double diff = Math.Abs(num1 - num2);

            if (diff < 0.000001)
            {
                areEqual = true;
            }

            Console.WriteLine(areEqual);
        }
    }
}
