using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var input = Console.ReadLine();
            var dict = new Dictionary<string, List<int>>();

            while (input != "final")
            {
                var text = input.Split(' ');

                var firstTeam = text[0];
                var start = firstTeam.IndexOf(key);
                var end = firstTeam.LastIndexOf(key);
                var extractFirstTeamName = firstTeam.Substring(start + key.Length, end - key.Length - start);
                var firstTeamName = extractFirstTeamName.ToUpper().ToCharArray();
                Array.Reverse(firstTeamName);
                var team1 = new string(firstTeamName);

                var secondTeam = text[1];
                start = secondTeam.IndexOf(key);
                end = secondTeam.LastIndexOf(key);
                var extractSecondTeamName = secondTeam.Substring(start + key.Length, end - key.Length - start);
                var secondTeamName = extractSecondTeamName.ToUpper().ToCharArray();
                Array.Reverse(secondTeamName);
                var team2 = new string(secondTeamName);

                var result = text[2].Split(':');
                var goalsFirstTeam = int.Parse(result[0]);
                var goalsSecondTeam = int.Parse(result[1]);

                int firstTeamPoints = 0;
                int secondTeamPoints = 0;

                if (goalsFirstTeam > goalsSecondTeam)
                {
                    firstTeamPoints = 3;
                    secondTeamPoints = 0;
                }
                else if (goalsSecondTeam > goalsFirstTeam)
                {
                    firstTeamPoints = 0;
                    secondTeamPoints = 3;
                }
                else
                {
                    firstTeamPoints = 1;
                    secondTeamPoints = 1;
                }

                if (dict.ContainsKey(team1))
                {
                    dict[team1][0] += firstTeamPoints;
                    dict[team1][1] += goalsFirstTeam;
                }
                else
                {
                    dict[team1] = new List<int>();
                    dict[team1].Add(firstTeamPoints);
                    dict[team1].Add(goalsFirstTeam);
                }

                if (dict.ContainsKey(team2))
                {
                    dict[team2][0] += secondTeamPoints;
                    dict[team2][1] += goalsSecondTeam;
                }
                else
                {
                    dict[team2] = new List<int>();
                    dict[team2].Add(secondTeamPoints);
                    dict[team2].Add(goalsSecondTeam);
                }
                input = Console.ReadLine();
            }
            var number = 1;
            Console.WriteLine("League standings:");

            foreach (var country in dict.OrderByDescending(a => a.Value[0]).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{number}. {country.Key} {country.Value[0]}");
                number++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var top3 in dict.OrderByDescending(a => a.Value[1]).ThenBy(a => a.Key).Take(3))
            {
                Console.WriteLine($"- {top3.Key} -> {top3.Value[1]}");
            }
        }
    }
}
