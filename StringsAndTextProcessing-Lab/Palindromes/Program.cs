using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new char[] { ',', '.', ';', ':', '!', '?', ' ', '-', '"', '\'', '[', ']', '(', ')', '{', '}', '\\', '<','>', '+','*', '%', '~' },
                StringSplitOptions.RemoveEmptyEntries);
            var palindromesList = new List<string>();
            foreach (var word in text)
            {
                if (CheckIfIsPalindrome(word))
                {
                    palindromesList.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", palindromesList.OrderBy(a => a).Distinct()));
        }

        static bool CheckIfIsPalindrome(string word)
        {
            var reversedWord = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += (word[i]);
            }
            if (reversedWord == word)
            {
                return true;
            }
            return false;
        }
    }
}