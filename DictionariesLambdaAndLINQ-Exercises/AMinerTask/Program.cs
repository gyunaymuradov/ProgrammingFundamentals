using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resultDict = new Dictionary<string, long>();
            while (true)
            {
                var resource = Console.ReadLine();
                if (resource == "stop")
                {
                    foreach (var item in resultDict)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                    break;
                }
                var quantity = Console.ReadLine();

                var list = new string[2];
                list[0] = resource;
                list[1] = quantity;

                if (resultDict.ContainsKey(resource))
                {
                    resultDict[resource] += long.Parse(quantity);
                }
                else
                {
                    resultDict.Add(resource, long.Parse(quantity));
                }
            }
        }
    }
}
