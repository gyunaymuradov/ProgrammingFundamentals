using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?<username>[A-Za-z]{5,})@(?<domain>[a-z]{3,}\.(bg|org|com))\b";
            var n = int.Parse(Console.ReadLine());
            var regex = new Regex(pattern);
            var domainDict = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                var mail = Console.ReadLine();
                if (regex.IsMatch(mail))
                {
                    var match = regex.Match(mail);
                    var username = match.Groups["username"].Value;
                    var domain = match.Groups["domain"].Value;

                    if (!domainDict.ContainsKey(domain))
                    {
                        domainDict[domain] = new List<string>();
                    }
                    if (!domainDict[domain].Contains(username))
                    {
                        domainDict[domain].Add(username);
                    }
                }
            }
            foreach (var currentDomain in domainDict.OrderByDescending(a => a.Value.Count))
            {
                var domain = currentDomain.Key;

                Console.WriteLine($"{domain}:");
                foreach (var user in currentDomain.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}
