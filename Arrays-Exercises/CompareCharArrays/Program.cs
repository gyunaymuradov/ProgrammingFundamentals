using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrayA = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arrayB = Console.ReadLine().Split().Select(char.Parse).ToArray();

            for (int i = 0; i < Math.Min(arrayA.Length, arrayB.Length); i++)
            {
                if (arrayA[i] < arrayB[i])
                {
                    foreach (var ch in arrayA)
                    {
                        Console.Write(ch);
                    }

                    Console.WriteLine();

                    foreach (var ch in arrayB)
                    {
                        Console.Write(ch);
                    }
                    return;
                }
                else if (arrayB[i] < arrayA[i])
                {
                    foreach (var ch in arrayB)
                    {
                        Console.Write(ch);
                    }

                    Console.WriteLine();

                    foreach (var ch in arrayA)
                    {
                        Console.Write(ch);
                    }
                    return;
                }
            }
            if (arrayA.Length < arrayB.Length)
                {
                    Console.WriteLine(new string(arrayA));
                    Console.WriteLine(new string(arrayB));
                }
                else 
                {
                    Console.WriteLine(new string(arrayB));
                    Console.WriteLine(new string(arrayA));
                }
            }
        }
    }