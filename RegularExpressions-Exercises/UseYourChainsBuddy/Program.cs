using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var paragraphRegex = new Regex(@"<p>(?<message>.+?)<\/p>");
            var paragraphs = paragraphRegex.Matches(input).Cast<Match>()
                .Select(a => a.Groups["message"].Value)
                .Select(a => Regex.Replace(a, @"[^a-z\d]+", " "))
                .Select(a => Regex.Replace(a, @"\s+", " ")).ToArray();

            for (int i = 0; i < paragraphs.Length; i++)
            {
                paragraphs[i] = Rot13String(paragraphs[i]);
            }
            var result = new StringBuilder();
            foreach (var paragraph in paragraphs)
            {
                result.Append(paragraph);
            }

            Console.WriteLine(result.ToString());
        }

        static string Rot13String(string input)
        {
            var result = new StringBuilder();

            foreach (var letter in input)
            {
                result.Append(Rot13Letter(letter));
            }
            return result.ToString();
        }
        static char Rot13Letter(char letter)
        {
            if (!char.IsLetter(letter))
            {
                return letter;
            }
            var offset = char.IsUpper(letter) ? 'A' : 'a';
            var rotatedLetter = (char)((letter - offset + 13) % 26 + offset);
            return rotatedLetter;
        }
    }
}
