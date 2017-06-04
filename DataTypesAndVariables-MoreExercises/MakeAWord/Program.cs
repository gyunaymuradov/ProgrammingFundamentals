using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberOfLines = sbyte.Parse(Console.ReadLine());
            string word = String.Empty;
            for (int i = 0; i < numberOfLines; i++)
            {
                char character = char.Parse(Console.ReadLine());

                word += character;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
