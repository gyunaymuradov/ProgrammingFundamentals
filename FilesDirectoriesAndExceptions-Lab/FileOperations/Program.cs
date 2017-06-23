using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");

            for (int i = 1; i < lines.Length; i += 2)
            {
                File.AppendAllText("output.txt", lines[i] + Environment.NewLine);
            }
        }
    }
}
