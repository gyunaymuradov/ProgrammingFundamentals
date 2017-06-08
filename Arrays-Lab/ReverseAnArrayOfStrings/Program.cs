using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
           
            string[] reversedArray = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - i - 1];
            }

            Console.WriteLine(string.Join(" ", reversedArray));

            /*for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }*/
        }   
    }
}
