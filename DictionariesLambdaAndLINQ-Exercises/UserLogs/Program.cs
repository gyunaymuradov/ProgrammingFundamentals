using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var usersIpsMessageCount = new SortedDictionary<string, Dictionary<string, int>>();

            while (line != "end")
            {
                var token = line.Split(' ');
                var ipToken = token[0];
                var messageToken = token[1];
                var userToken = token[2];

                var user = userToken.Split('=')[1];
                var ip = ipToken.Split('=')[1];

                if (!usersIpsMessageCount.ContainsKey(user))
                {
                    usersIpsMessageCount[user] = new Dictionary<string, int>();
                }
                if (!usersIpsMessageCount[user].ContainsKey(ip))
                {
                    usersIpsMessageCount[user][ip] = 0;
                }
                usersIpsMessageCount[user][ip]++;

                line = Console.ReadLine();
            }

            foreach (var userIpsMessageCount in usersIpsMessageCount)
            {
                var user = userIpsMessageCount.Key;
                var ipAndMessageCount = userIpsMessageCount.Value;

                var ips = ipAndMessageCount.Keys.ToArray();
                var messagesCount = ipAndMessageCount.Values.ToArray();

                Console.WriteLine($"{user}: ");
                var count = ipAndMessageCount.Count;
                foreach (var ip in ipAndMessageCount)
                {
                    if (count > 1)
                    {
                        Console.Write($"{ip.Key} => {ip.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value}.");
                    }
                    count--;
                }
            }
        }
    }
}