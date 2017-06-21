using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var words = input.Split(' ').ToList();

            var rnd = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                var randomPosition = rnd.Next(0, words.Count);

                var currentWord = words[i];
                var tempWord = words[randomPosition];
                words[randomPosition] = currentWord;
                words[i] = tempWord;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}