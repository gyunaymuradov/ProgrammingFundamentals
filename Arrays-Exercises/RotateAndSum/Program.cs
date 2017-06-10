using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rotationsCount = int.Parse(Console.ReadLine());

            var sumArray = new int[array.Length];
            for (int i = 0; i < rotationsCount; i++)
            {
                RotateArray(array);

                for (int j = 0; j < array.Length; j++)
                {
                    sumArray[j] += array[j];
                }
            }
            foreach (var currentParameter in sumArray)
            {
                Console.Write($"{currentParameter} ");
            }

        }

        static void RotateArray(int[] array)
        {
            var lastElement = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastElement;
        }
    }
}
