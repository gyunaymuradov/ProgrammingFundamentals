using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = 0;
            var sum = 0;

            while (true)
            {
                int tempIndex = index;
                sum += arr[index];
                index += arr[index];

                if (index >= arr.Length)
                {
                    index = tempIndex - arr[tempIndex];
                    if (index < 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}