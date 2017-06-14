using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numbersToTake = arr[0];
            int numbersToDelete = arr[1];
            int searchedNumber = arr[2];

            List<int> modifiedlist = new List<int>();

            for (int i = 0; i < numbersToTake; i++)
            {
                modifiedlist.Add(list[i]);
            }
            while (numbersToDelete > 0)
            {
                modifiedlist.RemoveAt(0);
                numbersToDelete--;
            }

            bool numIsPresent = false;

            foreach (var item in modifiedlist)
            {
                if (item == searchedNumber)
                {
                    numIsPresent = true;
                    break;
                }
            }
            if (numIsPresent)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
