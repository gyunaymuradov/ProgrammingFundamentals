using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var foundHideout = false;
            while (!foundHideout)
            {
                var tokens = Console.ReadLine().Split();
                var searchedChar = char.Parse(tokens[0]);
                var minCount = int.Parse(tokens[1]);
                for (int i = 0; i < input.Length; i++)
                {
                    var counter = 0;
                    if (input[i] == searchedChar)
                    {
                        var j = i;
                        while (input[j] == searchedChar)
                        {
                            counter++;
                            j++;
                            if (j >= input.Length)
                            {
                                break;
                            }
                        }
                        if (counter >= minCount)
                        {
                            foundHideout = true;
                            Console.WriteLine($"Hideout found at index {i} and it is with size {counter}!");
                        }
                        i = j - 1;
                    }
                }
            }
        }
    }
}
