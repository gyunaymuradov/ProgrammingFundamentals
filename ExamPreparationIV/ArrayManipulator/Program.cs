using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var command = Console.ReadLine();

            while (command != "end")
            {
                var tokens = command.Split(' ');
                if (tokens[0] == "exchange")
                {
                    var index = int.Parse(tokens[1]);
                    if (index < 0 || index >= arr.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        arr = Exchange(arr, index);
                    }
                }
                else if (tokens[0] == "max")
                {
                    var type = tokens[1];
                    if (type == "even")
                    {
                        var list = new List<int>();
                        list.AddRange(arr.Where(a => a % 2 == 0));
                        if (list.Count == 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            var index = list.IndexOf(list.Max());
                            var num = list[index];
                            Console.WriteLine(arr.ToList().LastIndexOf(num));
                        }

                    }
                    else
                    {
                        var list = new List<int>();
                        list.AddRange(arr.Where(a => a % 2 != 0));
                        if (list.Count == 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            var index = list.IndexOf(list.Max());
                            var num = list[index];
                            Console.WriteLine(arr.ToList().LastIndexOf(num));
                        }
                    }
                }
                else if (tokens[0] == "min")
                {
                    var type = tokens[1];
                    if (type == "even")
                    {
                        var list = new List<int>();
                        list.AddRange(arr.Where(a => a % 2 == 0));
                        if (list.Count == 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            var index = list.IndexOf(list.Min());
                            var num = list[index];
                            Console.WriteLine(arr.ToList().LastIndexOf(num));
                        }
                    }
                    else
                    {
                        var list = new List<int>();
                        list.AddRange(arr.Where(a => a % 2 != 0));
                        if (list.Count == 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            var index = list.IndexOf(list.Min());
                            var num = list[index];
                            Console.WriteLine(arr.ToList().LastIndexOf(num));
                        }
                    }
                }
                else if (tokens[0] == "first")
                {
                    var count = int.Parse(tokens[1]);
                    if (count < 0 || count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (tokens[2] == "even")
                        {
                            var list = new List<int>();
                            list.AddRange(arr.Where(a => a % 2 == 0));
                            if (list.Count - 1 < count)
                            {
                                Console.WriteLine($"[{string.Join(", ", list)}]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", list.Take(count))}]");
                            }
                        }
                        else
                        {
                            var list = new List<int>();
                            list.AddRange(arr.Where(a => a % 2 != 0));
                            if (list.Count - 1 < count)
                            {
                                Console.WriteLine($"[{string.Join(", ", list)}]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", list.Take(count))}]");
                            }
                        }
                    }
                }
                else if (tokens[0] == "last")
                {
                    var count = int.Parse(tokens[1]);
                    if (count < 0 || count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (tokens[2] == "even")
                        {
                            var list = new List<int>();
                            list.AddRange(arr.Where(a => a % 2 == 0));
                            if (list.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                list.Reverse();
                                if (list.Count - 1 < count)
                                {
                                    Console.WriteLine($"[{string.Join(", ", list)}]");
                                }
                                else
                                {
                                    Console.WriteLine($"[{string.Join(", ", list.Take(count))}]");
                                }
                            }
                        }
                        else
                        {
                            var list = new List<int>();
                            list.AddRange(arr.Where(a => a % 2 != 0));
                            if (list.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                if (list.Count - 1 < count)
                                {
                                    Console.WriteLine($"[{string.Join(", ", list)}]");
                                }
                                else
                                {
                                    Console.WriteLine($"[{string.Join(", ", list.Skip(list.Count - count))}]");
                                }
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        static int[] Exchange(int[] arr, int index)
        {
            var subArr1 = arr.Skip(index + 1).Take(arr.Length - index).ToList();
            subArr1.AddRange(arr.Take(index + 1).ToArray());
            arr = subArr1.ToArray();
            return arr;
        }
    }
}
