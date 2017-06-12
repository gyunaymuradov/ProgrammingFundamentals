using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = new char[26];

            int j = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet[j] = i;
                j++;
            }

            string word = Console.ReadLine();
            foreach (var letter in word)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (letter == alphabet[i])
                    {
                        Console.WriteLine($"{letter} -> {i}");
                    }
                }
            }
        }
    }
}
