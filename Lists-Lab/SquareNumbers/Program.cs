using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integersList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> resultList = new List<int>();

            foreach (var integer in integersList)
            {
                if (Math.Sqrt(integer) == (int)Math.Sqrt(integer))
                {
                    resultList.Add(integer);
                }
            }
            resultList.Sort();
            resultList.Reverse();
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
