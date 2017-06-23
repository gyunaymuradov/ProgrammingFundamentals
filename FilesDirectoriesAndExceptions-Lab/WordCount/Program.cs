using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split(' ');
            var wordsDict = new Dictionary<string, int>();
            foreach (var currentWord in words)
            {
                wordsDict.Add(currentWord, 0);
            }
            string[] file = File.ReadAllText("file.txt").ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < file.Length; i++)
            {
                if (wordsDict.ContainsKey(file[i]))
                {
                    wordsDict[file[i]]++;
                }
            }

            foreach (var word in wordsDict.OrderByDescending(a => a.Value))
            {
                File.AppendAllText("newFile.txt", word.Key + " - " + word.Value + Environment.NewLine);
            }
        }
    }
}
