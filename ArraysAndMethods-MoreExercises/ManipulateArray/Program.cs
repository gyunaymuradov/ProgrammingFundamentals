using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            var linesNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesNumber; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();

                if (command[0] == "Reverse")
                {
                    Array.Reverse(arr);
                }
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    arr[index] = command[2];
                }
                else if (command[0] == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                }
            }
            Console.Write(string.Join(", ", arr));
            Console.WriteLine();
        }
    }
}
