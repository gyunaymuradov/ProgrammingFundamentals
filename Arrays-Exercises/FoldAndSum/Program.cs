using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = arr.Length / 4;
            int[] leftArray = new int[k];
            int[] rightArray = new int[k];
            int[] middleArray = new int[2 * k];
            int[] resultArray = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                leftArray[i] = arr[i];
                rightArray[i] = arr[i + 3 * k];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                middleArray[i] = arr[i + k];
            }

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);

            for (int i = 0; i < k; i++)
            {
                resultArray[i] += leftArray[i];
                resultArray[i + k] += rightArray[i];
            }

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] += middleArray[i];
            }
            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}