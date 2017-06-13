using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 0; i < numList.Count - 1; i++)
            {
                if (numList[i] == numList[i + 1])
                {
                    numList[i] = numList[i] + numList[i + 1];
                    numList.Remove(numList[i + 1]);
                    i = -1;
                }
            }
            foreach (var item in numList)
            {
                Console.Write(item + " ");
            }
        }
    }
}