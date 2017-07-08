using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {

            const string patern = @"([$#^@])\1{5,}";

            var ticketRegex = new Regex(patern);

            var tickets = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                .ToArray();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                var leftHalf = ticket.Substring(0, ticket.Length / 2);
                var rightHalf = ticket.Substring(ticket.Length / 2);

                var leftMatch = ticketRegex.Match(leftHalf);
                var rightMatch = ticketRegex.Match(rightHalf);

                if (leftMatch.Success && rightMatch.Success)
                {
                    var winningSimbol = leftMatch.Value[0];
                    var shorterMatch = Math.Min(leftMatch.Length, rightMatch.Length);

                    var jacpot = string.Empty;

                    if (shorterMatch == 10)
                    {
                        jacpot = "Jackpot!";
                    }

                    Console.WriteLine($"ticket \"{ticket}\" - {shorterMatch}{winningSimbol} {jacpot}");
                }

                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
