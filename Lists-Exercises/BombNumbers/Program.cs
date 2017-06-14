using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();

            int power = bomb[1];
            int specialNumber = bomb[0];

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == specialNumber)
                {
                    var leftIndex = Math.Max(i - power, 0);
                    var rightIndex = Math.Min(i + power, list.Count - 1);
                    var elementsToRemove = rightIndex - leftIndex + 1;
                    list.RemoveRange(leftIndex, elementsToRemove);

                    i = -1;
                }
            }
            Console.WriteLine(list.Sum());
        }
    }
}