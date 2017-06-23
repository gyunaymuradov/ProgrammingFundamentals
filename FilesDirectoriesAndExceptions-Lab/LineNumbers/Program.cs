using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");

            var output = input.Select((line, index) => $"{index + 1}. {line}");

            File.WriteAllLines("numberedOutput.txt", output);
        }
    }
}
