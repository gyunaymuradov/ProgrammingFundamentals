using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoatChar = char.Parse(Console.ReadLine());
            char secondBoatChar = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string firstBoatSpeed = string.Empty;
            string secondBoatSpeed = string.Empty;
            int firstBoatCounter = 0;
            int secondBoatCounter = 0;
            int firstBoatDiff = 0;
            int secondtBoatDiff = 0;

            for (int i = 1; i <= n; i++)
            {
                string boatSpeed = Console.ReadLine();

                if (boatSpeed == "UPGRADE")
                {
                    firstBoatChar = (char)(firstBoatChar + 3);
                    secondBoatChar = (char)(secondBoatChar + 3);
                    continue;
                }

                if (i % 2 == 1)
                {
                    firstBoatSpeed = boatSpeed;
                    firstBoatCounter += firstBoatSpeed.Length;
                }
                else
                {
                    secondBoatSpeed = boatSpeed;
                    secondBoatCounter += secondBoatSpeed.Length;
                }
                firstBoatDiff = 50 - firstBoatCounter;
                secondtBoatDiff = 50 - secondBoatCounter;
                if (firstBoatDiff <= 0)
                {
                    Console.WriteLine(firstBoatChar);
                    return;
                }
                if (secondtBoatDiff <= 0)
                {
                    Console.WriteLine(secondBoatChar);
                    return;
                }
            }
            if (firstBoatDiff < secondtBoatDiff)
            {
                Console.WriteLine(firstBoatChar);
            }
            else
            {
                Console.WriteLine(secondBoatChar);
            }
        }
    }
}
