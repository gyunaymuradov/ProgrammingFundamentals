﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentencesByKeyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine().ToLower();
            List<string> text = Console.ReadLine().Split('.', '!', '?').ToList();

            for (int sentence = 0; sentence < text.Count; sentence++)
            {
                string[] result = text[sentence].Split(new char[] { ',', ':', '(', ')', '[', ']', '\"', '\'', '/', '\\', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (result.Contains(keyword))
                {
                    Console.WriteLine(text[sentence].Trim());
                }
            }
        }
    }
}
