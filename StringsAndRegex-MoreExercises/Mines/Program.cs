using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var startIndex = 0;
            var endIndex = 0;

            while ((startIndex = input.IndexOf("<", startIndex)) != -1 && (endIndex = input.IndexOf(">", startIndex)) != -1)
            {
                var bombChars = input.Substring(startIndex + 1, 2);
                var bombStrength = CalculateMineStrength(bombChars);

                var leftSide = Math.Max(0, startIndex - bombStrength);
                var rightSide = Math.Min(input.Length - 1, endIndex + bombStrength);

                var sb = new StringBuilder(input);

                for (int i = leftSide; i <= rightSide; i++)
                {
                    sb[i] = '_';
                }
                input = sb.ToString();
            }
            Console.WriteLine(input);
        }
        static int CalculateMineStrength(string bombChars)
        {
            return Math.Abs(bombChars[0] - bombChars[1]);
        }
    }
}
