using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool containsTriples = false;

            for (int a = 0; a < array.Length; a++)
            {
                for (int b = a + 1; b < array.Length; b++)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[a] + array[b] == array[i])
                        {
                            Console.WriteLine($"{array[a]} + {array[b]} == {array[i]}");
                            containsTriples = true;
                            break;
                        }
                    }
                }
            }
            if (!containsTriples)
            {
                Console.WriteLine("No");
            }
        }
    }
}
