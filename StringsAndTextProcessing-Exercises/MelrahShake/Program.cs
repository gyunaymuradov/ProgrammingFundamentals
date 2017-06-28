using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();

            while (true)
            {
                var leftIndex = input.IndexOf(pattern);
                var rightIndex = input.LastIndexOf(pattern);

                var leftIndexExist = leftIndex != -1;
                var rightIndexExist = rightIndex != -1;
                var patternIsEmpty = pattern == string.Empty;
                var leftIndexAndRightIndexAreaEqual = leftIndex == rightIndex;

                if (leftIndexExist && rightIndexExist && !leftIndexAndRightIndexAreaEqual && !patternIsEmpty)
                {
                    input = input.Remove(rightIndex, pattern.Length);
                    input = input.Remove(leftIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");
                    pattern = pattern.Remove((0 + pattern.Length) / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
