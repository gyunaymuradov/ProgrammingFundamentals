using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> dict = new SortedDictionary<string, string>();
            while (true)
            {
                List<string> list = Console.ReadLine().Split().ToList();
                string command = list[0];
                if (command == "END")
                {
                    break;
                }
                if (command == "ListAll")
                {
                    foreach (var person in dict)
                    {
                        Console.WriteLine($"{person.Key} -> {person.Value}");
                    }
                    continue;
                }
                string name = list[1];

                if (command == "A")
                {
                    string number = list[2];
                    if (dict.ContainsKey(name))
                    {
                        dict[name] = number;
                    }
                    else
                    {
                        dict.Add(name, number);
                    }
                }
                else if (command == "S")
                {
                    if (dict.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {dict[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
            }
        }
    }
}