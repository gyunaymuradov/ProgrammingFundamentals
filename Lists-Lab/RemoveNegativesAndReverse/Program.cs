using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInt = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> positiveInts = new List<int>();

            foreach (var integer in listOfInt)
            {
                if (integer >= 0)
                {
                    positiveInts.Add(integer);
                }
            }

            positiveInts.Reverse();

            if (positiveInts.Count > 0)
            {
                Console.Write(string.Join(" ", positiveInts));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
