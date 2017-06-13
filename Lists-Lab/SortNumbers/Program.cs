using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> listToSort = Console.ReadLine().Split().Select(double.Parse).ToList();

            listToSort.Sort();

            Console.WriteLine(string.Join(" <= ", listToSort));
        }
    }
}
