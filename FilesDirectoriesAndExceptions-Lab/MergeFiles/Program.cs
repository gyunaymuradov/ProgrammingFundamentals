using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text1 = File.ReadAllText("text1.txt").Split('\r', '\n');
            string[] text2 = File.ReadAllText("text2.txt").Split('\r', '\n');

            for (int i = 0; i < Math.Max(text1.Length, text2.Length); i++)
            {
                File.AppendAllText("appendedFile.txt", text1[i] + Environment.NewLine + text2[i]);
            }
        }
    }
}
