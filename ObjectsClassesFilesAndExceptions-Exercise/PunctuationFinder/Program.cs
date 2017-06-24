using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunctuationFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("input.txt");
            char[] symbols = new[] { '.', ',', '!', '?', ':' };
            var punctuationsList = new List<char>();

            foreach (var word in text)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (symbols.Contains(word[i]))
                    {
                        punctuationsList.Add(word[i]);
                    } 
                }
            }
            Console.WriteLine(string.Join(", ", punctuationsList));
        }
    }
}
