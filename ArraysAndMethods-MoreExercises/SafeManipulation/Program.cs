using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            while (true)
            {
                string[] instructionsSet = Console.ReadLine().Split(' ').ToArray();
                string command = instructionsSet[0];
                if (command == "END")
                {
                    break;
                }
                if (command == "Reverse")
                {
                    Array.Reverse(arr);
                }
                else if (command == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                }
                else if (command == "Replace")
                {
                    int index = int.Parse(instructionsSet[1]);
                    if (index >= arr.Length || index < 0)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    arr[index] = instructionsSet[2];
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }

            Console.Write(string.Join(", ", arr));
            Console.WriteLine();
        }
    }
}