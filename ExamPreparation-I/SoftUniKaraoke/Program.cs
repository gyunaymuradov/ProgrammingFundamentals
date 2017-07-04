using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(',').ToList();
            var songs = Console.ReadLine().Split(',').ToList();
            var partList = new List<Participant>();

            for (int i = 0; i < participants.Count; i++)
            {
                participants[i] = participants[i].Trim();
            }
            for (int i = 0; i < songs.Count; i++)
            {
                songs[i] = songs[i].Trim();
            }

            var input = Console.ReadLine();
            while (input != "dawn")
            {
                var tokens = input.Split(',');
                var participant = tokens[0].Trim();
                var song = tokens[1].Trim();
                var award = tokens[2].Trim();

                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!partList.Any(a => a.Name == participant))
                    {
                        var newParticipant = new Participant();
                        newParticipant.Name = participant;
                        newParticipant.Awards = new List<string>();
                        newParticipant.Awards.Add(award);
                        partList.Add(newParticipant);
                    }
                    else
                    {
                        var index = partList.FindIndex(a => a.Name == participant);
                        if (partList[index].Awards.Contains(award))
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            partList[index].Awards.Add(award);
                        }

                    }
                }
                input = Console.ReadLine();
            }
            var awardsCount = 0;
            foreach (var participant in partList.OrderByDescending(a => a.Awards.Count).ThenBy(a => a.Name))
            {
                var name = participant.Name;
                var awards = participant.Awards;
                Console.WriteLine($"{name}: {awards.Count} awards");
                foreach (var award in awards.OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                    awardsCount++;
                }
            }
            if (awardsCount == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
    class Participant
    {
        public string Name { get; set; }
        public List<string> Awards { get; set; }
    }
}