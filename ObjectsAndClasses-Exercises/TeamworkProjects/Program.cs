using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamCount = int.Parse(Console.ReadLine());
            var teamsList = new List<Team>();
            for (int i = 0; i < teamCount; i++)
            {
                var tokens = Console.ReadLine().Split('-').ToArray();
                var creator = tokens[0];
                var teamName = tokens[1];
                var membersList = new List<string>();
                var team = new Team();
                team.TeamName = teamName;
                team.CreatorName = creator;
                team.Members = membersList;

                if (!teamsList.Any(a => a.TeamName == teamName))
                {
                    if (!teamsList.Any(a => a.CreatorName == creator))
                    {
                        teamsList.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                    else
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            var input = Console.ReadLine();
            while (input != "end of assignment")
            {
                var tokens = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var user = tokens[0];
                var team = tokens[1];

                if (!teamsList.Any(x => x.TeamName == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }
                else if (teamsList.Any(a => a.CreatorName == user) ||
                teamsList.Any(a => a.Members.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                }
                else
                {
                    var teamToJoinIndex = teamsList.FindIndex(a => a.TeamName == team);
                    teamsList[teamToJoinIndex].Members.Add(user);
                }
                input = Console.ReadLine();
            }
            var teamsToDisband = teamsList.OrderBy(a => a.TeamName).Where(x => x.Members.Count == 0).Select(a => a.TeamName).ToList();
            foreach (Team team in teamsList.OrderByDescending(a => a.Members.Count).ThenBy(b => b.TeamName).Where(a => a.Members.Count > 0))
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.CreatorName}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            if (teamsToDisband.Count > 0)
            {
                foreach (var disbTeam in teamsToDisband)
                {
                    Console.WriteLine(disbTeam);
                }
            }
        }
    }
    class Team
    {
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
        public string CreatorName { get; set; }
    }
}
