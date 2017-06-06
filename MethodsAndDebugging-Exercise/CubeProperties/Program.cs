using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine();

            if (parameter == "face")
            {
                Console.WriteLine($"{GetFaceDiagonals(side):F2}");
            }
            else if (parameter == "space")
            {
                Console.WriteLine($"{GetSpaceDiagonals(side):F2}");
            }
            else if (parameter == "volume")
            {
                Console.WriteLine($"{GetVolume(side):F2}");
            }
            else if (parameter == "area")
            {
                Console.WriteLine($"{GetSurfaceArea(side):F2}");
            }
        }

        static double GetSurfaceArea(double side)
        {
            return 6 * Math.Pow(side, 2);
        }

        static double GetVolume(double side)
        {
            return Math.Pow(side, 3);
        }

        static double GetSpaceDiagonals(double side)
        {
            return Math.Sqrt(3 * Math.Pow(side, 2));
        }

        static double GetFaceDiagonals(double side)
        {
            return Math.Sqrt(2 * Math.Pow(side, 2));
        }
    }
}
