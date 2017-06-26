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
            var participants = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var availableSongs = Console.ReadLine().Split(',').ToList();
            var trimmedSongs = new List<string>();

            var listOfParicipantsAndAwards = new List<Participant>();

            foreach (var song in availableSongs)
            {
                trimmedSongs.Add(song.Trim());
            }

            var input = Console.ReadLine();
            while (input != "dawn")
            {
                var tokens = input.Split(',').ToArray();
                var participantName = tokens[0];
                var song = tokens[1].Trim();
                var award = tokens[2].Trim();

                if (participants.Contains(participantName) && trimmedSongs.Contains(song))
                {
                    if (!listOfParicipantsAndAwards.Any(a => a.Name == participantName))
                    {
                        var newParticipant = new Participant();
                        newParticipant.Name = participantName;
                        newParticipant.Awards = new List<string>();
                        newParticipant.Awards.Add(award);
                        listOfParicipantsAndAwards.Add(newParticipant);
                    }
                    else
                    {
                        var participant = listOfParicipantsAndAwards.FindIndex(a => a.Name == participantName);
                        if (listOfParicipantsAndAwards[participant].Awards.Contains(award))
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            listOfParicipantsAndAwards[participant].Awards.Add(award);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var participant in listOfParicipantsAndAwards.OrderByDescending(a => a.Awards.Count)
                .ThenBy(a => a.Name))
            {
                var awardsCount = participant.Awards.Count;
                Console.WriteLine($"{participant.Name}: {awardsCount} awards");
                foreach (var award in participant.Awards.OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                }
            }
            if (listOfParicipantsAndAwards.Count == 0)
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