using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> integers = Console.ReadLine().Split().Select(long.Parse).ToList();


            while (true)
            {
                List<string> commandParameters = Console.ReadLine().Split(' ').ToList();
                string command = commandParameters[0];
                if (command == "Even")
                {
                    foreach (var integer in integers)
                    {
                        if (integer % 2 == 0)
                        {
                            Console.Write($"{integer} ");
                        }
                    }
                    return;
                }
                if (command == "Odd")
                {
                    foreach (var integer in integers)
                    {
                        if (integer % 2 != 0)
                        {
                            Console.Write($"{integer} ");
                        }
                    }
                    return;
                }
                long parameterToModify = long.Parse(commandParameters[1]);

                if (command == "Insert")
                {
                    long indexOfTheParameter = long.Parse(commandParameters[2]);
                    integers.Insert((int)indexOfTheParameter, parameterToModify);
                    continue;
                }
                if (command == "Delete")
                {
                    integers.Remove(parameterToModify);
                }
            }
        }
    }
}