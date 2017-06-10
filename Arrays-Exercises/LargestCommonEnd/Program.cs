using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split(' ').ToArray();
            string[] arrayTwo = Console.ReadLine().Split(' ').ToArray();

            int counterForTheLeftSide = 0;
            int counterForTheRightSide = 0;

            var smallerArraylength = Math.Min(arrayOne.Length, arrayTwo.Length);
            for (int i = 0; i < smallerArraylength; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
                {
                    counterForTheLeftSide++;
                }
                if (arrayOne[arrayOne.Length - i - 1] == arrayTwo[arrayTwo.Length - i - 1])
                {
                    counterForTheRightSide++;
                }
            }
            Console.WriteLine(Math.Max(counterForTheRightSide, counterForTheLeftSide));
        }
    }
}
