using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesIpsDuration = new SortedDictionary<string, SortedDictionary<string, int>>();
            var linesNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesNumber; i++)
            {
                var token = Console.ReadLine().Split();
                var name = token[1];
                var ip = token[0];
                var time = int.Parse(token[2]);

                if (!namesIpsDuration.ContainsKey(name))
                {
                    namesIpsDuration[name] = new SortedDictionary<string, int>();
                }
                if (!namesIpsDuration[name].ContainsKey(ip))
                {
                    namesIpsDuration[name][ip] = 0;
                }
                namesIpsDuration[name][ip] += time;
            }
            foreach (var nameIpsDuration in namesIpsDuration)
            {
                var user = nameIpsDuration.Key;
                var ipAndDuration = nameIpsDuration.Value;

                var totalTime = ipAndDuration.Sum(a => a.Value);
                var ips = ipAndDuration.Keys.ToArray();

                Console.WriteLine($"{user}: {totalTime} [{string.Join(", ", ips)}]");
            }
        }
    }
}