using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var tokens = line.Split(' ');
                var command = tokens[0];
                if (myList.Count == 0)
                {
                    Console.WriteLine("Invalid input parameters.");
                    line = Console.ReadLine();
                    continue;
                }
                if (command == "reverse")
                {
                    var start = int.Parse(tokens[2]);
                    var count = int.Parse(tokens[4]);
                    if (start < 0 || start + count > myList.Count || count < 0 || start >= myList.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        line = Console.ReadLine();
                        continue;
                    }
                    Reverse(myList, start, count);
                }
                else if (command == "sort")
                {
                    var start = int.Parse(tokens[2]);
                    var count = int.Parse(tokens[4]);
                    if (start < 0 || start + count > myList.Count || count < 0 || start >= myList.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        line = Console.ReadLine();
                        continue;
                    }
                    Sort(myList, start, count);
                }
                else if (command == "rollLeft")
                {
                    var count = int.Parse(tokens[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        line = Console.ReadLine();
                        continue;
                    }
                    RollLeft(myList, count);
                }
                else if (command == "rollRight")
                {
                    var count = int.Parse(tokens[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        line = Console.ReadLine();
                        continue;
                    }
                    RollRight(myList, count);
                }
                line = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", myList)}]");
        }

        static List<string> RollRight(List<string> myList, int count)
        {
            for (int i = 0; i < count % myList.Count; i++)
            {
                myList.Insert(0, myList[myList.Count - 1]);
                myList.RemoveAt(myList.Count - 1);
            }
            return myList;
        }

        static List<string> RollLeft(List<string> myList, int count)
        {
            for (int i = 0; i < count % myList.Count; i++)
            {
                myList.Add(myList[0]);
                myList.RemoveAt(0);
            }

            return myList;
        }

        static List<string> Sort(List<string> myList, int start, int count)
        {
            var helperList = new List<string>();
            helperList.AddRange(myList.Skip(start).Take(count));
            helperList.Sort();
            var index = 0;
            for (int i = start; i < start + count; i++)
            {
                myList[i] = helperList[index++];
            }
            return myList;
        }

        static List<string> Reverse(List<string> myList, int start, int count)
        {
            var helperList = new List<string>();

            helperList.AddRange(myList.Skip(start).Take(count));
            helperList.Reverse();
            var index = 0;

            for (int i = start; i < start + count; i++)
            {
                myList[i] = helperList[index++];
            }
            return myList;
        }
    }
}
