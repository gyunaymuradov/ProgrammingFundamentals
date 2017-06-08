using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfElements = int.Parse(Console.ReadLine());

            var array = new int [numOfElements];

            for (int i = 0; i < numOfElements; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");

            }
        }
    }
}
