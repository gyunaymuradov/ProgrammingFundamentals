using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfChars = sbyte.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < numberOfChars; i++) 
            {
                char letter = char.Parse(Console.ReadLine());

                sum += letter;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
