using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var exceptionCounter = 0;
            var commandTokens = Console.ReadLine();



            while (exceptionCounter < 3)
            {
                var tokens = commandTokens.Split(' ');
                var command = tokens[0];
                if (command == "Replace")
                {
                    try
                    {
                        var index = int.Parse(tokens[1]);
                        var element = int.Parse(tokens[2]);
                        try
                        {
                            arr[index] = element;
                        }
                        catch
                        {
                            Console.WriteLine("The index does not exist!");
                            exceptionCounter++;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptionCounter++;
                    }
                }
                else if (command == "Print")
                {
                    try
                    {
                        var startIndex = int.Parse(tokens[1]);
                        var endIndex = int.Parse(tokens[2]);
                        try
                        {
                            if (startIndex < 0)
                            {
                                for (int i = startIndex; i <= endIndex; i++)
                                {
                                    Console.Write(string.Join(", ", arr[i]));
                                }
                            }
                            else if (endIndex >= arr.Length)
                            {
                                for (int i = endIndex; i >= endIndex; i--)
                                {
                                    Console.Write(string.Join(", ", arr[i]));
                                }
                            }
                            var list = new List<int>();
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                list.Add(arr[i]);
                            }
                            Console.WriteLine(string.Join(", ", list));
                        }
                        catch
                        {
                            Console.WriteLine("The index does not exist!");
                            exceptionCounter++;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptionCounter++;
                    }
                }
                else if (command == "Show")
                {
                    try
                    {
                        var index = int.Parse(tokens[1]);
                        try
                        {
                            Console.WriteLine(arr[index]);
                        }
                        catch
                        {
                            exceptionCounter++;
                            Console.WriteLine("The index does not exist!");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("The variable is not in the correct format!");
                        exceptionCounter++;
                    }
                }
                commandTokens = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
