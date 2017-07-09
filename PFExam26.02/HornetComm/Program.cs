using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            var broadcasts = new List<Broadcasts>();
            var messages = new List<Messages>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Hornet is Green")
                {
                    break;
                }
                var messagePattern = @"^(?<left>\d+) \<\-\> (?<right>[a-zA-Z0-9]+)$";
                var broadcastPattern = @"^(?<left>\D+) \<\-\> (?<right>[a-zA-Z0-9]+)$";

                var messageRegex = new Regex(messagePattern);
                var broadcastRegex = new Regex(broadcastPattern);

                if (messageRegex.IsMatch(input))
                {
                    var match = Regex.Match(input, messagePattern);
                    var left = match.Groups["left"].Value.ToCharArray();
                    var right = match.Groups["right"].Value.ToCharArray();
                    Array.Reverse(left);
                    var recipient = new string(left);
                    var message = new string(right);
                    var currentMessage = new Messages();
                    currentMessage.Message = message;
                    currentMessage.Recepient = recipient;
                    messages.Add(currentMessage);
                }
                else if (broadcastRegex.IsMatch(input))
                {
                    var match = Regex.Match(input, broadcastPattern);
                    var left = match.Groups["left"].Value.ToCharArray();
                    var right = match.Groups["right"].Value.ToCharArray();

                    for (int i = 0; i < right.Length; i++)
                    {
                        if (char.IsUpper(right[i]))
                        {
                            right[i] = char.ToLower(right[i]);
                        }
                        else if (char.IsLower(right[i]))
                        {
                            right[i] = char.ToUpper(right[i]);
                        }
                    }
                    var currentBroadcast = new Broadcasts();
                    var frequency = new string(right);
                    var message = new string(left);
                    currentBroadcast.Message = message;
                    currentBroadcast.Frequency = frequency;
                    broadcasts.Add(currentBroadcast);
                }

            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count > 0)
            {
                foreach (var br in broadcasts)
                {
                    var freq = br.Frequency;
                    var mess = br.Message;

                    Console.WriteLine($"{freq} -> {mess}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (messages.Count > 0)
            {
                foreach (var message in messages)
                {
                    var rec = message.Recepient;
                    var mess = message.Message;

                    Console.WriteLine($"{rec} -> {mess}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }

    }
    class Broadcasts
    {
        public string Frequency { get; set; }
        public string Message { get; set; }
    }
    class Messages
    {
        public string Recepient { get; set; }
        public string Message { get; set; }
    }
}