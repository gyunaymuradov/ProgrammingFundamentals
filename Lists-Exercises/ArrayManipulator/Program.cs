using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();


            while (true)
            {
                List<string> commandSet = Console.ReadLine().Split().ToList();

                string command = commandSet[0];
                if (command == "print")
                {
                    Console.WriteLine($"[{string.Join(", ", list)}]");
                    break;
                }
                if (command == "contains")
                {
                    bool contains = false;
                    int element = int.Parse(commandSet[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (element == list[i])
                        {
                            contains = true;
                            Console.WriteLine(i);
                            break;
                        }
                    }
                    if (!contains)
                    {
                        Console.WriteLine("-1");
                    }
                    continue;
                }
                if (command == "add")
                {
                    int index = int.Parse(commandSet[1]);
                    int parameter = int.Parse(commandSet[2]);
                    list.Insert(index, parameter);
                    continue;
                }
                if (command == "sumPairs")
                {
                    List<int> temp = new List<int>();

                    for (int i = 0; i < list.Count - 1; i += 2)
                    {
                        temp.Add(list[i] + list[i + 1]);
                    }
                    if (list.Count % 2 != 0)
                    {
                        temp.Add(list[list.Count - 1]);
                    }
                    list = temp;
                    continue;
                }
                if (command == "shift")
                {
                    int rotation = int.Parse(commandSet[1]) % list.Count;
                    for (int i = 0; i < rotation ; i++)
                    {
                        list.Add(list[0]);
                        list.RemoveAt(0);
                    }
                    continue;
                }
                if (command == "remove")
                {
                    int index = int.Parse(commandSet[1]);
                    list.RemoveAt(index);
                    continue;
                }
                if (command == "addMany")
                {
                    int index = int.Parse(commandSet[1]);
                    for (int i = 2; i < commandSet.Count; i++)
                    {
                        int parameter = int.Parse(commandSet[i]);
                        list.Insert(index, parameter);
                        index++;
                    }
                }
            }
        }
    }
}