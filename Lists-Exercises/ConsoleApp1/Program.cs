using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                List<string> tokens = Console.ReadLine().Split().ToList();
                string command = tokens[0];

                if (command == "Delete")
                {
                    int element = int.Parse(tokens[1]);

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == element)
                        {
                            list.Remove(list[i]);
                            i = -1;
                        }
                    }
                }
                if (command == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);

                    list.Insert(index, element);
                }
                if (command == "Even")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 == 0)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    break;
                }
                if (command == "Odd")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] % 2 != 0)
                        {
                            Console.Write(list[i] + " ");
                        }
                    }
                    break;
                }
            }
        }
    }
}