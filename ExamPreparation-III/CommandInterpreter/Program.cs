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
            var list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(' ');
                if (tokens[0] == "reverse")
                {
                    var start = int.Parse(tokens[2]);
                    var count = int.Parse(tokens[4]);

                    if (start < 0 || start >= list.Count || count < 0 || start + count > list.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        input = Console.ReadLine();
                        continue;
                    }
                    var helper = new List<string>();
                    for (int i = start; i < start + count; i++)
                    {
                        helper.Add(list[i]);
                    }
                    helper.Reverse();
                    var j = 0;
                    for (int i = start; i < start + count; i++)
                    {
                        list[i] = helper[j];
                        j++;
                    }
                }
                else if (tokens[0] == "sort")
                {
                    var start = int.Parse(tokens[2]);
                    var count = int.Parse(tokens[4]);

                    if (start < 0 || start >= list.Count || count < 0 || start + count > list.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        input = Console.ReadLine();
                        continue;
                    }
                    var helper = new List<string>();
                    for (int i = start; i < start + count; i++)
                    {
                        helper.Add(list[i]);
                    }
                    helper.Sort();
                    var j = 0;
                    for (int i = start; i < start + count; i++)
                    {
                        list[i] = helper[j];
                        j++;
                    }
                }
                else if (tokens[0] == "rollLeft")
                {
                    var count = int.Parse(tokens[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        input = Console.ReadLine();
                        continue;
                    }
                    for (int i = 0; i < count % list.Count; i++)
                    {
                        var firstElement = list[0];
                        list.Add(firstElement);
                        list.RemoveAt(0);
                    }

                }
                else if (tokens[0] == "rollRight")
                {
                    var count = int.Parse(tokens[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        input = Console.ReadLine();
                        continue;
                    }
                    for (int i = 0; i < count % list.Count; i++)
                    {
                        list.Insert(0, list[list.Count - 1]);
                        list.RemoveAt(list.Count - 1);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", list)}]");
        }
    }
}
