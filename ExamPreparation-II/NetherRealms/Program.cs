using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<char> invalidSymbols = new List<char> { '+', '-', '*', '/', '.' };

            var dict = new SortedDictionary<string, Dictionary<long, decimal>>();

            foreach (var name in names)
            {
                long health = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsLetter(name[i]))
                    {
                        health += name[i];
                    }
                    else if (!char.IsDigit(name[i]) && !invalidSymbols.Contains(name[i]))
                    {
                        health += name[i];
                    }
                }
                var pattern = @"\+*(\-*[0-9]\.*[0-9]*)";
                var matches = Regex.Matches(name, pattern);
                decimal damage = 0.0m;
                foreach (Match match in matches)
                {
                    var num = match.Groups[1].Value;
                    if (num.Contains('.'))
                    {
                        damage += decimal.Parse(num);
                    }
                    else
                    {
                        damage += long.Parse(num);
                    }
                }

                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == '*')
                    {
                        damage *= 2;
                    }
                    else if (name[i] == '/')
                    {
                        damage /= 2;
                    }
                }
                dict[name] = new Dictionary<long, decimal>();
                dict[name][health] = damage;
            }
            foreach (var name in dict)
            {
                var demon = name.Key;
                var damageHealth = name.Value;

                foreach (var dmghlth in damageHealth)
                {
                    var dmg = dmghlth.Key;
                    var hlth = dmghlth.Value;
                    Console.WriteLine($"{name.Key} - {dmg} health, {hlth:F2} damage");
                }
            }
        }
    }
}